
namespace B3MServoChecker
{
    partial class FormB3ServoChecker
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonServoOn = new System.Windows.Forms.Button();
            this.trackBarPos = new System.Windows.Forms.TrackBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageStepResp = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStepResponse = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPageTorque = new System.Windows.Forms.TabPage();
            this.textBoxMinPWM = new System.Windows.Forms.TextBox();
            this.buttonMinPWM = new System.Windows.Forms.Button();
            this.textBoxBacklash = new System.Windows.Forms.TextBox();
            this.buttonBacklashEnd = new System.Windows.Forms.Button();
            this.buttonBacklashStart = new System.Windows.Forms.Button();
            this.buttonTorque = new System.Windows.Forms.Button();
            this.numericUpDownID = new System.Windows.Forms.NumericUpDown();
            this.buttonServoOff = new System.Windows.Forms.Button();
            this.comboBoxBitrate = new System.Windows.Forms.ComboBox();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.buttonVibration = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageStepResp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPageTorque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 1000000;
            this.serialPort1.ReadTimeout = 500;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM";
            // 
            // buttonServoOn
            // 
            this.buttonServoOn.Location = new System.Drawing.Point(434, 5);
            this.buttonServoOn.Name = "buttonServoOn";
            this.buttonServoOn.Size = new System.Drawing.Size(98, 23);
            this.buttonServoOn.TabIndex = 2;
            this.buttonServoOn.Text = "servo on";
            this.buttonServoOn.UseVisualStyleBackColor = true;
            this.buttonServoOn.Click += new System.EventHandler(this.buttonServoOn_Click);
            // 
            // trackBarPos
            // 
            this.trackBarPos.LargeChange = 100;
            this.trackBarPos.Location = new System.Drawing.Point(6, 6);
            this.trackBarPos.Maximum = 32000;
            this.trackBarPos.Minimum = -32000;
            this.trackBarPos.Name = "trackBarPos";
            this.trackBarPos.Size = new System.Drawing.Size(780, 56);
            this.trackBarPos.TabIndex = 3;
            this.trackBarPos.Scroll += new System.EventHandler(this.trackBarPos_Scroll);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageStepResp);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageTorque);
            this.tabControl1.Location = new System.Drawing.Point(0, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 404);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageStepResp
            // 
            this.tabPageStepResp.BackColor = System.Drawing.Color.Transparent;
            this.tabPageStepResp.Controls.Add(this.chart1);
            this.tabPageStepResp.Controls.Add(this.buttonStepResponse);
            this.tabPageStepResp.Location = new System.Drawing.Point(4, 25);
            this.tabPageStepResp.Name = "tabPageStepResp";
            this.tabPageStepResp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStepResp.Size = new System.Drawing.Size(792, 375);
            this.tabPageStepResp.TabIndex = 1;
            this.tabPageStepResp.Text = "Step Resp.";
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(6, 48);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(778, 321);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // buttonStepResponse
            // 
            this.buttonStepResponse.Location = new System.Drawing.Point(8, 6);
            this.buttonStepResponse.Name = "buttonStepResponse";
            this.buttonStepResponse.Size = new System.Drawing.Size(112, 28);
            this.buttonStepResponse.TabIndex = 0;
            this.buttonStepResponse.Text = "step response";
            this.buttonStepResponse.UseVisualStyleBackColor = true;
            this.buttonStepResponse.Click += new System.EventHandler(this.buttonStepResponse_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.trackBarPos);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPageTorque
            // 
            this.tabPageTorque.BackColor = System.Drawing.Color.Transparent;
            this.tabPageTorque.Controls.Add(this.trackBar1);
            this.tabPageTorque.Controls.Add(this.buttonVibration);
            this.tabPageTorque.Controls.Add(this.textBoxMinPWM);
            this.tabPageTorque.Controls.Add(this.buttonMinPWM);
            this.tabPageTorque.Controls.Add(this.textBoxBacklash);
            this.tabPageTorque.Controls.Add(this.buttonBacklashEnd);
            this.tabPageTorque.Controls.Add(this.buttonBacklashStart);
            this.tabPageTorque.Controls.Add(this.buttonTorque);
            this.tabPageTorque.Location = new System.Drawing.Point(4, 25);
            this.tabPageTorque.Name = "tabPageTorque";
            this.tabPageTorque.Size = new System.Drawing.Size(792, 375);
            this.tabPageTorque.TabIndex = 2;
            this.tabPageTorque.Text = "Torque";
            // 
            // textBoxMinPWM
            // 
            this.textBoxMinPWM.Location = new System.Drawing.Point(25, 176);
            this.textBoxMinPWM.Name = "textBoxMinPWM";
            this.textBoxMinPWM.Size = new System.Drawing.Size(173, 22);
            this.textBoxMinPWM.TabIndex = 5;
            // 
            // buttonMinPWM
            // 
            this.buttonMinPWM.Location = new System.Drawing.Point(25, 147);
            this.buttonMinPWM.Name = "buttonMinPWM";
            this.buttonMinPWM.Size = new System.Drawing.Size(75, 23);
            this.buttonMinPWM.TabIndex = 4;
            this.buttonMinPWM.Text = "minPWM";
            this.buttonMinPWM.UseVisualStyleBackColor = true;
            this.buttonMinPWM.Click += new System.EventHandler(this.buttonMinPWM_Click);
            // 
            // textBoxBacklash
            // 
            this.textBoxBacklash.Location = new System.Drawing.Point(26, 99);
            this.textBoxBacklash.Name = "textBoxBacklash";
            this.textBoxBacklash.Size = new System.Drawing.Size(172, 22);
            this.textBoxBacklash.TabIndex = 3;
            // 
            // buttonBacklashEnd
            // 
            this.buttonBacklashEnd.Location = new System.Drawing.Point(123, 70);
            this.buttonBacklashEnd.Name = "buttonBacklashEnd";
            this.buttonBacklashEnd.Size = new System.Drawing.Size(75, 23);
            this.buttonBacklashEnd.TabIndex = 2;
            this.buttonBacklashEnd.Text = "free";
            this.buttonBacklashEnd.UseVisualStyleBackColor = true;
            this.buttonBacklashEnd.Click += new System.EventHandler(this.buttonBacklashEnd_Click);
            // 
            // buttonBacklashStart
            // 
            this.buttonBacklashStart.Location = new System.Drawing.Point(25, 70);
            this.buttonBacklashStart.Name = "buttonBacklashStart";
            this.buttonBacklashStart.Size = new System.Drawing.Size(75, 23);
            this.buttonBacklashStart.TabIndex = 1;
            this.buttonBacklashStart.Text = "backlash";
            this.buttonBacklashStart.UseVisualStyleBackColor = true;
            this.buttonBacklashStart.Click += new System.EventHandler(this.buttonBacklashStart_Click);
            // 
            // buttonTorque
            // 
            this.buttonTorque.Location = new System.Drawing.Point(25, 20);
            this.buttonTorque.Name = "buttonTorque";
            this.buttonTorque.Size = new System.Drawing.Size(75, 23);
            this.buttonTorque.TabIndex = 0;
            this.buttonTorque.Text = "measure";
            this.buttonTorque.UseVisualStyleBackColor = true;
            this.buttonTorque.Click += new System.EventHandler(this.buttonTorque_Click);
            // 
            // numericUpDownID
            // 
            this.numericUpDownID.Location = new System.Drawing.Point(308, 7);
            this.numericUpDownID.Name = "numericUpDownID";
            this.numericUpDownID.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownID.TabIndex = 5;
            // 
            // buttonServoOff
            // 
            this.buttonServoOff.Location = new System.Drawing.Point(538, 6);
            this.buttonServoOff.Name = "buttonServoOff";
            this.buttonServoOff.Size = new System.Drawing.Size(90, 23);
            this.buttonServoOff.TabIndex = 6;
            this.buttonServoOff.Text = "servo off";
            this.buttonServoOff.UseVisualStyleBackColor = true;
            this.buttonServoOff.Click += new System.EventHandler(this.buttonServoOff_Click);
            // 
            // comboBoxBitrate
            // 
            this.comboBoxBitrate.FormattingEnabled = true;
            this.comboBoxBitrate.Items.AddRange(new object[] {
            "115200",
            "1000000",
            "1250000",
            "1500000",
            "2000000",
            "3000000"});
            this.comboBoxBitrate.Location = new System.Drawing.Point(181, 6);
            this.comboBoxBitrate.Name = "comboBoxBitrate";
            this.comboBoxBitrate.Size = new System.Drawing.Size(121, 23);
            this.comboBoxBitrate.TabIndex = 7;
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(57, 5);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 23);
            this.comboBoxPort.TabIndex = 8;
            // 
            // buttonVibration
            // 
            this.buttonVibration.Location = new System.Drawing.Point(25, 224);
            this.buttonVibration.Name = "buttonVibration";
            this.buttonVibration.Size = new System.Drawing.Size(94, 23);
            this.buttonVibration.TabIndex = 6;
            this.buttonVibration.Text = "vibration";
            this.buttonVibration.UseVisualStyleBackColor = true;
            this.buttonVibration.Click += new System.EventHandler(this.buttonVibration_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(26, 253);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(744, 56);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 1000;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // FormB3ServoChecker
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.comboBoxBitrate);
            this.Controls.Add(this.buttonServoOff);
            this.Controls.Add(this.buttonServoOn);
            this.Controls.Add(this.numericUpDownID);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "FormB3ServoChecker";
            this.Text = "B3M Servo Checker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageStepResp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageTorque.ResumeLayout(false);
            this.tabPageTorque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonServoOn;
        private System.Windows.Forms.TrackBar trackBarPos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageStepResp;
        private System.Windows.Forms.Button buttonStepResponse;
        private System.Windows.Forms.NumericUpDown numericUpDownID;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPageTorque;
        private System.Windows.Forms.Button buttonTorque;
        private System.Windows.Forms.TextBox textBoxBacklash;
        private System.Windows.Forms.Button buttonBacklashEnd;
        private System.Windows.Forms.Button buttonBacklashStart;
        private System.Windows.Forms.Button buttonMinPWM;
        private System.Windows.Forms.TextBox textBoxMinPWM;
        private System.Windows.Forms.Button buttonServoOff;
        private System.Windows.Forms.ComboBox comboBoxBitrate;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Button buttonVibration;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

