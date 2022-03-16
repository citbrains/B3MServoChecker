
namespace B3MServoChecker
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonServoOn = new System.Windows.Forms.Button();
            this.trackBarPos = new System.Windows.Forms.TrackBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPageStepResp = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStepResponse = new System.Windows.Forms.Button();
            this.numericUpDownID = new System.Windows.Forms.NumericUpDown();
            this.tabPageTorque = new System.Windows.Forms.TabPage();
            this.buttonTorque = new System.Windows.Forms.Button();
            this.buttonBacklashStart = new System.Windows.Forms.Button();
            this.buttonBacklashEnd = new System.Windows.Forms.Button();
            this.textBoxBacklash = new System.Windows.Forms.TextBox();
            this.buttonMinPWM = new System.Windows.Forms.Button();
            this.textBoxMinPWM = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageStepResp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).BeginInit();
            this.tabPageTorque.SuspendLayout();
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "1000000",
            "1500000",
            "3000000"});
            this.listBox1.Location = new System.Drawing.Point(57, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 19);
            this.listBox1.TabIndex = 1;
            // 
            // buttonServoOn
            // 
            this.buttonServoOn.Location = new System.Drawing.Point(323, 4);
            this.buttonServoOn.Name = "buttonServoOn";
            this.buttonServoOn.Size = new System.Drawing.Size(75, 23);
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
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(6, 48);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(778, 321);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // buttonStepResponse
            // 
            this.buttonStepResponse.Location = new System.Drawing.Point(8, 6);
            this.buttonStepResponse.Name = "buttonStepResponse";
            this.buttonStepResponse.Size = new System.Drawing.Size(112, 36);
            this.buttonStepResponse.TabIndex = 0;
            this.buttonStepResponse.Text = "step response";
            this.buttonStepResponse.UseVisualStyleBackColor = true;
            this.buttonStepResponse.Click += new System.EventHandler(this.buttonStepResponse_Click);
            // 
            // numericUpDownID
            // 
            this.numericUpDownID.Location = new System.Drawing.Point(197, 6);
            this.numericUpDownID.Name = "numericUpDownID";
            this.numericUpDownID.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownID.TabIndex = 5;
            // 
            // tabPageTorque
            // 
            this.tabPageTorque.BackColor = System.Drawing.Color.Transparent;
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
            // textBoxBacklash
            // 
            this.textBoxBacklash.Location = new System.Drawing.Point(26, 99);
            this.textBoxBacklash.Name = "textBoxBacklash";
            this.textBoxBacklash.Size = new System.Drawing.Size(172, 22);
            this.textBoxBacklash.TabIndex = 3;
            // 
            // buttonMinPWM
            // 
            this.buttonMinPWM.Location = new System.Drawing.Point(25, 156);
            this.buttonMinPWM.Name = "buttonMinPWM";
            this.buttonMinPWM.Size = new System.Drawing.Size(75, 23);
            this.buttonMinPWM.TabIndex = 4;
            this.buttonMinPWM.Text = "minPWM";
            this.buttonMinPWM.UseVisualStyleBackColor = true;
            this.buttonMinPWM.Click += new System.EventHandler(this.buttonMinPWM_Click);
            // 
            // textBoxMinPWM
            // 
            this.textBoxMinPWM.Location = new System.Drawing.Point(25, 185);
            this.textBoxMinPWM.Name = "textBoxMinPWM";
            this.textBoxMinPWM.Size = new System.Drawing.Size(173, 22);
            this.textBoxMinPWM.TabIndex = 5;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonServoOn);
            this.Controls.Add(this.numericUpDownID);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageStepResp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).EndInit();
            this.tabPageTorque.ResumeLayout(false);
            this.tabPageTorque.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
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
    }
}

