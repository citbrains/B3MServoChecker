
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
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDownSpeedFilter = new System.Windows.Forms.NumericUpDown();
            this.progressBarSpeed = new System.Windows.Forms.ProgressBar();
            this.pictureBoxSpeed = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDownPWMDuty = new System.Windows.Forms.NumericUpDown();
            this.buttonPWMDuty = new System.Windows.Forms.Button();
            this.tabPageBacklash = new System.Windows.Forms.TabPage();
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
            this.timerPictureBoxAngle = new System.Windows.Forms.Timer(this.components);
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
            this.buttonServoOn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.trackBarPos.LargeChange = 10;
            this.trackBarPos.Location = new System.Drawing.Point(4, 32);
            this.trackBarPos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarPos.Maximum = 320;
            this.trackBarPos.Minimum = -320;
            this.trackBarPos.Name = "trackBarPos";
            this.trackBarPos.Size = new System.Drawing.Size(604, 45);
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
            this.tabControl1.Location = new System.Drawing.Point(0, 56);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(624, 384);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabBasic
            // 
            this.tabBasic.BackColor = System.Drawing.Color.Transparent;
            this.tabBasic.Controls.Add(this.textBoxTargetAngle);
            this.tabBasic.Controls.Add(this.label11);
            this.tabBasic.Controls.Add(this.trackBarPos);
            this.tabBasic.Location = new System.Drawing.Point(4, 22);
            this.tabBasic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabBasic.Name = "tabBasic";
            this.tabBasic.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabBasic.Size = new System.Drawing.Size(616, 358);
            this.tabBasic.TabIndex = 0;
            this.tabBasic.Text = "Basic";
            // 
            // textBoxTargetAngle
            // 
            this.textBoxTargetAngle.Location = new System.Drawing.Point(88, 8);
            this.textBoxTargetAngle.Name = "textBoxTargetAngle";
            this.textBoxTargetAngle.ReadOnly = true;
            this.textBoxTargetAngle.Size = new System.Drawing.Size(100, 19);
            this.textBoxTargetAngle.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "Target Angle";
            // 
            // tabPageStepResp
            // 
            this.tabPageStepResp.BackColor = System.Drawing.Color.Transparent;
            this.tabPageStepResp.Controls.Add(this.label13);
            this.tabPageStepResp.Controls.Add(this.pictureBox1);
            this.tabPageStepResp.Controls.Add(this.buttonStepResponse);
            this.tabPageStepResp.Location = new System.Drawing.Point(4, 22);
            this.tabPageStepResp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageStepResp.Name = "tabPageStepResp";
            this.tabPageStepResp.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageStepResp.Size = new System.Drawing.Size(616, 358);
            this.tabPageStepResp.TabIndex = 1;
            this.tabPageStepResp.Text = "Step Resp.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(136, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "Save \"step_response.csv\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 336);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonStepResponse
            // 
            this.buttonStepResponse.Location = new System.Drawing.Point(8, 0);
            this.buttonStepResponse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.tabPageTorque.Controls.Add(this.label12);
            this.tabPageTorque.Controls.Add(this.pictureBox2);
            this.tabPageTorque.Controls.Add(this.textBoxMinPWM);
            this.tabPageTorque.Controls.Add(this.buttonMinPWM);
            this.tabPageTorque.Controls.Add(this.buttonCurrent);
            this.tabPageTorque.Location = new System.Drawing.Point(4, 22);
            this.tabPageTorque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageTorque.Name = "tabPageTorque";
            this.tabPageTorque.Size = new System.Drawing.Size(616, 358);
            this.tabPageTorque.TabIndex = 2;
            this.tabPageTorque.Text = "Torque";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(128, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "Save \"pwm_current.csv\"";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(8, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 320);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxMinPWM
            // 
            this.textBoxMinPWM.Location = new System.Drawing.Point(456, 32);
            this.textBoxMinPWM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMinPWM.Name = "textBoxMinPWM";
            this.textBoxMinPWM.Size = new System.Drawing.Size(131, 19);
            this.textBoxMinPWM.TabIndex = 5;
            // 
            // buttonMinPWM
            // 
            this.buttonMinPWM.Location = new System.Drawing.Point(456, 8);
            this.buttonMinPWM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMinPWM.Name = "buttonMinPWM";
            this.buttonMinPWM.Size = new System.Drawing.Size(128, 20);
            this.buttonMinPWM.TabIndex = 4;
            this.buttonMinPWM.Text = "Min. PWM";
            this.buttonMinPWM.UseVisualStyleBackColor = true;
            this.buttonMinPWM.Click += new System.EventHandler(this.buttonMinPWM_Click);
            // 
            // buttonCurrent
            // 
            this.buttonCurrent.Location = new System.Drawing.Point(8, 8);
            this.buttonCurrent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCurrent.Name = "buttonCurrent";
            this.buttonCurrent.Size = new System.Drawing.Size(109, 20);
            this.buttonCurrent.TabIndex = 0;
            this.buttonCurrent.Text = "PWM - Current";
            this.buttonCurrent.UseVisualStyleBackColor = true;
            this.buttonCurrent.Click += new System.EventHandler(this.buttonCurrent_Click);
            // 
            // tabPageSpeed
            // 
            this.tabPageSpeed.BackColor = System.Drawing.Color.Transparent;
            this.tabPageSpeed.Controls.Add(this.label16);
            this.tabPageSpeed.Controls.Add(this.numericUpDownSpeedFilter);
            this.tabPageSpeed.Controls.Add(this.progressBarSpeed);
            this.tabPageSpeed.Controls.Add(this.pictureBoxSpeed);
            this.tabPageSpeed.Controls.Add(this.label15);
            this.tabPageSpeed.Controls.Add(this.label14);
            this.tabPageSpeed.Controls.Add(this.numericUpDownPWMDuty);
            this.tabPageSpeed.Controls.Add(this.buttonPWMDuty);
            this.tabPageSpeed.Location = new System.Drawing.Point(4, 22);
            this.tabPageSpeed.Name = "tabPageSpeed";
            this.tabPageSpeed.Size = new System.Drawing.Size(616, 358);
            this.tabPageSpeed.TabIndex = 6;
            this.tabPageSpeed.Text = "Speed";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(152, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 12);
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
            this.numericUpDownSpeedFilter.Location = new System.Drawing.Point(176, 8);
            this.numericUpDownSpeedFilter.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSpeedFilter.Name = "numericUpDownSpeedFilter";
            this.numericUpDownSpeedFilter.Size = new System.Drawing.Size(72, 19);
            this.numericUpDownSpeedFilter.TabIndex = 6;
            this.numericUpDownSpeedFilter.Value = new decimal(new int[] {
            95,
            0,
            0,
            131072});
            // 
            // progressBarSpeed
            // 
            this.progressBarSpeed.Location = new System.Drawing.Point(464, 8);
            this.progressBarSpeed.Name = "progressBarSpeed";
            this.progressBarSpeed.Size = new System.Drawing.Size(144, 20);
            this.progressBarSpeed.TabIndex = 5;
            // 
            // pictureBoxSpeed
            // 
            this.pictureBoxSpeed.BackColor = System.Drawing.Color.White;
            this.pictureBoxSpeed.Location = new System.Drawing.Point(0, 32);
            this.pictureBoxSpeed.Name = "pictureBoxSpeed";
            this.pictureBoxSpeed.Size = new System.Drawing.Size(616, 328);
            this.pictureBoxSpeed.TabIndex = 4;
            this.pictureBoxSpeed.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(368, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 12);
            this.label15.TabIndex = 3;
            this.label15.Text = "Save \"speed.csv\"";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "PWM Duty";
            // 
            // numericUpDownPWMDuty
            // 
            this.numericUpDownPWMDuty.Location = new System.Drawing.Point(72, 8);
            this.numericUpDownPWMDuty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPWMDuty.Name = "numericUpDownPWMDuty";
            this.numericUpDownPWMDuty.Size = new System.Drawing.Size(72, 19);
            this.numericUpDownPWMDuty.TabIndex = 1;
            // 
            // buttonPWMDuty
            // 
            this.buttonPWMDuty.Location = new System.Drawing.Point(256, 8);
            this.buttonPWMDuty.Name = "buttonPWMDuty";
            this.buttonPWMDuty.Size = new System.Drawing.Size(104, 20);
            this.buttonPWMDuty.TabIndex = 0;
            this.buttonPWMDuty.Text = "Set PWM Duty";
            this.buttonPWMDuty.UseVisualStyleBackColor = true;
            this.buttonPWMDuty.Click += new System.EventHandler(this.buttonPWMDuty_Click);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "deg";
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.Location = new System.Drawing.Point(8, 256);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(104, 19);
            this.textBoxAngle.TabIndex = 9;
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
            // progressBarBacklash
            // 
            this.progressBarBacklash.Location = new System.Drawing.Point(8, 64);
            this.progressBarBacklash.Name = "progressBarBacklash";
            this.progressBarBacklash.Size = new System.Drawing.Size(152, 16);
            this.progressBarBacklash.TabIndex = 7;
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
            // textBoxBacklash
            // 
            this.textBoxBacklash.Location = new System.Drawing.Point(8, 32);
            this.textBoxBacklash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBacklash.Name = "textBoxBacklash";
            this.textBoxBacklash.Size = new System.Drawing.Size(104, 19);
            this.textBoxBacklash.TabIndex = 5;
            // 
            // buttonBacklash
            // 
            this.buttonBacklash.Location = new System.Drawing.Point(8, 8);
            this.buttonBacklash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBacklash.Name = "buttonBacklash";
            this.buttonBacklash.Size = new System.Drawing.Size(72, 20);
            this.buttonBacklash.TabIndex = 4;
            this.buttonBacklash.Text = "Backlash";
            this.buttonBacklash.UseVisualStyleBackColor = true;
            this.buttonBacklash.Click += new System.EventHandler(this.buttonBacklashStart_Click);
            // 
            // buttonBacklashFree
            // 
            this.buttonBacklashFree.Location = new System.Drawing.Point(88, 8);
            this.buttonBacklashFree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBacklashFree.Name = "buttonBacklashFree";
            this.buttonBacklashFree.Size = new System.Drawing.Size(72, 20);
            this.buttonBacklashFree.TabIndex = 3;
            this.buttonBacklashFree.Text = "Free";
            this.buttonBacklashFree.UseVisualStyleBackColor = true;
            this.buttonBacklashFree.Click += new System.EventHandler(this.buttonBacklashEnd_Click);
            // 
            // tabPageVibration
            // 
            this.tabPageVibration.BackColor = System.Drawing.Color.Transparent;
            this.tabPageVibration.Controls.Add(this.buttonVibration);
            this.tabPageVibration.Controls.Add(this.trackBar1);
            this.tabPageVibration.Location = new System.Drawing.Point(4, 22);
            this.tabPageVibration.Name = "tabPageVibration";
            this.tabPageVibration.Size = new System.Drawing.Size(616, 358);
            this.tabPageVibration.TabIndex = 5;
            this.tabPageVibration.Text = "Vibration";
            // 
            // buttonVibration
            // 
            this.buttonVibration.Location = new System.Drawing.Point(8, 8);
            this.buttonVibration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonVibration.Name = "buttonVibration";
            this.buttonVibration.Size = new System.Drawing.Size(70, 18);
            this.buttonVibration.TabIndex = 9;
            this.buttonVibration.Text = "vibration";
            this.buttonVibration.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(8, 32);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(558, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 1000;
            // 
            // tabPageSetParameter
            // 
            this.tabPageSetParameter.BackColor = System.Drawing.Color.Transparent;
            this.tabPageSetParameter.Controls.Add(this.textBoxServoType);
            this.tabPageSetParameter.Controls.Add(this.buttonSetParameters);
            this.tabPageSetParameter.Location = new System.Drawing.Point(4, 22);
            this.tabPageSetParameter.Name = "tabPageSetParameter";
            this.tabPageSetParameter.Size = new System.Drawing.Size(616, 358);
            this.tabPageSetParameter.TabIndex = 4;
            this.tabPageSetParameter.Text = "SetParameter";
            // 
            // textBoxServoType
            // 
            this.textBoxServoType.Location = new System.Drawing.Point(128, 8);
            this.textBoxServoType.Name = "textBoxServoType";
            this.textBoxServoType.Size = new System.Drawing.Size(120, 19);
            this.textBoxServoType.TabIndex = 1;
            // 
            // buttonSetParameters
            // 
            this.buttonSetParameters.Location = new System.Drawing.Point(8, 8);
            this.buttonSetParameters.Name = "buttonSetParameters";
            this.buttonSetParameters.Size = new System.Drawing.Size(112, 23);
            this.buttonSetParameters.TabIndex = 0;
            this.buttonSetParameters.Text = "Set Parameters";
            this.buttonSetParameters.UseVisualStyleBackColor = true;
            this.buttonSetParameters.Click += new System.EventHandler(this.buttonSetParameters_Click);
            // 
            // numericUpDownID
            // 
            this.numericUpDownID.Location = new System.Drawing.Point(224, 0);
            this.numericUpDownID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownID.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownID.Name = "numericUpDownID";
            this.numericUpDownID.Size = new System.Drawing.Size(48, 19);
            this.numericUpDownID.TabIndex = 5;
            this.toolTip1.SetToolTip(this.numericUpDownID, "Select Servo ID");
            // 
            // buttonServoOff
            // 
            this.buttonServoOff.Location = new System.Drawing.Point(360, 0);
            this.buttonServoOff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.comboBoxBitrate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.comboBoxPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.numericUpDownKp.ValueChanged += new System.EventHandler(this.numericUpDownParameter_ValueChanged);
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
            this.numericUpDownKd.ValueChanged += new System.EventHandler(this.numericUpDownParameter_ValueChanged);
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
            this.numericUpDownKi.ValueChanged += new System.EventHandler(this.numericUpDownParameter_ValueChanged);
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
            this.numericUpDownStatic.ValueChanged += new System.EventHandler(this.numericUpDownParameter_ValueChanged);
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
            this.numericUpDownDynamic.ValueChanged += new System.EventHandler(this.numericUpDownParameter_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "PWM Freq";
            // 
            // numericUpDownPWMFrequency
            // 
            this.numericUpDownPWMFrequency.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.numericUpDownPWMFrequency.Location = new System.Drawing.Point(536, 24);
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
            this.numericUpDownPWMFrequency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPWMFrequency.ValueChanged += new System.EventHandler(this.numericUpDownParameter_ValueChanged);
            // 
            // timerPictureBoxAngle
            // 
            this.timerPictureBoxAngle.Tick += new System.EventHandler(this.timerPictureBoxAngle_Tick);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}

