namespace ScratchIO
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBoxWeather = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbReportRain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbReportUltraViolet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbReportWindSpeed = new System.Windows.Forms.TextBox();
            this.tbReportTime = new System.Windows.Forms.TextBox();
            this.tbReportTemperature = new System.Windows.Forms.TextBox();
            this.tbReportHumidity = new System.Windows.Forms.TextBox();
            this.tbReportWindDir = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxComm = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbUpdatePeriod = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.tbScratchAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.groupBoxWeather.SuspendLayout();
            this.groupBoxComm.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(71, 230);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 31);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "啟動";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBoxWeather
            // 
            this.groupBoxWeather.Controls.Add(this.label10);
            this.groupBoxWeather.Controls.Add(this.label7);
            this.groupBoxWeather.Controls.Add(this.label3);
            this.groupBoxWeather.Controls.Add(this.label2);
            this.groupBoxWeather.Controls.Add(this.label16);
            this.groupBoxWeather.Controls.Add(this.tbReportRain);
            this.groupBoxWeather.Controls.Add(this.label4);
            this.groupBoxWeather.Controls.Add(this.tbReportUltraViolet);
            this.groupBoxWeather.Controls.Add(this.label9);
            this.groupBoxWeather.Controls.Add(this.label8);
            this.groupBoxWeather.Controls.Add(this.label6);
            this.groupBoxWeather.Controls.Add(this.label5);
            this.groupBoxWeather.Controls.Add(this.label1);
            this.groupBoxWeather.Controls.Add(this.tbReportWindSpeed);
            this.groupBoxWeather.Controls.Add(this.tbReportTime);
            this.groupBoxWeather.Controls.Add(this.tbReportTemperature);
            this.groupBoxWeather.Controls.Add(this.tbReportHumidity);
            this.groupBoxWeather.Controls.Add(this.tbReportWindDir);
            this.groupBoxWeather.Location = new System.Drawing.Point(394, 33);
            this.groupBoxWeather.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBoxWeather.Name = "groupBoxWeather";
            this.groupBoxWeather.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBoxWeather.Size = new System.Drawing.Size(343, 294);
            this.groupBoxWeather.TabIndex = 67;
            this.groupBoxWeather.TabStop = false;
            this.groupBoxWeather.Text = "氣象局資料";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(290, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 16);
            this.label10.TabIndex = 146;
            this.label10.Text = "m/s";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 145;
            this.label7.Text = "mm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 144;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 143;
            this.label2.Text = "℃";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(47, 250);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 16);
            this.label16.TabIndex = 142;
            this.label16.Text = "本日雨量 :";
            // 
            // tbReportRain
            // 
            this.tbReportRain.Location = new System.Drawing.Point(135, 247);
            this.tbReportRain.Margin = new System.Windows.Forms.Padding(4);
            this.tbReportRain.Name = "tbReportRain";
            this.tbReportRain.ReadOnly = true;
            this.tbReportRain.Size = new System.Drawing.Size(148, 27);
            this.tbReportRain.TabIndex = 141;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(63, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 132;
            this.label4.Text = "紫外線 :";
            // 
            // tbReportUltraViolet
            // 
            this.tbReportUltraViolet.Location = new System.Drawing.Point(135, 209);
            this.tbReportUltraViolet.Margin = new System.Windows.Forms.Padding(4);
            this.tbReportUltraViolet.Name = "tbReportUltraViolet";
            this.tbReportUltraViolet.ReadOnly = true;
            this.tbReportUltraViolet.Size = new System.Drawing.Size(148, 27);
            this.tbReportUltraViolet.TabIndex = 131;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(75, 177);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 130;
            this.label9.Text = " 風速 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(75, 142);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 129;
            this.label8.Text = " 風向 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(75, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 128;
            this.label6.Text = " 濕度 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(79, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 127;
            this.label5.Text = "溫度 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 122;
            this.label1.Text = "氣候資料時間 :";
            // 
            // tbReportWindSpeed
            // 
            this.tbReportWindSpeed.Location = new System.Drawing.Point(135, 174);
            this.tbReportWindSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.tbReportWindSpeed.Name = "tbReportWindSpeed";
            this.tbReportWindSpeed.ReadOnly = true;
            this.tbReportWindSpeed.Size = new System.Drawing.Size(148, 27);
            this.tbReportWindSpeed.TabIndex = 126;
            // 
            // tbReportTime
            // 
            this.tbReportTime.Location = new System.Drawing.Point(135, 34);
            this.tbReportTime.Margin = new System.Windows.Forms.Padding(4);
            this.tbReportTime.Name = "tbReportTime";
            this.tbReportTime.ReadOnly = true;
            this.tbReportTime.Size = new System.Drawing.Size(148, 27);
            this.tbReportTime.TabIndex = 122;
            // 
            // tbReportTemperature
            // 
            this.tbReportTemperature.Location = new System.Drawing.Point(135, 69);
            this.tbReportTemperature.Margin = new System.Windows.Forms.Padding(4);
            this.tbReportTemperature.Name = "tbReportTemperature";
            this.tbReportTemperature.ReadOnly = true;
            this.tbReportTemperature.Size = new System.Drawing.Size(148, 27);
            this.tbReportTemperature.TabIndex = 123;
            // 
            // tbReportHumidity
            // 
            this.tbReportHumidity.Location = new System.Drawing.Point(135, 104);
            this.tbReportHumidity.Margin = new System.Windows.Forms.Padding(4);
            this.tbReportHumidity.Name = "tbReportHumidity";
            this.tbReportHumidity.ReadOnly = true;
            this.tbReportHumidity.Size = new System.Drawing.Size(148, 27);
            this.tbReportHumidity.TabIndex = 124;
            // 
            // tbReportWindDir
            // 
            this.tbReportWindDir.Location = new System.Drawing.Point(135, 139);
            this.tbReportWindDir.Margin = new System.Windows.Forms.Padding(4);
            this.tbReportWindDir.Name = "tbReportWindDir";
            this.tbReportWindDir.ReadOnly = true;
            this.tbReportWindDir.Size = new System.Drawing.Size(148, 27);
            this.tbReportWindDir.TabIndex = 125;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(9, 39);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 16);
            this.label11.TabIndex = 147;
            this.label11.Text = "Scratch 位址 :";
            // 
            // groupBoxComm
            // 
            this.groupBoxComm.Controls.Add(this.label14);
            this.groupBoxComm.Controls.Add(this.tbUpdatePeriod);
            this.groupBoxComm.Controls.Add(this.label13);
            this.groupBoxComm.Controls.Add(this.cbLocation);
            this.groupBoxComm.Controls.Add(this.tbScratchAddress);
            this.groupBoxComm.Controls.Add(this.label12);
            this.groupBoxComm.Controls.Add(this.label11);
            this.groupBoxComm.Location = new System.Drawing.Point(27, 33);
            this.groupBoxComm.Name = "groupBoxComm";
            this.groupBoxComm.Size = new System.Drawing.Size(343, 158);
            this.groupBoxComm.TabIndex = 148;
            this.groupBoxComm.TabStop = false;
            this.groupBoxComm.Text = "通訊";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(162, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 16);
            this.label14.TabIndex = 147;
            this.label14.Text = "秒";
            // 
            // tbUpdatePeriod
            // 
            this.tbUpdatePeriod.Location = new System.Drawing.Point(110, 111);
            this.tbUpdatePeriod.Name = "tbUpdatePeriod";
            this.tbUpdatePeriod.Size = new System.Drawing.Size(46, 27);
            this.tbUpdatePeriod.TabIndex = 152;
            this.tbUpdatePeriod.Text = "10";
            this.tbUpdatePeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(23, 114);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 16);
            this.label13.TabIndex = 151;
            this.label13.Text = "更新週期 :";
            // 
            // cbLocation
            // 
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(114, 75);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(72, 24);
            this.cbLocation.TabIndex = 150;
            this.cbLocation.Text = "台南";
            this.cbLocation.SelectedIndexChanged += new System.EventHandler(this.cbLocation_SelectedIndexChanged);
            // 
            // tbScratchAddress
            // 
            this.tbScratchAddress.Location = new System.Drawing.Point(114, 36);
            this.tbScratchAddress.Name = "tbScratchAddress";
            this.tbScratchAddress.Size = new System.Drawing.Size(205, 27);
            this.tbScratchAddress.TabIndex = 149;
            this.tbScratchAddress.Text = "localhost";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(23, 75);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 16);
            this.label12.TabIndex = 148;
            this.label12.Text = "測報地點  :";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMessage});
            this.statusStrip.Location = new System.Drawing.Point(0, 347);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(763, 22);
            this.statusStrip.TabIndex = 154;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripMessage
            // 
            this.toolStripMessage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripMessage.Name = "toolStripMessage";
            this.toolStripMessage.Size = new System.Drawing.Size(748, 17);
            this.toolStripMessage.Spring = true;
            this.toolStripMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(225, 230);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(112, 31);
            this.btnHelp.TabIndex = 155;
            this.btnHelp.Text = "Scratch";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(763, 369);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBoxComm);
            this.Controls.Add(this.groupBoxWeather);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Scratch Weather Report";
            this.groupBoxWeather.ResumeLayout(false);
            this.groupBoxWeather.PerformLayout();
            this.groupBoxComm.ResumeLayout(false);
            this.groupBoxComm.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBoxWeather;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbReportRain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbReportUltraViolet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbReportWindSpeed;
        private System.Windows.Forms.TextBox tbReportTime;
        private System.Windows.Forms.TextBox tbReportTemperature;
        private System.Windows.Forms.TextBox tbReportHumidity;
        private System.Windows.Forms.TextBox tbReportWindDir;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBoxComm;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.TextBox tbScratchAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbUpdatePeriod;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripMessage;
        private System.Windows.Forms.Button btnHelp;
    }
}

