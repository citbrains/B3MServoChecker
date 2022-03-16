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

using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace B3MServoChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try {
                serialPort1.Open();
            } catch {
                MessageBox.Show("COMが開けません！！");
                serialPort1.Close();
                this.Close();
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

            _b3m.setAngle(id, 100);
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

            _b3m.setGain((byte)numericUpDownID.Value, 1000, 0, 0);
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

            for (int i = 0; i < 300; i++)
            {
                double angle = 0;
                _b3m.getAngle(id, ref angle);
                if (angle > max_angle) max_angle = angle;
                if (angle < min_angle) min_angle = angle;
                Thread.Sleep(10);
            }
            textBoxBacklash.Text = (max_angle - min_angle).ToString();
        }

        private void buttonBacklashEnd_Click(object sender, EventArgs e)
        {
            _b3m.servoOff((byte)numericUpDownID.Value);
        }
        double min_angle, max_angle;

        private void buttonMinPWM_Click(object sender, EventArgs e)
        {
            byte id = (byte)numericUpDownID.Value;
            _b3m.setFFMode(id);
            _b3m.setPWM(id, 0);
            double angle0 = 0;
            _b3m.getAngle(id, ref angle0);
            for(int i = 0; i < 2000; i += 10)
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
    }
}
