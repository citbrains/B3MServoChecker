
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonServoOn = new System.Windows.Forms.Button();
            this.trackBarPos = new System.Windows.Forms.TrackBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBasic = new System.Windows.Forms.TabPage();
            this.textBoxTargetAngle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPageStepResp = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonStepResponse = new System.Windows.Forms.Button();
            this.tabPageTorque = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxMinPWM = new System.Windows.Forms.TextBox();
            this.buttonMinPWM = new System.Windows.Forms.Button();
            this.buttonCurrent = new System.Windows.Forms.Button();
            this.tabPageSpeed = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxExp1Result = new System.Windows.Forms.TextBox();
            this.buttonExpStart = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDownSpeedFilter = new System.Windows.Forms.NumericUpDown();
            this.progressBarSpeed = new System.Windows.Forms.ProgressBar();
            this.pictureBoxSpeed = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDownPWMDuty = new System.Windows.Forms.NumericUpDown();
            this.buttonPWMDuty = new System.Windows.Forms.Button();
            this.tabPageBacklash = new System.Windows.Forms.TabPage();
            this.buttonControl270deg = new System.Windows.Forms.Button();
            this.buttonControl90deg = new System.Windows.Forms.Button();
            this.buttonControl315deg = new System.Windows.Forms.Button();
            this.buttonControl45deg = new System.Windows.Forms.Button();
            this.buttonControl0deg = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.pictureBoxAngle = new System.Windows.Forms.PictureBox();
            this.progressBarBacklash = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxBacklash = new System.Windows.Forms.TextBox();
            this.buttonBacklash = new System.Windows.Forms.Button();
            this.buttonBacklashFree = new System.Windows.Forms.Button();
            this.tabPageVibration = new System.Windows.Forms.TabPage();
            this.buttonVibration = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tabPageSetParameter = new System.Windows.Forms.TabPage();
            this.textBoxSetParameterResult = new System.Windows.Forms.TextBox();
            this.textBoxServoType = new System.Windows.Forms.TextBox();
            this.buttonSetParameters = new System.Windows.Forms.Button();
            this.numericUpDownID = new System.Windows.Forms.NumericUpDown();
            this.buttonServoOff = new System.Windows.Forms.Button();
            this.comboBoxBitrate = new System.Windows.Forms.ComboBox();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.numericUpDownKp = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKd = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKi = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStatic = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDynamic = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPWMFrequency = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timerPictureBoxAngle = new System.Windows.Forms.Timer(this.components);
            this.buttonGetAllParameters = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabBasic.SuspendLayout();
            this.tabPageStepResp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageTorque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPageSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPWMDuty)).BeginInit();
            this.tabPageBacklash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAngle)).BeginInit();
            this.tabPageVibration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabPageSetParameter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStatic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDynamic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPWMFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 1000000;
            this.serialPort1.ReadTimeout = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM";
            // 
            // buttonServoOn
            // 
            this.buttonServoOn.Location = new System.Drawing.Point(373, 0);
            this.buttonServoOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonServoOn.Name = "buttonServoOn";
            this.buttonServoOn.Size = new System.Drawing.Size(96, 25);
            this.buttonServoOn.TabIndex = 2;
            this.buttonServoOn.Text = "Servo On";
            this.toolTip1.SetToolTip(this.buttonServoOn, "Servo On in Position Control");
            this.buttonServoOn.UseVisualStyleBackColor = true;
            this.buttonServoOn.Click += new System.EventHandler(this.buttonServoOn_Click);
            // 
            // trackBarPos
            // 
            this.trackBarPos.LargeChange = 10;
            this.trackBarPos.Location = new System.Drawing.Point(5, 40);
            this.trackBarPos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarPos.Maximum = 320;
            this.trackBarPos.Minimum = -320;
            this.trackBarPos.Name = "trackBarPos";
            this.trackBarPos.Size = new System.Drawing.Size(805, 56);
            this.trackBarPos.TabIndex = 3;
            this.trackBarPos.TickFrequency = 10;
            this.trackBarPos.Scroll += new System.EventHandler(this.trackBarPos_Scroll);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBasic);
            this.tabControl1.Controls.Add(this.tabPageStepResp);
            this.tabControl1.Controls.Add(this.tabPageTorque);
            this.tabControl1.Controls.Add(this.tabPageSpeed);
            this.tabControl1.Controls.Add(this.tabPageBacklash);
            this.tabControl1.Controls.Add(this.tabPageVibration);
            this.tabControl1.Controls.Add(this.tabPageSetParameter);
            this.tabControl1.Location = new System.Drawing.Point(0, 70);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(832, 480);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabBasic
            // 
            this.tabBasic.BackColor = System.Drawing.Color.Transparent;
            this.tabBasic.Controls.Add(this.textBoxTargetAngle);
            this.tabBasic.Controls.Add(this.label11);
            this.tabBasic.Controls.Add(this.trackBarPos);
            this.tabBasic.Location = new System.Drawing.Point(4, 25);
            this.tabBasic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBasic.Name = "tabBasic";
            this.tabBasic.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBasic.Size = new System.Drawing.Size(824, 451);
            this.tabBasic.TabIndex = 0;
            this.tabBasic.Text = "Basic";
            // 
            // textBoxTargetAngle
            // 
            this.textBoxTargetAngle.Location = new System.Drawing.Point(117, 10);
            this.textBoxTargetAngle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTargetAngle.Name = "textBoxTargetAngle";
            this.textBoxTargetAngle.ReadOnly = true;
            this.textBoxTargetAngle.Size = new System.Drawing.Size(132, 22);
            this.textBoxTargetAngle.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxTargetAngle, "Angle (deg)");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 15);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Target Angle";
            // 
            // tabPageStepResp
            // 
            this.tabPageStepResp.BackColor = System.Drawing.Color.Transparent;
            this.tabPageStepResp.Controls.Add(this.label13);
            this.tabPageStepResp.Controls.Add(this.pictureBox1);
            this.tabPageStepResp.Controls.Add(this.buttonStepResponse);
            this.tabPageStepResp.Location = new System.Drawing.Point(4, 25);
            this.tabPageStepResp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageStepResp.Name = "tabPageStepResp";
            this.tabPageStepResp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageStepResp.Size = new System.Drawing.Size(824, 451);
            this.tabPageStepResp.TabIndex = 1;
            this.tabPageStepResp.Text = "Step Resp.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(181, 5);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Save \"step_response.csv\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(821, 420);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonStepResponse
            // 
            this.buttonStepResponse.Location = new System.Drawing.Point(11, 0);
            this.buttonStepResponse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStepResponse.Name = "buttonStepResponse";
            this.buttonStepResponse.Size = new System.Drawing.Size(160, 25);
            this.buttonStepResponse.TabIndex = 0;
            this.buttonStepResponse.Text = "Step Response";
            this.toolTip1.SetToolTip(this.buttonStepResponse, "After changing feedback parameters, measuring step response");
            this.buttonStepResponse.UseVisualStyleBackColor = true;
            this.buttonStepResponse.Click += new System.EventHandler(this.buttonStepResponse_Click);
            // 
            // tabPageTorque
            // 
            this.tabPageTorque.BackColor = System.Drawing.Color.Transparent;
            this.tabPageTorque.Controls.Add(this.label12);
            this.tabPageTorque.Controls.Add(this.pictureBox2);
            this.tabPageTorque.Controls.Add(this.textBoxMinPWM);
            this.tabPageTorque.Controls.Add(this.buttonMinPWM);
            this.tabPageTorque.Controls.Add(this.buttonCurrent);
            this.tabPageTorque.Location = new System.Drawing.Point(4, 25);
            this.tabPageTorque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTorque.Name = "tabPageTorque";
            this.tabPageTorque.Size = new System.Drawing.Size(824, 451);
            this.tabPageTorque.TabIndex = 2;
            this.tabPageTorque.Text = "Torque";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(171, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "Save \"pwm_current.csv\"";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(11, 40);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(533, 400);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxMinPWM
            // 
            this.textBoxMinPWM.Location = new System.Drawing.Point(608, 40);
            this.textBoxMinPWM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMinPWM.Name = "textBoxMinPWM";
            this.textBoxMinPWM.Size = new System.Drawing.Size(173, 22);
            this.textBoxMinPWM.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxMinPWM, "PWM raw data");
            // 
            // buttonMinPWM
            // 
            this.buttonMinPWM.Location = new System.Drawing.Point(608, 10);
            this.buttonMinPWM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMinPWM.Name = "buttonMinPWM";
            this.buttonMinPWM.Size = new System.Drawing.Size(171, 25);
            this.buttonMinPWM.TabIndex = 4;
            this.buttonMinPWM.Text = "Min. PWM";
            this.toolTip1.SetToolTip(this.buttonMinPWM, "Measuring minimum PWM for checking static friction");
            this.buttonMinPWM.UseVisualStyleBackColor = true;
            this.buttonMinPWM.Click += new System.EventHandler(this.buttonMinPWM_Click);
            // 
            // buttonCurrent
            // 
            this.buttonCurrent.Location = new System.Drawing.Point(11, 10);
            this.buttonCurrent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCurrent.Name = "buttonCurrent";
            this.buttonCurrent.Size = new System.Drawing.Size(145, 25);
            this.buttonCurrent.TabIndex = 0;
            this.buttonCurrent.Text = "PWM - Current";
            this.toolTip1.SetToolTip(this.buttonCurrent, "Measuring between PWM and current");
            this.buttonCurrent.UseVisualStyleBackColor = true;
            this.buttonCurrent.Click += new System.EventHandler(this.buttonCurrent_Click);
            // 
            // tabPageSpeed
            // 
            this.tabPageSpeed.BackColor = System.Drawing.Color.Transparent;
            this.tabPageSpeed.Controls.Add(this.label18);
            this.tabPageSpeed.Controls.Add(this.textBoxExp1Result);
            this.tabPageSpeed.Controls.Add(this.buttonExpStart);
            this.tabPageSpeed.Controls.Add(this.label17);
            this.tabPageSpeed.Controls.Add(this.label16);
            this.tabPageSpeed.Controls.Add(this.numericUpDownSpeedFilter);
            this.tabPageSpeed.Controls.Add(this.progressBarSpeed);
            this.tabPageSpeed.Controls.Add(this.pictureBoxSpeed);
            this.tabPageSpeed.Controls.Add(this.label15);
            this.tabPageSpeed.Controls.Add(this.label14);
            this.tabPageSpeed.Controls.Add(this.numericUpDownPWMDuty);
            this.tabPageSpeed.Controls.Add(this.buttonPWMDuty);
            this.tabPageSpeed.Location = new System.Drawing.Point(4, 25);
            this.tabPageSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSpeed.Name = "tabPageSpeed";
            this.tabPageSpeed.Size = new System.Drawing.Size(824, 451);
            this.tabPageSpeed.TabIndex = 6;
            this.tabPageSpeed.Text = "Speed";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(320, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 15);
            this.label18.TabIndex = 11;
            this.label18.Text = "deg/sec";
            // 
            // textBoxExp1Result
            // 
            this.textBoxExp1Result.Location = new System.Drawing.Point(160, 40);
            this.textBoxExp1Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxExp1Result.Name = "textBoxExp1Result";
            this.textBoxExp1Result.Size = new System.Drawing.Size(152, 22);
            this.textBoxExp1Result.TabIndex = 10;
            // 
            // buttonExpStart
            // 
            this.buttonExpStart.Location = new System.Drawing.Point(72, 40);
            this.buttonExpStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExpStart.Name = "buttonExpStart";
            this.buttonExpStart.Size = new System.Drawing.Size(75, 22);
            this.buttonExpStart.TabIndex = 9;
            this.buttonExpStart.Text = "Start";
            this.buttonExpStart.UseVisualStyleBackColor = true;
            this.buttonExpStart.Click += new System.EventHandler(this.buttonExpStart_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 15);
            this.label17.TabIndex = 8;
            this.label17.Text = "Exp. 1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(203, 15);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 15);
            this.label16.TabIndex = 7;
            this.label16.Text = "TC";
            // 
            // numericUpDownSpeedFilter
            // 
            this.numericUpDownSpeedFilter.DecimalPlaces = 3;
            this.numericUpDownSpeedFilter.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownSpeedFilter.Location = new System.Drawing.Point(235, 10);
            this.numericUpDownSpeedFilter.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownSpeedFilter.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSpeedFilter.Name = "numericUpDownSpeedFilter";
            this.numericUpDownSpeedFilter.Size = new System.Drawing.Size(96, 22);
            this.numericUpDownSpeedFilter.TabIndex = 6;
            this.toolTip1.SetToolTip(this.numericUpDownSpeedFilter, "Time constant (larger values result in a smoother signal)");
            this.numericUpDownSpeedFilter.Value = new decimal(new int[] {
            95,
            0,
            0,
            131072});
            // 
            // progressBarSpeed
            // 
            this.progressBarSpeed.Location = new System.Drawing.Point(619, 10);
            this.progressBarSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarSpeed.Name = "progressBarSpeed";
            this.progressBarSpeed.Size = new System.Drawing.Size(192, 25);
            this.progressBarSpeed.TabIndex = 5;
            // 
            // pictureBoxSpeed
            // 
            this.pictureBoxSpeed.BackColor = System.Drawing.Color.White;
            this.pictureBoxSpeed.Location = new System.Drawing.Point(0, 72);
            this.pictureBoxSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxSpeed.Name = "pictureBoxSpeed";
            this.pictureBoxSpeed.Size = new System.Drawing.Size(821, 378);
            this.pictureBoxSpeed.TabIndex = 4;
            this.pictureBoxSpeed.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(491, 15);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 15);
            this.label15.TabIndex = 3;
            this.label15.Text = "Save \"speed.csv\"";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 15);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "PWM Duty";
            // 
            // numericUpDownPWMDuty
            // 
            this.numericUpDownPWMDuty.Location = new System.Drawing.Point(96, 10);
            this.numericUpDownPWMDuty.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownPWMDuty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPWMDuty.Name = "numericUpDownPWMDuty";
            this.numericUpDownPWMDuty.Size = new System.Drawing.Size(96, 22);
            this.numericUpDownPWMDuty.TabIndex = 1;
            this.toolTip1.SetToolTip(this.numericUpDownPWMDuty, "PWM raw data");
            // 
            // buttonPWMDuty
            // 
            this.buttonPWMDuty.Location = new System.Drawing.Point(341, 10);
            this.buttonPWMDuty.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPWMDuty.Name = "buttonPWMDuty";
            this.buttonPWMDuty.Size = new System.Drawing.Size(139, 25);
            this.buttonPWMDuty.TabIndex = 0;
            this.buttonPWMDuty.Text = "Set PWM Duty";
            this.toolTip1.SetToolTip(this.buttonPWMDuty, "Measuring angular velocity under a certain PWM duty");
            this.buttonPWMDuty.UseVisualStyleBackColor = true;
            this.buttonPWMDuty.Click += new System.EventHandler(this.buttonPWMDuty_Click);
            // 
            // tabPageBacklash
            // 
            this.tabPageBacklash.BackColor = System.Drawing.Color.Transparent;
            this.tabPageBacklash.Controls.Add(this.buttonControl270deg);
            this.tabPageBacklash.Controls.Add(this.buttonControl90deg);
            this.tabPageBacklash.Controls.Add(this.buttonControl315deg);
            this.tabPageBacklash.Controls.Add(this.buttonControl45deg);
            this.tabPageBacklash.Controls.Add(this.buttonControl0deg);
            this.tabPageBacklash.Controls.Add(this.label10);
            this.tabPageBacklash.Controls.Add(this.textBoxAngle);
            this.tabPageBacklash.Controls.Add(this.pictureBoxAngle);
            this.tabPageBacklash.Controls.Add(this.progressBarBacklash);
            this.tabPageBacklash.Controls.Add(this.label9);
            this.tabPageBacklash.Controls.Add(this.textBoxBacklash);
            this.tabPageBacklash.Controls.Add(this.buttonBacklash);
            this.tabPageBacklash.Controls.Add(this.buttonBacklashFree);
            this.tabPageBacklash.Location = new System.Drawing.Point(4, 25);
            this.tabPageBacklash.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageBacklash.Name = "tabPageBacklash";
            this.tabPageBacklash.Size = new System.Drawing.Size(824, 451);
            this.tabPageBacklash.TabIndex = 3;
            this.tabPageBacklash.Text = "Backlash";
            // 
            // buttonControl270deg
            // 
            this.buttonControl270deg.Location = new System.Drawing.Point(16, 232);
            this.buttonControl270deg.Name = "buttonControl270deg";
            this.buttonControl270deg.Size = new System.Drawing.Size(75, 25);
            this.buttonControl270deg.TabIndex = 15;
            this.buttonControl270deg.Text = "-90deg";
            this.buttonControl270deg.UseVisualStyleBackColor = true;
            this.buttonControl270deg.Click += new System.EventHandler(this.buttonControl270deg_Click);
            // 
            // buttonControl90deg
            // 
            this.buttonControl90deg.Location = new System.Drawing.Point(320, 232);
            this.buttonControl90deg.Name = "buttonControl90deg";
            this.buttonControl90deg.Size = new System.Drawing.Size(75, 25);
            this.buttonControl90deg.TabIndex = 14;
            this.buttonControl90deg.Text = "90deg";
            this.buttonControl90deg.UseVisualStyleBackColor = true;
            this.buttonControl90deg.Click += new System.EventHandler(this.buttonControl90deg_Click);
            // 
            // buttonControl315deg
            // 
            this.buttonControl315deg.Location = new System.Drawing.Point(40, 120);
            this.buttonControl315deg.Name = "buttonControl315deg";
            this.buttonControl315deg.Size = new System.Drawing.Size(75, 25);
            this.buttonControl315deg.TabIndex = 13;
            this.buttonControl315deg.Text = "-45deg";
            this.buttonControl315deg.UseVisualStyleBackColor = true;
            this.buttonControl315deg.Click += new System.EventHandler(this.buttonControl315deg_Click);
            // 
            // buttonControl45deg
            // 
            this.buttonControl45deg.Location = new System.Drawing.Point(296, 120);
            this.buttonControl45deg.Name = "buttonControl45deg";
            this.buttonControl45deg.Size = new System.Drawing.Size(75, 25);
            this.buttonControl45deg.TabIndex = 12;
            this.buttonControl45deg.Text = "45deg";
            this.buttonControl45deg.UseVisualStyleBackColor = true;
            this.buttonControl45deg.Click += new System.EventHandler(this.buttonControl45deg_Click);
            // 
            // buttonControl0deg
            // 
            this.buttonControl0deg.Location = new System.Drawing.Point(168, 120);
            this.buttonControl0deg.Name = "buttonControl0deg";
            this.buttonControl0deg.Size = new System.Drawing.Size(75, 25);
            this.buttonControl0deg.TabIndex = 11;
            this.buttonControl0deg.Text = "0deg";
            this.buttonControl0deg.UseVisualStyleBackColor = true;
            this.buttonControl0deg.Click += new System.EventHandler(this.buttonControl0deg_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(253, 357);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "deg";
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.Location = new System.Drawing.Point(104, 352);
            this.textBoxAngle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(137, 22);
            this.textBoxAngle.TabIndex = 9;
            this.toolTip1.SetToolTip(this.textBoxAngle, "Angle (deg)");
            // 
            // pictureBoxAngle
            // 
            this.pictureBoxAngle.BackColor = System.Drawing.Color.White;
            this.pictureBoxAngle.Location = new System.Drawing.Point(104, 152);
            this.pictureBoxAngle.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxAngle.Name = "pictureBoxAngle";
            this.pictureBoxAngle.Size = new System.Drawing.Size(203, 190);
            this.pictureBoxAngle.TabIndex = 8;
            this.pictureBoxAngle.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxAngle, "Angle");
            this.pictureBoxAngle.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxAngle_Paint);
            // 
            // progressBarBacklash
            // 
            this.progressBarBacklash.Location = new System.Drawing.Point(104, 80);
            this.progressBarBacklash.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarBacklash.Name = "progressBarBacklash";
            this.progressBarBacklash.Size = new System.Drawing.Size(203, 20);
            this.progressBarBacklash.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(253, 45);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "deg";
            // 
            // textBoxBacklash
            // 
            this.textBoxBacklash.Location = new System.Drawing.Point(104, 40);
            this.textBoxBacklash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBacklash.Name = "textBoxBacklash";
            this.textBoxBacklash.Size = new System.Drawing.Size(137, 22);
            this.textBoxBacklash.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxBacklash, "Backlash (deg)");
            // 
            // buttonBacklash
            // 
            this.buttonBacklash.Location = new System.Drawing.Point(104, 10);
            this.buttonBacklash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBacklash.Name = "buttonBacklash";
            this.buttonBacklash.Size = new System.Drawing.Size(96, 25);
            this.buttonBacklash.TabIndex = 4;
            this.buttonBacklash.Text = "Backlash";
            this.toolTip1.SetToolTip(this.buttonBacklash, "Measuring backlash (apply a small force to CW/CCW)");
            this.buttonBacklash.UseVisualStyleBackColor = true;
            this.buttonBacklash.Click += new System.EventHandler(this.buttonBacklashStart_Click);
            // 
            // buttonBacklashFree
            // 
            this.buttonBacklashFree.Location = new System.Drawing.Point(210, 10);
            this.buttonBacklashFree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBacklashFree.Name = "buttonBacklashFree";
            this.buttonBacklashFree.Size = new System.Drawing.Size(96, 25);
            this.buttonBacklashFree.TabIndex = 3;
            this.buttonBacklashFree.Text = "Free";
            this.toolTip1.SetToolTip(this.buttonBacklashFree, "Free the servo motor");
            this.buttonBacklashFree.UseVisualStyleBackColor = true;
            this.buttonBacklashFree.Click += new System.EventHandler(this.buttonBacklashEnd_Click);
            // 
            // tabPageVibration
            // 
            this.tabPageVibration.BackColor = System.Drawing.Color.Transparent;
            this.tabPageVibration.Controls.Add(this.buttonVibration);
            this.tabPageVibration.Controls.Add(this.trackBar1);
            this.tabPageVibration.Location = new System.Drawing.Point(4, 25);
            this.tabPageVibration.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageVibration.Name = "tabPageVibration";
            this.tabPageVibration.Size = new System.Drawing.Size(824, 451);
            this.tabPageVibration.TabIndex = 5;
            this.tabPageVibration.Text = "Vibration";
            // 
            // buttonVibration
            // 
            this.buttonVibration.Location = new System.Drawing.Point(11, 10);
            this.buttonVibration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonVibration.Name = "buttonVibration";
            this.buttonVibration.Size = new System.Drawing.Size(93, 22);
            this.buttonVibration.TabIndex = 9;
            this.buttonVibration.Text = "vibration";
            this.buttonVibration.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(11, 40);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(744, 56);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 1000;
            // 
            // tabPageSetParameter
            // 
            this.tabPageSetParameter.BackColor = System.Drawing.Color.Transparent;
            this.tabPageSetParameter.Controls.Add(this.buttonGetAllParameters);
            this.tabPageSetParameter.Controls.Add(this.textBoxSetParameterResult);
            this.tabPageSetParameter.Controls.Add(this.textBoxServoType);
            this.tabPageSetParameter.Controls.Add(this.buttonSetParameters);
            this.tabPageSetParameter.Location = new System.Drawing.Point(4, 25);
            this.tabPageSetParameter.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSetParameter.Name = "tabPageSetParameter";
            this.tabPageSetParameter.Size = new System.Drawing.Size(824, 451);
            this.tabPageSetParameter.TabIndex = 4;
            this.tabPageSetParameter.Text = "SetParameter";
            // 
            // textBoxSetParameterResult
            // 
            this.textBoxSetParameterResult.Location = new System.Drawing.Point(341, 10);
            this.textBoxSetParameterResult.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSetParameterResult.Name = "textBoxSetParameterResult";
            this.textBoxSetParameterResult.Size = new System.Drawing.Size(159, 22);
            this.textBoxSetParameterResult.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBoxSetParameterResult, "Display result (If successful, display the model number)");
            // 
            // textBoxServoType
            // 
            this.textBoxServoType.Location = new System.Drawing.Point(171, 10);
            this.textBoxServoType.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxServoType.Name = "textBoxServoType";
            this.textBoxServoType.Size = new System.Drawing.Size(159, 22);
            this.textBoxServoType.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxServoType, "Display result (If successful, display the model number)");
            // 
            // buttonSetParameters
            // 
            this.buttonSetParameters.Location = new System.Drawing.Point(11, 10);
            this.buttonSetParameters.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetParameters.Name = "buttonSetParameters";
            this.buttonSetParameters.Size = new System.Drawing.Size(149, 29);
            this.buttonSetParameters.TabIndex = 0;
            this.buttonSetParameters.Text = "Set Parameters";
            this.toolTip1.SetToolTip(this.buttonSetParameters, "Set Parameter for CIT Brains");
            this.buttonSetParameters.UseVisualStyleBackColor = true;
            this.buttonSetParameters.Click += new System.EventHandler(this.buttonSetParameters_Click);
            // 
            // numericUpDownID
            // 
            this.numericUpDownID.Location = new System.Drawing.Point(299, 0);
            this.numericUpDownID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownID.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownID.Name = "numericUpDownID";
            this.numericUpDownID.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownID.TabIndex = 5;
            this.toolTip1.SetToolTip(this.numericUpDownID, "Select Servo ID");
            // 
            // buttonServoOff
            // 
            this.buttonServoOff.Location = new System.Drawing.Point(480, 0);
            this.buttonServoOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonServoOff.Name = "buttonServoOff";
            this.buttonServoOff.Size = new System.Drawing.Size(96, 25);
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
            this.comboBoxBitrate.Location = new System.Drawing.Point(171, 0);
            this.comboBoxBitrate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBitrate.Name = "comboBoxBitrate";
            this.comboBoxBitrate.Size = new System.Drawing.Size(95, 23);
            this.comboBoxBitrate.TabIndex = 7;
            this.comboBoxBitrate.Text = "1000000";
            this.toolTip1.SetToolTip(this.comboBoxBitrate, "Select Bitrate");
            this.comboBoxBitrate.SelectedIndexChanged += new System.EventHandler(this.comboBoxBitrate_SelectedIndexChanged);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(53, 0);
            this.comboBoxPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(105, 23);
            this.comboBoxPort.TabIndex = 8;
            this.toolTip1.SetToolTip(this.comboBoxPort, "Select COM Port");
            this.comboBoxPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxPort_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
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
            this.numericUpDownKp.Location = new System.Drawing.Point(43, 30);
            this.numericUpDownKp.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownKp.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKp.Name = "numericUpDownKp";
            this.numericUpDownKp.Size = new System.Drawing.Size(75, 22);
            this.numericUpDownKp.TabIndex = 11;
            this.toolTip1.SetToolTip(this.numericUpDownKp, "Feedback gain for position control Kp (Torque = Max Torque * Kp * Angle(deg))");
            this.numericUpDownKp.ValueChanged += new System.EventHandler(this.numericUpDownParameter_ValueChanged);
            // 
            // numericUpDownKd
            // 
            this.numericUpDownKd.DecimalPlaces = 4;
            this.numericUpDownKd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownKd.Location = new System.Drawing.Point(149, 30);
            this.numericUpDownKd.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownKd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKd.Name = "numericUpDownKd";
            this.numericUpDownKd.Size = new System.Drawing.Size(75, 22);
            this.numericUpDownKd.TabIndex = 13;
            this.toolTip1.SetToolTip(this.numericUpDownKd, "Feedback gain for derivative control Kd (Torque = Max Torque * Kd * Angular veloc" +
        "ity(deg/s))");
            this.numericUpDownKd.ValueChanged += new System.EventHandler(this.numericUpDownParameter_ValueChanged);
            // 
            // numericUpDownKi
            // 
            this.numericUpDownKi.DecimalPlaces = 4;
            this.numericUpDownKi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownKi.Location = new System.Drawing.Point(256, 30);
            this.numericUpDownKi.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownKi.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKi.Name = "numericUpDownKi";
            this.numericUpDownKi.Size = new System.Drawing.Size(75, 22);
            this.numericUpDownKi.TabIndex = 15;
            this.toolTip1.SetToolTip(this.numericUpDownKi, "Feedback gain for integral control Kd (Torque = Max Torque * Ki * Integrated angl" +
        "e error)");
            this.numericUpDownKi.ValueChanged += new System.EventHandler(this.numericUpDownParameter_ValueChanged);
            // 
            // numericUpDownStatic
            // 
            this.numericUpDownStatic.DecimalPlaces = 4;
            this.numericUpDownStatic.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownStatic.Location = new System.Drawing.Point(395, 30);
            this.numericUpDownStatic.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownStatic.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStatic.Name = "numericUpDownStatic";
            this.numericUpDownStatic.Size = new System.Drawing.Size(75, 22);
            this.numericUpDownStatic.TabIndex = 15;
            this.toolTip1.SetToolTip(this.numericUpDownStatic, "Static friction (Torque = Max Torque * Static friction)");
            this.numericUpDownStatic.ValueChanged += new System.EventHandler(this.numericUpDownParameter_ValueChanged);
            // 
            // numericUpDownDynamic
            // 
            this.numericUpDownDynamic.DecimalPlaces = 4;
            this.numericUpDownDynamic.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownDynamic.Location = new System.Drawing.Point(544, 30);
            this.numericUpDownDynamic.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownDynamic.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDynamic.Name = "numericUpDownDynamic";
            this.numericUpDownDynamic.Size = new System.Drawing.Size(75, 22);
            this.numericUpDownDynamic.TabIndex = 18;
            this.toolTip1.SetToolTip(this.numericUpDownDynamic, "Dynamic friction (Torque = Max Torque * Dynamic friction)");
            this.numericUpDownDynamic.ValueChanged += new System.EventHandler(this.numericUpDownParameter_ValueChanged);
            // 
            // numericUpDownPWMFrequency
            // 
            this.numericUpDownPWMFrequency.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.numericUpDownPWMFrequency.Location = new System.Drawing.Point(715, 30);
            this.numericUpDownPWMFrequency.Margin = new System.Windows.Forms.Padding(4);
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
            this.numericUpDownPWMFrequency.Size = new System.Drawing.Size(75, 22);
            this.numericUpDownPWMFrequency.TabIndex = 20;
            this.toolTip1.SetToolTip(this.numericUpDownPWMFrequency, "PWM Frequency (Hz) ");
            this.numericUpDownPWMFrequency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPWMFrequency.ValueChanged += new System.EventHandler(this.numericUpDownParameter_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ki";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Static";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(480, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Dynamic";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(635, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "PWM Freq";
            // 
            // timerPictureBoxAngle
            // 
            this.timerPictureBoxAngle.Tick += new System.EventHandler(this.timerPictureBoxAngle_Tick);
            // 
            // buttonGetAllParameters
            // 
            this.buttonGetAllParameters.Location = new System.Drawing.Point(8, 80);
            this.buttonGetAllParameters.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGetAllParameters.Name = "buttonGetAllParameters";
            this.buttonGetAllParameters.Size = new System.Drawing.Size(184, 29);
            this.buttonGetAllParameters.TabIndex = 3;
            this.buttonGetAllParameters.Text = "Get all Parameters";
            this.buttonGetAllParameters.UseVisualStyleBackColor = true;
            this.buttonGetAllParameters.Click += new System.EventHandler(this.buttonGetAllParameters_Click);
            // 
            // FormB3ServoChecker
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 551);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormB3ServoChecker";
            this.Text = "B3M Servo Checker [CIT Brains ver. 220325]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabBasic.ResumeLayout(false);
            this.tabBasic.PerformLayout();
            this.tabPageStepResp.ResumeLayout(false);
            this.tabPageStepResp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageTorque.ResumeLayout(false);
            this.tabPageTorque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPageSpeed.ResumeLayout(false);
            this.tabPageSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPWMDuty)).EndInit();
            this.tabPageBacklash.ResumeLayout(false);
            this.tabPageBacklash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAngle)).EndInit();
            this.tabPageVibration.ResumeLayout(false);
            this.tabPageVibration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabPageSetParameter.ResumeLayout(false);
            this.tabPageSetParameter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStatic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDynamic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPWMFrequency)).EndInit();
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
        private System.Windows.Forms.TabPage tabPageTorque;
        private System.Windows.Forms.Button buttonCurrent;
        private System.Windows.Forms.Button buttonMinPWM;
        private System.Windows.Forms.TextBox textBoxMinPWM;
        private System.Windows.Forms.Button buttonServoOff;
        private System.Windows.Forms.ComboBox comboBoxBitrate;
        private System.Windows.Forms.ComboBox comboBoxPort;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxTargetAngle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPageVibration;
        private System.Windows.Forms.Button buttonVibration;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPageSpeed;
        private System.Windows.Forms.PictureBox pictureBoxSpeed;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDownPWMDuty;
        private System.Windows.Forms.Button buttonPWMDuty;
        private System.Windows.Forms.ProgressBar progressBarSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeedFilter;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonSetParameters;
        private System.Windows.Forms.TextBox textBoxServoType;
        private System.Windows.Forms.TextBox textBoxSetParameterResult;
        private System.Windows.Forms.Button buttonExpStart;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxExp1Result;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonControl270deg;
        private System.Windows.Forms.Button buttonControl90deg;
        private System.Windows.Forms.Button buttonControl315deg;
        private System.Windows.Forms.Button buttonControl45deg;
        private System.Windows.Forms.Button buttonControl0deg;
        private System.Windows.Forms.Button buttonGetAllParameters;
    }
}

