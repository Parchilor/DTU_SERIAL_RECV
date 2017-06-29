namespace DTU_SERIAL_RECV
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.GetData = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.PortSelect = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RawData = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ST1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SH1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TMP1 = new System.Windows.Forms.Label();
            this.HUM1 = new System.Windows.Forms.Label();
            this.ILL1 = new System.Windows.Forms.Label();
            this.CDC1 = new System.Windows.Forms.Label();
            this.CDC2 = new System.Windows.Forms.Label();
            this.ILL2 = new System.Windows.Forms.Label();
            this.HUM2 = new System.Windows.Forms.Label();
            this.TMP2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SH2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ST2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DAD = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "土壤温湿度1";
            // 
            // GetData
            // 
            this.GetData.Location = new System.Drawing.Point(464, 385);
            this.GetData.Name = "GetData";
            this.GetData.Size = new System.Drawing.Size(112, 34);
            this.GetData.TabIndex = 10;
            this.GetData.Text = "GetData";
            this.GetData.UseVisualStyleBackColor = true;
            this.GetData.Click += new System.EventHandler(this.GetData_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.reloadPortToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.文件FToolStripMenuItem.Text = "File(F)";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // reloadPortToolStripMenuItem
            // 
            this.reloadPortToolStripMenuItem.Name = "reloadPortToolStripMenuItem";
            this.reloadPortToolStripMenuItem.ShortcutKeyDisplayString = "R";
            this.reloadPortToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.reloadPortToolStripMenuItem.Text = "Reload(R)";
            this.reloadPortToolStripMenuItem.Click += new System.EventHandler(this.reloadPortToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.ShortcutKeyDisplayString = "H";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.帮助HToolStripMenuItem.Text = "Help(H)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Serial Port:";
            // 
            // PortSelect
            // 
            this.PortSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortSelect.FormattingEnabled = true;
            this.PortSelect.Location = new System.Drawing.Point(141, 41);
            this.PortSelect.Name = "PortSelect";
            this.PortSelect.Size = new System.Drawing.Size(121, 23);
            this.PortSelect.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Conncet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RawData
            // 
            this.RawData.Location = new System.Drawing.Point(6, 24);
            this.RawData.Multiline = true;
            this.RawData.Name = "RawData";
            this.RawData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RawData.Size = new System.Drawing.Size(771, 72);
            this.RawData.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "土壤温度：";
            // 
            // ST1
            // 
            this.ST1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ST1.Location = new System.Drawing.Point(122, 74);
            this.ST1.Name = "ST1";
            this.ST1.Size = new System.Drawing.Size(79, 15);
            this.ST1.TabIndex = 17;
            this.ST1.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "土壤湿度：";
            // 
            // SH1
            // 
            this.SH1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SH1.Location = new System.Drawing.Point(122, 106);
            this.SH1.Name = "SH1";
            this.SH1.Size = new System.Drawing.Size(79, 15);
            this.SH1.TabIndex = 19;
            this.SH1.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "四要素1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "温度：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(226, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "湿度：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(385, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "日照：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(391, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "CO2：";
            // 
            // TMP1
            // 
            this.TMP1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TMP1.Location = new System.Drawing.Point(284, 74);
            this.TMP1.Name = "TMP1";
            this.TMP1.Size = new System.Drawing.Size(71, 15);
            this.TMP1.TabIndex = 31;
            this.TMP1.Text = "Data";
            // 
            // HUM1
            // 
            this.HUM1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.HUM1.Location = new System.Drawing.Point(284, 106);
            this.HUM1.Name = "HUM1";
            this.HUM1.Size = new System.Drawing.Size(71, 15);
            this.HUM1.TabIndex = 32;
            this.HUM1.Text = "Data";
            // 
            // ILL1
            // 
            this.ILL1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ILL1.Location = new System.Drawing.Point(443, 74);
            this.ILL1.Name = "ILL1";
            this.ILL1.Size = new System.Drawing.Size(71, 15);
            this.ILL1.TabIndex = 33;
            this.ILL1.Text = "Data";
            // 
            // CDC1
            // 
            this.CDC1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CDC1.Location = new System.Drawing.Point(443, 106);
            this.CDC1.Name = "CDC1";
            this.CDC1.Size = new System.Drawing.Size(71, 15);
            this.CDC1.TabIndex = 34;
            this.CDC1.Text = "Data";
            // 
            // CDC2
            // 
            this.CDC2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CDC2.Location = new System.Drawing.Point(443, 253);
            this.CDC2.Name = "CDC2";
            this.CDC2.Size = new System.Drawing.Size(71, 15);
            this.CDC2.TabIndex = 48;
            this.CDC2.Text = "Data";
            // 
            // ILL2
            // 
            this.ILL2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ILL2.Location = new System.Drawing.Point(443, 221);
            this.ILL2.Name = "ILL2";
            this.ILL2.Size = new System.Drawing.Size(71, 15);
            this.ILL2.TabIndex = 47;
            this.ILL2.Text = "Data";
            // 
            // HUM2
            // 
            this.HUM2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.HUM2.Location = new System.Drawing.Point(284, 253);
            this.HUM2.Name = "HUM2";
            this.HUM2.Size = new System.Drawing.Size(71, 15);
            this.HUM2.TabIndex = 46;
            this.HUM2.Text = "Data";
            // 
            // TMP2
            // 
            this.TMP2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TMP2.Location = new System.Drawing.Point(284, 221);
            this.TMP2.Name = "TMP2";
            this.TMP2.Size = new System.Drawing.Size(71, 15);
            this.TMP2.TabIndex = 45;
            this.TMP2.Text = "Data";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(391, 253);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 15);
            this.label14.TabIndex = 44;
            this.label14.Text = "CO2：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(385, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 15);
            this.label15.TabIndex = 43;
            this.label15.Text = "日照：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(226, 253);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 15);
            this.label16.TabIndex = 42;
            this.label16.Text = "湿度：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(226, 221);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 15);
            this.label17.TabIndex = 41;
            this.label17.Text = "温度：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(342, 186);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 15);
            this.label18.TabIndex = 40;
            this.label18.Text = "四要素2";
            // 
            // SH2
            // 
            this.SH2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SH2.Location = new System.Drawing.Point(122, 253);
            this.SH2.Name = "SH2";
            this.SH2.Size = new System.Drawing.Size(79, 15);
            this.SH2.TabIndex = 39;
            this.SH2.Text = "Data";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(34, 253);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 15);
            this.label20.TabIndex = 38;
            this.label20.Text = "土壤湿度：";
            // 
            // ST2
            // 
            this.ST2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ST2.Location = new System.Drawing.Point(122, 221);
            this.ST2.Name = "ST2";
            this.ST2.Size = new System.Drawing.Size(79, 15);
            this.ST2.TabIndex = 37;
            this.ST2.Text = "Data";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(34, 221);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 15);
            this.label22.TabIndex = 36;
            this.label22.Text = "土壤温度：";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(74, 186);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 15);
            this.label23.TabIndex = 35;
            this.label23.Text = "土壤温湿度2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.CDC2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ILL2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.HUM2);
            this.groupBox2.Controls.Add(this.ST1);
            this.groupBox2.Controls.Add(this.TMP2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.SH1);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.SH2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.TMP1);
            this.groupBox2.Controls.Add(this.ST2);
            this.groupBox2.Controls.Add(this.HUM1);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.ILL1);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.CDC1);
            this.groupBox2.Location = new System.Drawing.Point(24, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 298);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sensor Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RawData);
            this.groupBox1.Location = new System.Drawing.Point(24, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 104);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raw Data";
            // 
            // DAD
            // 
            this.DAD.FormattingEnabled = true;
            this.DAD.ItemHeight = 15;
            this.DAD.Items.AddRange(new object[] {
            "Date:  xx-xx-xx xx:xx:xx",
            "  ID:  xxxx"});
            this.DAD.Location = new System.Drawing.Point(597, 90);
            this.DAD.Name = "DAD";
            this.DAD.Size = new System.Drawing.Size(204, 289);
            this.DAD.TabIndex = 51;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(833, 543);
            this.Controls.Add(this.DAD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PortSelect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GetData);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DTU Serial Data Decode";
            this.Load += new System.EventHandler(this.SettingLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GetData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PortSelect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem reloadPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox RawData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ST1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SH1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label TMP1;
        private System.Windows.Forms.Label HUM1;
        private System.Windows.Forms.Label ILL1;
        private System.Windows.Forms.Label CDC1;
        private System.Windows.Forms.Label CDC2;
        private System.Windows.Forms.Label ILL2;
        private System.Windows.Forms.Label HUM2;
        private System.Windows.Forms.Label TMP2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label SH2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label ST2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox DAD;
    }
}

