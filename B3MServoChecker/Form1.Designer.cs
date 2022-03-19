
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonServoOn = new System.Windows.Forms.Button();
            this.trackBarPos = new System.Windows.Forms.TrackBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBasic = new System.Windows.Forms.TabPage();
            this.tabPageStepResp = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStepResponse = new System.Windows.Forms.Button();
            this.tabPageTorque = new System.Windows.Forms.TabPage();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonVibration = new System.Windows.Forms.Button();
            this.textBoxMinPWM = new System.Windows.Forms.TextBox();
            this.buttonMinPWM = new System.Windows.Forms.Button();
            this.buttonTorque = new System.Windows.Forms.Button();
            this.tabPageBacklash = new System.Windows.Forms.TabPage();
            this.numericUpDownID = new System.Windows.Forms.NumericUpDown();
            this.buttonServoOff = new System.Windows.Forms.Button();
            this.comboBoxBitrate = new System.Windows.Forms.ComboBox();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.numericUpDownKp = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownKd = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownKi = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownStatic = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownDynamic = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownPWMFrequency = new System.Windows.Forms.NumericUpDown();
            this.buttonBacklashFree = new System.Windows.Forms.Button();
            this.buttonBacklash = new System.Windows.Forms.Button();
            this.textBoxBacklash = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPageSetParameter = new System.Windows.Forms.TabPage();
            this.progressBarBacklash = new System.Windows.Forms.ProgressBar();
            this.pictureBoxAngle = new System.Windows.Forms.PictureBox();
            this.timerPictureBoxAngle = new System.Windows.Forms.Timer(this.components);
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabBasic.SuspendLayout();
            this.tabPageStepResp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPageTorque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabPageBacklash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStatic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDynamic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPWMFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAngle)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM";
            // 
            // buttonServoOn
            // 
            this.buttonServoOn.Location = new System.Drawing.Point(280, 0);
            this.buttonServoOn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonServoOn.Name = "buttonServoOn";
            this.buttonServoOn.Size = new System.Drawing.Size(72, 20);
            this.buttonServoOn.TabIndex = 2;
            this.buttonServoOn.Text = "Servo On";
            this.toolTip1.SetToolTip(this.buttonServoOn, "Servo On in Position Control");
            this.buttonServoOn.UseVisualStyleBackColor = true;
            this.buttonServoOn.Click += new System.EventHandler(this.buttonServoOn_Click);
            // 
            // trackBarPos
            // 
            this.trackBarPos.LargeChange = 100;
            this.trackBarPos.Location = new System.Drawing.Point(4, 5);
            this.trackBarPos.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarPos.Maximum = 32000;
            this.trackBarPos.Minimum = -32000;
            this.trackBarPos.Name = "trackBarPos";
            this.trackBarPos.Size = new System.Drawing.Size(604, 45);
            this.trackBarPos.TabIndex = 3;
            this.trackBarPos.Scroll += new System.EventHandler(this.trackBarPos_Scroll);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBasic);
            this.tabControl1.Controls.Add(this.tabPageStepResp);
            this.tabControl1.Controls.Add(this.tabPageTorque);
            this.tabControl1.Controls.Add(this.tabPageBacklash);
            this.tabControl1.Controls.Add(this.tabPageSetParameter);
            this.tabControl1.Location = new System.Drawing.Point(0, 56);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(624, 384);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabBasic
            // 
            this.tabBasic.BackColor = System.Drawing.Color.Transparent;
            this.tabBasic.Controls.Add(this.trackBarPos);
            this.tabBasic.Location = new System.Drawing.Point(4, 22);
            this.tabBasic.Margin = new System.Windows.Forms.Padding(2);
            this.tabBasic.Name = "tabBasic";
            this.tabBasic.Padding = new System.Windows.Forms.Padding(2);
            this.tabBasic.Size = new System.Drawing.Size(616, 358);
            this.tabBasic.TabIndex = 0;
            this.tabBasic.Text = "Basic";
            // 
            // tabPageStepResp
            // 
            this.tabPageStepResp.BackColor = System.Drawing.Color.Transparent;
            this.tabPageStepResp.Controls.Add(this.chart1);
            this.tabPageStepResp.Controls.Add(this.buttonStepResponse);
            this.tabPageStepResp.Location = new System.Drawing.Point(4, 22);
            this.tabPageStepResp.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageStepResp.Name = "tabPageStepResp";
            this.tabPageStepResp.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageStepResp.Size = new System.Drawing.Size(616, 358);
            this.tabPageStepResp.TabIndex = 1;
            this.tabPageStepResp.Text = "Step Resp.";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 32);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(616, 328);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // buttonStepResponse
            // 
            this.buttonStepResponse.Location = new System.Drawing.Point(8, 0);
            this.buttonStepResponse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStepResponse.Name = "buttonStepResponse";
            this.buttonStepResponse.Size = new System.Drawing.Size(120, 20);
            this.buttonStepResponse.TabIndex = 0;
            this.buttonStepResponse.Text = "Step Response";
            this.buttonStepResponse.UseVisualStyleBackColor = true;
            this.buttonStepResponse.Click += new System.EventHandler(this.buttonStepResponse_Click);
            // 
            // tabPageTorque
            // 
            this.tabPageTorque.BackColor = System.Drawing.Color.Transparent;
            this.tabPageTorque.Controls.Add(this.trackBar1);
            this.tabPageTorque.Controls.Add(this.buttonVibration);
            this.tabPageTorque.Controls.Add(this.textBoxMinPWM);
            this.tabPageTorque.Controls.Add(this.buttonMinPWM);
            this.tabPageTorque.Controls.Add(this.buttonTorque);
            this.tabPageTorque.Location = new System.Drawing.Point(4, 22);
            this.tabPageTorque.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageTorque.Name = "tabPageTorque";
            this.tabPageTorque.Size = new System.Drawing.Size(616, 358);
            this.tabPageTorque.TabIndex = 2;
            this.tabPageTorque.Text = "Torque";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(20, 202);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(558, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 1000;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // buttonVibration
            // 
            this.buttonVibration.Location = new System.Drawing.Point(19, 179);
            this.buttonVibration.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVibration.Name = "buttonVibration";
            this.buttonVibration.Size = new System.Drawing.Size(70, 18);
            this.buttonVibration.TabIndex = 6;
            this.buttonVibration.Text = "vibration";
            this.buttonVibration.UseVisualStyleBackColor = true;
            this.buttonVibration.Click += new System.EventHandler(this.buttonVibration_Click);
            // 
            // textBoxMinPWM
            // 
            this.textBoxMinPWM.Location = new System.Drawing.Point(19, 141);
            this.textBoxMinPWM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMinPWM.Name = "textBoxMinPWM";
            this.textBoxMinPWM.Size = new System.Drawing.Size(131, 19);
            this.textBoxMinPWM.TabIndex = 5;
            // 
            // buttonMinPWM
            // 
            this.buttonMinPWM.Location = new System.Drawing.Point(19, 118);
            this.buttonMinPWM.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMinPWM.Name = "buttonMinPWM";
            this.buttonMinPWM.Size = new System.Drawing.Size(56, 18);
            this.buttonMinPWM.TabIndex = 4;
            this.buttonMinPWM.Text = "minPWM";
            this.buttonMinPWM.UseVisualStyleBackColor = true;
            this.buttonMinPWM.Click += new System.EventHandler(this.buttonMinPWM_Click);
            // 
            // buttonTorque
            // 
            this.buttonTorque.Location = new System.Drawing.Point(19, 16);
            this.buttonTorque.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTorque.Name = "buttonTorque";
            this.buttonTorque.Size = new System.Drawing.Size(56, 24);
            this.buttonTorque.TabIndex = 0;
            this.buttonTorque.Text = "measure";
            this.buttonTorque.UseVisualStyleBackColor = true;
            this.buttonTorque.Click += new System.EventHandler(this.buttonTorque_Click);
            // 
            // tabPageBacklash
            // 
            this.tabPageBacklash.BackColor = System.Drawing.Color.Transparent;
            this.tabPageBacklash.Controls.Add(this.label10);
            this.tabPageBacklash.Controls.Add(this.textBoxAngle);
            this.tabPageBacklash.Controls.Add(this.pictureBoxAngle);
            this.tabPageBacklash.Controls.Add(this.progressBarBacklash);
            this.tabPageBacklash.Controls.Add(this.label9);
            this.tabPageBacklash.Controls.Add(this.textBoxBacklash);
            this.tabPageBacklash.Controls.Add(this.buttonBacklash);
            this.tabPageBacklash.Controls.Add(this.buttonBacklashFree);
            this.tabPageBacklash.Location = new System.Drawing.Point(4, 22);
            this.tabPageBacklash.Name = "tabPageBacklash";
            this.tabPageBacklash.Size = new System.Drawing.Size(616, 358);
            this.tabPageBacklash.TabIndex = 3;
            this.tabPageBacklash.Text = "Backlash";
            // 
            // numericUpDownID
            // 
            this.numericUpDownID.Location = new System.Drawing.Point(224, 0);
            this.numericUpDownID.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownID.Name = "numericUpDownID";
            this.numericUpDownID.Size = new System.Drawing.Size(48, 19);
            this.numericUpDownID.TabIndex = 5;
            this.numericUpDownID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.numericUpDownID, "Select Servo ID");
            // 
            // buttonServoOff
            // 
            this.buttonServoOff.Location = new System.Drawing.Point(360, 0);
            this.buttonServoOff.Margin = new System.Windows.Forms.Padding(2);
            this.buttonServoOff.Name = "buttonServoOff";
            this.buttonServoOff.Size = new System.Drawing.Size(72, 20);
            this.buttonServoOff.TabIndex = 6;
            this.buttonServoOff.Text = "Servo Off";
            this.toolTip1.SetToolTip(this.buttonServoOff, "Servo Off");
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
            this.comboBoxBitrate.Location = new System.Drawing.Point(128, 0);
            this.comboBoxBitrate.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBitrate.Name = "comboBoxBitrate";
            this.comboBoxBitrate.Size = new System.Drawing.Size(72, 20);
            this.comboBoxBitrate.TabIndex = 7;
            this.comboBoxBitrate.Text = "1000000";
            this.toolTip1.SetToolTip(this.comboBoxBitrate, "Select Bitrate");
            this.comboBoxBitrate.SelectedIndexChanged += new System.EventHandler(this.comboBoxBitrate_SelectedIndexChanged);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(40, 0);
            this.comboBoxPort.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(80, 20);
            this.comboBoxPort.TabIndex = 8;
            this.toolTip1.SetToolTip(this.comboBoxPort, "Select COM Port");
            this.comboBoxPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxPort_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kp";
            // 
            // numericUpDownKp
            // 
            this.numericUpDownKp.DecimalPlaces = 4;
            this.numericUpDownKp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownKp.Location = new System.Drawing.Point(32, 24);
            this.numericUpDownKp.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKp.Name = "numericUpDownKp";
            this.numericUpDownKp.Size = new System.Drawing.Size(56, 19);
            this.numericUpDownKp.TabIndex = 11;
            this.numericUpDownKp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kd";
            // 
            // numericUpDownKd
            // 
            this.numericUpDownKd.DecimalPlaces = 4;
            this.numericUpDownKd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownKd.Location = new System.Drawing.Point(112, 24);
            this.numericUpDownKd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKd.Name = "numericUpDownKd";
            this.numericUpDownKd.Size = new System.Drawing.Size(56, 19);
            this.numericUpDownKd.TabIndex = 13;
            this.numericUpDownKd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ki";
            // 
            // numericUpDownKi
            // 
            this.numericUpDownKi.DecimalPlaces = 4;
            this.numericUpDownKi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownKi.Location = new System.Drawing.Point(192, 24);
            this.numericUpDownKi.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKi.Name = "numericUpDownKi";
            this.numericUpDownKi.Size = new System.Drawing.Size(56, 19);
            this.numericUpDownKi.TabIndex = 15;
            this.numericUpDownKi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "Static";
            // 
            // numericUpDownStatic
            // 
            this.numericUpDownStatic.DecimalPlaces = 4;
            this.numericUpDownStatic.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownStatic.Location = new System.Drawing.Point(296, 24);
            this.numericUpDownStatic.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStatic.Name = "numericUpDownStatic";
            this.numericUpDownStatic.Size = new System.Drawing.Size(56, 19);
            this.numericUpDownStatic.TabIndex = 15;
            this.numericUpDownStatic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "Dynamic";
            // 
            // numericUpDownDynamic
            // 
            this.numericUpDownDynamic.DecimalPlaces = 4;
            this.numericUpDownDynamic.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownDynamic.Location = new System.Drawing.Point(408, 24);
            this.numericUpDownDynamic.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDynamic.Name = "numericUpDownDynamic";
            this.numericUpDownDynamic.Size = new System.Drawing.Size(56, 19);
            this.numericUpDownDynamic.TabIndex = 18;
            this.numericUpDownDynamic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "PWM";
            // 
            // numericUpDownPWMFrequency
            // 
            this.numericUpDownPWMFrequency.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.numericUpDownPWMFrequency.Location = new System.Drawing.Point(508, 24);
            this.numericUpDownPWMFrequency.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDownPWMFrequency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPWMFrequency.Name = "numericUpDownPWMFrequency";
            this.numericUpDownPWMFrequency.Size = new System.Drawing.Size(56, 19);
            this.numericUpDownPWMFrequency.TabIndex = 20;
            this.numericUpDownPWMFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownPWMFrequency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonBacklashFree
            // 
            this.buttonBacklashFree.Location = new System.Drawing.Point(88, 8);
            this.buttonBacklashFree.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBacklashFree.Name = "buttonBacklashFree";
            this.buttonBacklashFree.Size = new System.Drawing.Size(72, 20);
            this.buttonBacklashFree.TabIndex = 3;
            this.buttonBacklashFree.Text = "Free";
            this.buttonBacklashFree.UseVisualStyleBackColor = true;
            this.buttonBacklashFree.Click += new System.EventHandler(this.buttonBacklashEnd_Click);
            // 
            // buttonBacklash
            // 
            this.buttonBacklash.Location = new System.Drawing.Point(8, 8);
            this.buttonBacklash.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBacklash.Name = "buttonBacklash";
            this.buttonBacklash.Size = new System.Drawing.Size(72, 20);
            this.buttonBacklash.TabIndex = 4;
            this.buttonBacklash.Text = "Backlash";
            this.buttonBacklash.UseVisualStyleBackColor = true;
            this.buttonBacklash.Click += new System.EventHandler(this.buttonBacklashStart_Click);
            // 
            // textBoxBacklash
            // 
            this.textBoxBacklash.Location = new System.Drawing.Point(8, 32);
            this.textBoxBacklash.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBacklash.Name = "textBoxBacklash";
            this.textBoxBacklash.Size = new System.Drawing.Size(104, 19);
            this.textBoxBacklash.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(120, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "deg";
            // 
            // tabPageSetParameter
            // 
            this.tabPageSetParameter.BackColor = System.Drawing.Color.Transparent;
            this.tabPageSetParameter.Location = new System.Drawing.Point(4, 22);
            this.tabPageSetParameter.Name = "tabPageSetParameter";
            this.tabPageSetParameter.Size = new System.Drawing.Size(616, 358);
            this.tabPageSetParameter.TabIndex = 4;
            this.tabPageSetParameter.Text = "SetParameter";
            // 
            // progressBarBacklash
            // 
            this.progressBarBacklash.Location = new System.Drawing.Point(8, 64);
            this.progressBarBacklash.Name = "progressBarBacklash";
            this.progressBarBacklash.Size = new System.Drawing.Size(152, 16);
            this.progressBarBacklash.TabIndex = 7;
            // 
            // pictureBoxAngle
            // 
            this.pictureBoxAngle.BackColor = System.Drawing.Color.White;
            this.pictureBoxAngle.Location = new System.Drawing.Point(8, 96);
            this.pictureBoxAngle.Name = "pictureBoxAngle";
            this.pictureBoxAngle.Size = new System.Drawing.Size(152, 152);
            this.pictureBoxAngle.TabIndex = 8;
            this.pictureBoxAngle.TabStop = false;
            this.pictureBoxAngle.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxAngle_Paint);
            // 
            // timerPictureBoxAngle
            // 
            this.timerPictureBoxAngle.Tick += new System.EventHandler(this.timerPictureBoxAngle_Tick);
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.Location = new System.Drawing.Point(8, 256);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(104, 19);
            this.textBoxAngle.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "deg";
            // 
            // FormB3ServoChecker
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.numericUpDownPWMFrequency);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDownDynamic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownStatic);
            this.Controls.Add(this.numericUpDownKi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownKd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownKp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.comboBoxBitrate);
            this.Controls.Add(this.buttonServoOff);
            this.Controls.Add(this.buttonServoOn);
            this.Controls.Add(this.numericUpDownID);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormB3ServoChecker";
            this.Text = "B3M Servo Checker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabBasic.ResumeLayout(false);
            this.tabBasic.PerformLayout();
            this.tabPageStepResp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPageTorque.ResumeLayout(false);
            this.tabPageTorque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabPageBacklash.ResumeLayout(false);
            this.tabPageBacklash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStatic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDynamic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPWMFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonServoOn;
        private System.Windows.Forms.TrackBar trackBarPos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBasic;
        private System.Windows.Forms.TabPage tabPageStepResp;
        private System.Windows.Forms.Button buttonStepResponse;
        private System.Windows.Forms.NumericUpDown numericUpDownID;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPageTorque;
        private System.Windows.Forms.Button buttonTorque;
        private System.Windows.Forms.Button buttonMinPWM;
        private System.Windows.Forms.TextBox textBoxMinPWM;
        private System.Windows.Forms.Button buttonServoOff;
        private System.Windows.Forms.ComboBox comboBoxBitrate;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Button buttonVibration;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown numericUpDownKp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownKd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownKi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownStatic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownDynamic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownPWMFrequency;
        private System.Windows.Forms.TabPage tabPageBacklash;
        private System.Windows.Forms.Button buttonBacklashFree;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxBacklash;
        private System.Windows.Forms.Button buttonBacklash;
        private System.Windows.Forms.TabPage tabPageSetParameter;
        private System.Windows.Forms.ProgressBar progressBarBacklash;
        private System.Windows.Forms.PictureBox pictureBoxAngle;
        private System.Windows.Forms.Timer timerPictureBoxAngle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxAngle;
    }
}

