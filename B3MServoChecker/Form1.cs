using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.IO.Ports;
using System.Diagnostics;
using Extensions.Collections;

namespace B3MServoChecker
{
    public partial class FormB3ServoChecker : Form
    {
        B3MServo _b3m;
        bool is_all_parameters_set = false;

        public FormB3ServoChecker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBoxPort.Items.Add(port);
            }
            _b3m = new B3MServo(serialPort1);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        private void buttonServoOn_Click(object sender, EventArgs e)
        {
            _b3m.servoOn((byte)numericUpDownID.Value);
        }

        private void trackBarPos_Scroll(object sender, EventArgs e)
        {
            byte id = (byte)numericUpDownID.Value;
            int target_angle = trackBarPos.Value;
            textBoxTargetAngle.Text = string.Format("{0}", target_angle);
            _b3m.setAngle(id, (double)target_angle);
        }

        private void buttonStepResponse_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            double period = 2;
            double p1 = sw.Elapsed.TotalMilliseconds - period;
            double p2 = sw.Elapsed.TotalMilliseconds;
            double[] angle = new double[500];
            Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
            byte id = (byte)numericUpDownID.Value;
            _b3m.setGain(id, 1000, 0, 0, 0, 0);
            readParameters();

            _b3m.setAngleWithPosControl(id, 10);
            Thread.Sleep(1000);
            _b3m.setAngle(id, 0);
            for (int i = 0; i < 500;)
            {
                if ((p2 - p1) >= period)
                {
                    p1 = p2;
                    _b3m.getAngle(id, ref angle[i]);
                    i ++;
                }
                p2 = sw.Elapsed.TotalMilliseconds;
            }
            Debug.WriteLine("FINISH");
            StreamWriter file = new StreamWriter(@"step_response.csv", false, Encoding.UTF8);
            for (int i = 0; i < 500; i ++)
            {
                file.WriteLine(string.Format("{0}", angle[i]));
            }
            file.Close();
        }

        private void buttonBacklashStart_Click(object sender, EventArgs e)
        {
            byte id = (byte)numericUpDownID.Value;
            _b3m.servoOn(id);
            min_angle = 1000;
            max_angle = -1000;

            textBoxBacklash.Text = "";
            for (int i = 0; i < 300; i++)
            {
                double angle = 0;
                _b3m.getAngle(id, ref angle);
                if (angle > max_angle) max_angle = angle;
                if (angle < min_angle) min_angle = angle;
                Thread.Sleep(10);
                progressBarBacklash.Value = i / 3;
            }
            textBoxBacklash.Text = string.Format("{0:F3}", max_angle - min_angle);
            progressBarBacklash.Value = 0;
        }

        private void buttonBacklashEnd_Click(object sender, EventArgs e)
        {
            _b3m.servoOff((byte)numericUpDownID.Value);
        }
        double min_angle, max_angle;

        private void buttonServoOff_Click(object sender, EventArgs e)
        {
            _b3m.servoOff((byte)numericUpDownID.Value);
        }

        private void buttonVibration_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            double period = 100;
            double p1 = sw.Elapsed.TotalMilliseconds - period;
            double p2 = sw.Elapsed.TotalMilliseconds;

            byte id = (byte)numericUpDownID.Value;
            _b3m.setFFMode(id);
            _b3m.setPWM(id, 0);
            double pwm = 500;

            for(double freq = 100; freq > 2; freq /= 2)
            for (int i = 0; i < (1000 / freq);) 
            {
                if ((p2 - p1) >= freq)
                {
                    p1 = p2;
                    pwm *= -1;
                    _b3m.setPWM(id, pwm);
                    i++;
                }
                p2 = sw.Elapsed.TotalMilliseconds;
            }
            _b3m.setPWM(id, 0);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            freq = trackBar1.Value;
        }
        int freq = 1000;

        private void comboBoxPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool find_ID = true;
            serialPort1.Close();
            serialPort1.PortName = comboBoxPort.Text;
            try
            {
                serialPort1.Open();
            }
            catch
            {
                MessageBox.Show("Cannot open COM");
                serialPort1.Close();
                return;
            }
            if (!_b3m.servoOff((byte)numericUpDownID.Value))
            {
                find_ID = false;
                for(int i = 0;i < 30; i++)
                {
                    numericUpDownID.Value = i;
                    if (_b3m.servoOff((byte)i)) 
                    {
                        find_ID = true;
                        break;
                    }
                }
            }
            if (find_ID)
            {
                is_all_parameters_set = false;
                readParameters();
                is_all_parameters_set = true;
            }
        }

        private void comboBoxBitrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.BaudRate = Int32.Parse(comboBoxBitrate.Text);
        }

        private void buttonMinPWM_Click(object sender, EventArgs e)
        {
            byte id = (byte)numericUpDownID.Value;
            _b3m.servoOffControlFForward(id);
            _b3m.setPWM(id, 0);
            _b3m.setFFMode(id);
            double angle0 = 0;
            _b3m.getAngle(id, ref angle0);
            for(int i = 0; i < 2000; i += 1)
            {
                _b3m.setPWM(id, (double)i);
                textBoxMinPWM.Text = i.ToString();
                Thread.Sleep(5);
                double angle = 0;
                _b3m.getAngle(id, ref angle);
                if (Math.Abs(angle - angle0) > 3) break;
                Thread.Sleep(5);
            }
            _b3m.setPWM(id, 0);
        }

        private void pictureBoxAngle_Paint(object sender, PaintEventArgs e)
        {
            double angle = 0;
            byte id = (byte)numericUpDownID.Value;
            _b3m.getAngle(id, ref angle);
            e.Graphics.DrawEllipse(Pens.Black, 15, 15, 120, 120);
            double angle_rad = angle / 180 * Math.PI;
            e.Graphics.DrawLine(Pens.Red, 75, 75, (float)(60 * Math.Sin(-angle_rad + Math.PI) + 75), (float)(60 * Math.Cos(-angle_rad + Math.PI) + 75));
            textBoxAngle.Text = string.Format("{0:F3}", angle);
        }

        private void timerPictureBoxAngle_Tick(object sender, EventArgs e)
        {
            pictureBoxAngle.Invalidate();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageBacklash)
            {
                timerPictureBoxAngle.Start();
            }
            else
            {
                timerPictureBoxAngle.Stop();
            }
        }

        private void readParameters()
        {
            double system_clock = 50000000.0;
            byte id = (byte)numericUpDownID.Value;
            short pwm_frequency = 0;
            _b3m.getPWMFrequency(id, ref pwm_frequency);
            numericUpDownPWMFrequency.Value = pwm_frequency;
            double kp = 0, kd = 0, ki = 0, static_friction = 0, dynamic_friction = 0;
            _b3m.getGain(id, ref kp, ref kd, ref ki, ref static_friction, ref dynamic_friction);
            numericUpDownKp.Value = (decimal)(kp / (system_clock / pwm_frequency));
            numericUpDownKd.Value = (decimal)(kd / (system_clock / pwm_frequency));
            numericUpDownKi.Value = (decimal)(ki / (system_clock / pwm_frequency));
            numericUpDownStatic.Value = (decimal)(static_friction / (system_clock / pwm_frequency));
            numericUpDownDynamic.Value = (decimal)(dynamic_friction / (system_clock / pwm_frequency));
        }

        private void numericUpDownParameter_ValueChanged(object sender, EventArgs e)
        {
            if (is_all_parameters_set) writeParameters();
        }

        private void writeParameters()
        {
            double system_clock = 50000000.0;
            byte id = (byte)numericUpDownID.Value;
            short pwm_frequency = (short)numericUpDownPWMFrequency.Value;
            _b3m.setPWMFrequency(id, pwm_frequency);
            short kp = (short)((double)numericUpDownKp.Value * system_clock / pwm_frequency);
            short kd = (short)((double)numericUpDownKd.Value * system_clock / pwm_frequency);
            short ki = (short)((double)numericUpDownKi.Value * system_clock / pwm_frequency);
            short static_friction = (short)((double)numericUpDownStatic.Value * system_clock / pwm_frequency);
            short dynamic_friction = (short)((double)numericUpDownDynamic.Value * system_clock / pwm_frequency);
            _b3m.setGain(id, kp, kd, ki, static_friction, dynamic_friction);
        }

        private void buttonCurrent_Click(object sender, EventArgs e)
        {
            double[] current = new double[500];
            double[] pwm = new double[500];
            byte id = (byte)numericUpDownID.Value;

            _b3m.setGain(id, 1000, 0, 0, 0, 0);
            readParameters();
            for (int i = 0; i < 500; i++)
            {
                _b3m.getPWM(id, ref pwm[i]);
                Thread.Sleep(5);
                _b3m.getCurrent(id, ref current[i]);
                Thread.Sleep(5);
            }
            StreamWriter file = new StreamWriter(@"pwm_current.csv", false, Encoding.UTF8);
            file.WriteLine("Duty ratio, Current(A)");
            for (int i = 0; i < 500; i++)
            {
                file.WriteLine(string.Format("{0}, {1}", pwm[i], current[i]));
            }
            file.Close();
        }

        private void buttonPWMDuty_Click(object sender, EventArgs e)
        {
            double angular_vel = 0;
            double[] angle = new double[500];
            double[] angular_velocity = new double[500];
            byte id = (byte)numericUpDownID.Value;
            double tc = (double)numericUpDownSpeedFilter.Value;
            double pwm_duty = (double)numericUpDownPWMDuty.Value;
            _b3m.servoOffControlFForward(id);
            _b3m.setPWM(id, 0);
            _b3m.setFFMode(id);
            _b3m.setPWM(id, pwm_duty);
            Thread.Sleep(1000);
            _b3m.getAngularVelocity(id, ref angular_velocity[0]);
            for (int i = 1; i < 100; i += 1)
            {
                _b3m.getAngularVelocity(id, ref angular_vel);
                angular_velocity[i] = tc * angular_velocity[i - 1] + (1.0 - tc) * angular_vel;
                Thread.Sleep(10);
            }
            _b3m.getAngle(id, ref angle[0]);
            angular_velocity[0] = angular_velocity[100 - 1];
            double x0 = 300, y0 = 300, xr = 280.0 / 180, yr = 300.0 / 100;
            Graphics g = this.pictureBoxSpeed.CreateGraphics();
            g.DrawLine(Pens.Black, (int)(-180 * xr + x0), (int)y0, (int)(180 * xr + x0), (int)y0);
            g.DrawLine(Pens.Black, (int)x0, (int)y0, (int)x0, 0);
            Bitmap p = new Bitmap(this.pictureBoxSpeed.Width, this.pictureBoxSpeed.Height);
            for (int i = 1; i < 500; i += 1)
            {
                _b3m.getAngle(id, ref angle[i]);
                Thread.Sleep(5);
                _b3m.getAngularVelocity(id, ref angular_vel);
                angular_velocity[i] = tc * angular_velocity[i - 1] + (1.0 - tc) * angular_vel;
                progressBarSpeed.Value = i / 5;
                Thread.Sleep(5);
                int y = (int)(-angular_velocity[i] * yr + y0);
                y = Math.Max(Math.Min(y, this.pictureBoxSpeed.Height - 1), 0);
                p.SetPixel((int)(angle[i] * xr + x0), y, Color.Black);
                g.DrawImageUnscaled(p, 0, 0);
            }
            _b3m.servoOff(id);
            progressBarSpeed.Value = 0;
            StreamWriter file = new StreamWriter(@"speed.csv", false, Encoding.UTF8);
            file.WriteLine("angle(deg), speed(deg/s)");
            for (int i = 0; i < 500; i++)
            {
                file.WriteLine(string.Format("{0}, {1}", angle[i], angular_velocity[i]));
            }
            file.Close();
        }

        private void buttonExpStart_Click(object sender, EventArgs e)
        {
            const int num_data = 100;
            short target_pwm_duty = 1250; 
            double angular_vel = 0;
            double[] angle = new double[num_data];
            double[] angular_velocity = new double[num_data];
            byte id = (byte)numericUpDownID.Value;
            double tc = (double)numericUpDownSpeedFilter.Value;
            short pwm_freq = 0;
            _b3m.getPWMFrequency(id, ref pwm_freq);
            if (pwm_freq != 20000)
            {
                MessageBox.Show("PWM Freq should be 20000Hz");
                return;
            }
            _b3m.servoOffControlFForward(id);
            _b3m.setPWM(id, 0);
            _b3m.setFFMode(id);

            for (int i = 1; i < 100; i += 1)
            {
                numericUpDownPWMDuty.Value = target_pwm_duty * (i + 1) / 100;
                _b3m.setPWM(id, (double)numericUpDownPWMDuty.Value);
                Thread.Sleep(30);
            }
            _b3m.getAngularVelocity(id, ref angular_velocity[0]);
            for (int i = 1; i < 100; i += 1)
            {
                _b3m.getAngularVelocity(id, ref angular_vel);
                angular_velocity[i] = tc * angular_velocity[i - 1] + (1.0 - tc) * angular_vel;
                Thread.Sleep(10);
            }
            _b3m.getAngle(id, ref angle[0]);
            angular_velocity[0] = angular_velocity[100 - 1];
            double x0 = 300, y0 = 290, xr = 280.0 / 180, yr = 290.0 / 300;
            Graphics g = this.pictureBoxSpeed.CreateGraphics();
            g.DrawLine(Pens.Black, (int)(-180 * xr + x0), (int)y0, (int)(180 * xr + x0), (int)y0);
            g.DrawLine(Pens.Black, (int)x0, (int)y0, (int)x0, 0);
            Bitmap p = new Bitmap(this.pictureBoxSpeed.Width, this.pictureBoxSpeed.Height);
            for (int i = 1; i < num_data; i += 1)
            {
                _b3m.getAngle(id, ref angle[i]);
                Thread.Sleep(5);
                _b3m.getAngularVelocity(id, ref angular_vel);
                angular_velocity[i] = tc * angular_velocity[i - 1] + (1.0 - tc) * angular_vel;
                progressBarSpeed.Value = i / 1;
                Thread.Sleep(5);
                int y = (int)(-angular_velocity[i] * yr + y0);
                y = Math.Max(Math.Min(y, this.pictureBoxSpeed.Height - 1), 0);
                p.SetPixel((int)(angle[i] * xr + x0), y, Color.Black);
                g.DrawImageUnscaled(p, 0, 0);
            }
            for (int i = 1; i < 100; i += 1)
            {
                numericUpDownPWMDuty.Value = target_pwm_duty * (100 - i) / 100;
                _b3m.setPWM(id, (double)numericUpDownPWMDuty.Value);
                Thread.Sleep(30);
            }
            _b3m.servoOff(id);
            progressBarSpeed.Value = 0;
            double sum_angular_velocity = 0;
            for (int i = 0; i < num_data; i++)
            {
                sum_angular_velocity += angular_velocity[i];
            }
            textBoxExp1Result.Text = string.Format("{0:F3}", sum_angular_velocity / num_data);
            StreamWriter file = new StreamWriter(@"exp1.csv", false, Encoding.UTF8);
            file.WriteLine("angle(deg), speed(deg/s)");
            for (int i = 0; i < num_data; i++)
            {
                file.WriteLine(string.Format("{0}, {1}", angle[i], angular_velocity[i]));
            }
            file.Close();
        }

        private void buttonControl0deg_Click(object sender, EventArgs e)
        {
            byte id = (byte)numericUpDownID.Value;
            _b3m.setAngle(id, 0);
        }

        private void buttonControl45deg_Click(object sender, EventArgs e)
        {
            byte id = (byte)numericUpDownID.Value;
            _b3m.setAngle(id, 45);
        }

        private void buttonControl90deg_Click(object sender, EventArgs e)
        {
            byte id = (byte)numericUpDownID.Value;
            _b3m.setAngle(id, 90);
        }

        private void buttonControl315deg_Click(object sender, EventArgs e)
        {
            byte id = (byte)numericUpDownID.Value;
            _b3m.setAngle(id, -45);
        }

        private void buttonControl270deg_Click(object sender, EventArgs e)
        {
            byte id = (byte)numericUpDownID.Value;
            _b3m.setAngle(id, -90);
        }

        private void buttonGetAllParameters_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"servo_parameters.csv", false, Encoding.UTF8);
            file.WriteLine("ID, TYPE, POS_MIN, POS_MAX, POS_CEN, FREQ, DEADBAND, PWM_LIM, GAIN_PRE, KP0, KD0, KI0, STATIC0, DYNAMIC0, KP1, KD1, KI1, STATIC1, DYNAMIC1, KP2, KD2, KI2, STATIC2, DYNAMIC2");
            for (byte id = 1; id <= 19; id++)
            {
                byte motor_type = 0, torque_type = 0;
                byte val_byte = 0;
                short val_short = 0;
                long val_long = 0;
                _b3m.getModel(id, ref motor_type, ref torque_type);
                file.Write(string.Format("{0}, ", id));
                if (motor_type == 'B' && torque_type == 4) file.Write("B3M-SB-1040-A, ");
                else if (motor_type == 'C' && torque_type == 4) file.Write("B3M-SC-1040-A, ");
                else if (motor_type == 'C' && torque_type == 7) file.Write("B3M-SC-1170-A, ");
                _b3m.getDataShort(id, B3MLib.B3MLib.SYSTEM_POSITION_MIN, ref val_short);
                file.Write(string.Format("{0}, ", val_short));
                _b3m.getDataShort(id, B3MLib.B3MLib.SYSTEM_POSITION_MAX, ref val_short);
                file.Write(string.Format("{0}, ", val_short));
                _b3m.getDataShort(id, B3MLib.B3MLib.SYSTEM_POSITION_CENTER, ref val_short);
                file.Write(string.Format("{0}, ", val_short));
                _b3m.getDataShort(id, B3MLib.B3MLib.SERVO_PWM_FREQUENCY, ref val_short);
                file.Write(string.Format("{0}, ", val_short));
                _b3m.getDataShort(id, B3MLib.B3MLib.SYSTEM_DEADBAND_WIDTH, ref val_short);
                file.Write(string.Format("{0}, ", val_short));
                _b3m.getDataByte(id, B3MLib.B3MLib.SYSTEM_PWM_LIMIT, ref val_byte);
                file.Write(string.Format("{0}, ", val_byte));
                _b3m.getDataByte(id, B3MLib.B3MLib.CONTROL_GAIN_PRESET, ref val_byte);
                file.Write(string.Format("{0}, ", val_byte));
                _b3m.getDataLong(id, B3MLib.B3MLib.CONTROL_KP0, ref val_long);
                file.Write(string.Format("{0}, ", val_long));
                _b3m.getDataLong(id, B3MLib.B3MLib.CONTROL_KD0, ref val_long);
                file.Write(string.Format("{0}, ", val_long));
                _b3m.getDataLong(id, B3MLib.B3MLib.CONTROL_KI0, ref val_long);
                file.Write(string.Format("{0}, ", val_long));
                _b3m.getDataShort(id, B3MLib.B3MLib.CONTROL_STATIC_FRICTION0, ref val_short);
                file.Write(string.Format("{0}, ", val_short));
                _b3m.getDataShort(id, B3MLib.B3MLib.CONTROL_DYNAMIC_FRICTION0, ref val_short);
                file.Write(string.Format("{0}, ", val_short));
                _b3m.getDataLong(id, B3MLib.B3MLib.CONTROL_KP1, ref val_long);
                file.Write(string.Format("{0}, ", val_long));
                _b3m.getDataLong(id, B3MLib.B3MLib.CONTROL_KD1, ref val_long);
                file.Write(string.Format("{0}, ", val_long));
                _b3m.getDataLong(id, B3MLib.B3MLib.CONTROL_KI1, ref val_long);
                file.Write(string.Format("{0}, ", val_long));
                _b3m.getDataShort(id, B3MLib.B3MLib.CONTROL_STATIC_FRICTION1, ref val_short);
                file.Write(string.Format("{0}, ", val_short));
                _b3m.getDataShort(id, B3MLib.B3MLib.CONTROL_DYNAMIC_FRICTION1, ref val_short);
                file.Write(string.Format("{0}, ", val_short));
                _b3m.getDataLong(id, B3MLib.B3MLib.CONTROL_KP2, ref val_long);
                file.Write(string.Format("{0}, ", val_long));
                _b3m.getDataLong(id, B3MLib.B3MLib.CONTROL_KD2, ref val_long);
                file.Write(string.Format("{0}, ", val_long));
                _b3m.getDataLong(id, B3MLib.B3MLib.CONTROL_KI2, ref val_long);
                file.Write(string.Format("{0}, ", val_long));
                _b3m.getDataShort(id, B3MLib.B3MLib.CONTROL_STATIC_FRICTION2, ref val_short);
                file.Write(string.Format("{0}, ", val_short));
                _b3m.getDataShort(id, B3MLib.B3MLib.CONTROL_DYNAMIC_FRICTION2, ref val_short);
                file.Write(string.Format("{0}, ", val_short));

                file.WriteLine("");
            }
            file.Close();
        }

        private void buttonSetParameters_Click(object sender, EventArgs e)
        {
            byte motor_type = 0, torque_type = 0;
            byte id = (byte)numericUpDownID.Value;
            _b3m.getModel(id, ref motor_type, ref torque_type);
            if (motor_type == 'B' && torque_type == 4)
            {
                textBoxServoType.Text = "B3M-SB-1040-A";
                // save parameters
                _b3m.setDataLong(id, B3MLib.B3MLib.SYSTEM_BAUDRATE, 1000000);
                _b3m.setDataShort(id, B3MLib.B3MLib.SYSTEM_POSITION_MIN, -32000);
                _b3m.setDataShort(id, B3MLib.B3MLib.SYSTEM_POSITION_MAX, 32000);
                //_b3m.setDataShort(id, B3MLib.B3MLib.SYSTEM_POSITION_CENTER, 0);
                _b3m.setDataShort(id, B3MLib.B3MLib.SERVO_PWM_FREQUENCY, 8000);
                _b3m.setDataShort(id, B3MLib.B3MLib.SYSTEM_DEADBAND_WIDTH, 15);
                _b3m.setDataByte(id, B3MLib.B3MLib.SYSTEM_PWM_LIMIT, 100);
                _b3m.setDataByte(id, B3MLib.B3MLib.CONTROL_GAIN_PRESET, 0);
                _b3m.saveROM(id);
                readParameters();
                textBoxSetParameterResult.Text = "Success";
            }
            else if (motor_type == 'C' && torque_type == 4)
            {
                textBoxServoType.Text = "B3M-SC-1040-A";
                // save parameters
                _b3m.setDataLong(id, B3MLib.B3MLib.SYSTEM_BAUDRATE, 1000000);
                _b3m.setDataShort(id, B3MLib.B3MLib.SYSTEM_POSITION_MIN, -32000);
                _b3m.setDataShort(id, B3MLib.B3MLib.SYSTEM_POSITION_MAX, 32000);
                //_b3m.setDataShort(id, B3MLib.B3MLib.SYSTEM_POSITION_CENTER, 0);
                _b3m.setDataShort(id, B3MLib.B3MLib.SERVO_PWM_FREQUENCY, 8000);
                _b3m.setDataShort(id, B3MLib.B3MLib.SYSTEM_DEADBAND_WIDTH, 15);
                _b3m.setDataByte(id, B3MLib.B3MLib.SYSTEM_PWM_LIMIT, 100);
                _b3m.setDataByte(id, B3MLib.B3MLib.CONTROL_GAIN_PRESET, 0);
                _b3m.setDataLong(id, B3MLib.B3MLib.CONTROL_KP0, 35000);
                _b3m.setDataLong(id, B3MLib.B3MLib.CONTROL_KD0, 500);
                _b3m.setDataLong(id, B3MLib.B3MLib.CONTROL_KI0, 1800);
                _b3m.setDataShort(id, B3MLib.B3MLib.CONTROL_STATIC_FRICTION0, 0);
                _b3m.setDataShort(id, B3MLib.B3MLib.CONTROL_DYNAMIC_FRICTION0, 0);
                _b3m.setDataLong(id, B3MLib.B3MLib.CONTROL_KP1, 5500);
                _b3m.setDataLong(id, B3MLib.B3MLib.CONTROL_KD1, 100);
                _b3m.setDataLong(id, B3MLib.B3MLib.CONTROL_KI1, 580);
                _b3m.setDataShort(id, B3MLib.B3MLib.CONTROL_STATIC_FRICTION1, 100);
                _b3m.setDataShort(id, B3MLib.B3MLib.CONTROL_DYNAMIC_FRICTION1, 50);
                _b3m.setDataLong(id, B3MLib.B3MLib.CONTROL_KP2, 100000);
                _b3m.setDataLong(id, B3MLib.B3MLib.CONTROL_KD2, 500);
                _b3m.setDataLong(id, B3MLib.B3MLib.CONTROL_KI2, 10000);
                _b3m.setDataShort(id, B3MLib.B3MLib.CONTROL_STATIC_FRICTION2, 100);
                _b3m.setDataShort(id, B3MLib.B3MLib.CONTROL_DYNAMIC_FRICTION2, 50);
                _b3m.saveROM(id);
                readParameters();
                textBoxSetParameterResult.Text = "Success";
            }
            else if (motor_type == 'C' && torque_type == 7)
            {
                textBoxServoType.Text = "B3M-SC-1170-A";
                // save parameters
                _b3m.setDataLong(id, B3MLib.B3MLib.SYSTEM_BAUDRATE, 1000000);
                _b3m.setDataShort(id, B3MLib.B3MLib.SYSTEM_POSITION_MIN, -32000);
                _b3m.setDataShort(id, B3MLib.B3MLib.SYSTEM_POSITION_MAX, 32000);
                //_b3m.setDataShort(id, B3MLib.B3MLib.SYSTEM_POSITION_CENTER, 0);
                _b3m.setDataShort(id, B3MLib.B3MLib.SERVO_PWM_FREQUENCY, 8000);
                _b3m.setDataShort(id, B3MLib.B3MLib.SYSTEM_DEADBAND_WIDTH, 15);
                _b3m.setDataByte(id, B3MLib.B3MLib.SYSTEM_PWM_LIMIT, 100);
                _b3m.setDataByte(id, B3MLib.B3MLib.CONTROL_GAIN_PRESET, 0);
                _b3m.setDataLong(id, B3MLib.B3MLib.CONTROL_KP0, 42000);
                _b3m.setDataLong(id, B3MLib.B3MLib.CONTROL_KD0, 400);
                _b3m.setDataLong(id, B3MLib.B3MLib.CONTROL_KI0, 1000);
                _b3m.setDataShort(id, B3MLib.B3MLib.CONTROL_STATIC_FRICTION0, 0);
                _b3m.setDataShort(id, B3MLib.B3MLib.CONTROL_DYNAMIC_FRICTION0, 0);
                _b3m.setDataLong(id, B3MLib.B3MLib.CONTROL_KP1, 0);
                _b3m.setDataLong(id, B3MLib.B3MLib.CONTROL_KD1, 0);
                _b3m.setDataLong(id, B3MLib.B3MLib.CONTROL_KI1, 0);
                _b3m.setDataShort(id, B3MLib.B3MLib.CONTROL_STATIC_FRICTION1, 0);
                _b3m.setDataShort(id, B3MLib.B3MLib.CONTROL_DYNAMIC_FRICTION1, 0);
                _b3m.setDataLong(id, B3MLib.B3MLib.CONTROL_KP2, 42000);
                _b3m.setDataLong(id, B3MLib.B3MLib.CONTROL_KD2, 750);
                _b3m.setDataLong(id, B3MLib.B3MLib.CONTROL_KI2, 6000);
                _b3m.setDataShort(id, B3MLib.B3MLib.CONTROL_STATIC_FRICTION2, 0);
                _b3m.setDataShort(id, B3MLib.B3MLib.CONTROL_DYNAMIC_FRICTION2, 50);
                _b3m.saveROM(id);
                readParameters();
                textBoxSetParameterResult.Text = "Success";
            }
            else
            {
                textBoxServoType.Text = "Not found";
                textBoxSetParameterResult.Text = "Failure";
            }
        }
    }
}
