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
using System.Windows.Forms.DataVisualization.Charting;

namespace B3MServoChecker
{
    public partial class FormB3ServoChecker : Form
    {
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
            _b3m.setAngle(id, (double)trackBarPos.Value / 100);
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
            StreamWriter file = new StreamWriter(@"results.csv", false, Encoding.UTF8);
            for (int i = 0; i < 500; i ++)
            {
                file.WriteLine(string.Format("{0}", angle[i]));
            }
            file.Close();
            
            chart1.Series.Clear();  // ← 最初からSeriesが1つあるのでクリアします
            chart1.ChartAreas.Clear();
            string chart_area1 = "Area1";
            chart1.ChartAreas.Add(new ChartArea(chart_area1));
            string legend1 = "Graph1";
            chart1.Series.Add(legend1);
            chart1.Series[legend1].ChartType = SeriesChartType.Line;

            // データを用意します
            double[] x_values = new double[5] { 0.1, 0.2, 0.3, 0.4, 0.5 };
            double[] y_values = new double[5] { 1.0, 1.2, 0.8, 1.8, 0.2 };

            // データをシリーズにセットします
            for (int i = 0; i < y_values.Length; i++)
            {
                chart1.Series[legend1].Points.AddXY(x_values[i], y_values[i]);
            }
        }

        B3MServo _b3m;

        private void buttonTorque_Click(object sender, EventArgs e)
        {
            double[] current = new double[500];
            double[] pwm = new double[500];
            byte id = (byte)numericUpDownID.Value;

            _b3m.setGain((byte)numericUpDownID.Value, 1000, 0, 0, 0, 0);
            readParameters();
            _b3m.setAngle(id, 0);
            Thread.Sleep(1000);
            Debug.WriteLine("START");
            for (int i = 0; i < 500; i++)
            {
                _b3m.getPWM(id, ref pwm[i]);
                Thread.Sleep(5);
                _b3m.getCurrent(id, ref current[i]);
                Thread.Sleep(5);
            }
            Debug.WriteLine("FINISH");
            StreamWriter file = new StreamWriter(@"torque.csv", false, Encoding.UTF8);
            for (int i = 0; i < 500; i++)
            {
                file.WriteLine(string.Format("{0}, {1}", pwm[i], current[i]));
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
            serialPort1.Close();
            serialPort1.PortName = comboBoxPort.Text;
            try
            {
                serialPort1.Open();
            }
            catch
            {
                MessageBox.Show("COMが開けません！！");
                serialPort1.Close();
            }
            readParameters();
        }

        private void comboBoxBitrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.BaudRate = Int32.Parse(comboBoxBitrate.Text);
            try
            {
                serialPort1.Open();
            }
            catch
            {
                MessageBox.Show("COMが開けません！！");
                serialPort1.Close();
            }
            readParameters();
        }

        private void buttonMinPWM_Click(object sender, EventArgs e)
        {
            byte id = (byte)numericUpDownID.Value;
            _b3m.setFFMode(id);
            _b3m.setPWM(id, 0);
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
    }
}
