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
            this.label1 = new System.Windows.Forms.Label();
            this.DataType = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddrList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DevType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Data1 = new System.Windows.Forms.Label();
            this.Data2 = new System.Windows.Forms.Label();
            this.Data3 = new System.Windows.Forms.Label();
            this.Data4 = new System.Windows.Forms.Label();
            this.GetData = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.PortSelect = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reloadPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Type:";
            // 
            // DataType
            // 
            this.DataType.AutoSize = true;
            this.DataType.BackColor = System.Drawing.SystemColors.Control;
            this.DataType.Location = new System.Drawing.Point(307, 95);
            this.DataType.Name = "DataType";
            this.DataType.Size = new System.Drawing.Size(55, 15);
            this.DataType.TabIndex = 1;
            this.DataType.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddrList);
            this.groupBox1.Location = new System.Drawing.Point(34, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 341);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // AddrList
            // 
            this.AddrList.FormattingEnabled = true;
            this.AddrList.ItemHeight = 15;
            this.AddrList.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.AddrList.Location = new System.Drawing.Point(6, 24);
            this.AddrList.Name = "AddrList";
            this.AddrList.Size = new System.Drawing.Size(120, 304);
            this.AddrList.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Device Type:";
            // 
            // DevType
            // 
            this.DevType.AutoSize = true;
            this.DevType.BackColor = System.Drawing.SystemColors.Control;
            this.DevType.Location = new System.Drawing.Point(307, 155);
            this.DevType.Name = "DevType";
            this.DevType.Size = new System.Drawing.Size(55, 15);
            this.DevType.TabIndex = 4;
            this.DevType.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data:";
            // 
            // Data1
            // 
            this.Data1.AutoSize = true;
            this.Data1.BackColor = System.Drawing.SystemColors.Control;
            this.Data1.Location = new System.Drawing.Point(307, 196);
            this.Data1.Name = "Data1";
            this.Data1.Size = new System.Drawing.Size(47, 15);
            this.Data1.TabIndex = 6;
            this.Data1.Text = "Data1";
            // 
            // Data2
            // 
            this.Data2.AutoSize = true;
            this.Data2.BackColor = System.Drawing.SystemColors.Control;
            this.Data2.Location = new System.Drawing.Point(307, 230);
            this.Data2.Name = "Data2";
            this.Data2.Size = new System.Drawing.Size(47, 15);
            this.Data2.TabIndex = 7;
            this.Data2.Text = "Data2";
            // 
            // Data3
            // 
            this.Data3.AutoSize = true;
            this.Data3.BackColor = System.Drawing.SystemColors.Control;
            this.Data3.Location = new System.Drawing.Point(307, 264);
            this.Data3.Name = "Data3";
            this.Data3.Size = new System.Drawing.Size(47, 15);
            this.Data3.TabIndex = 8;
            this.Data3.Text = "Data3";
            // 
            // Data4
            // 
            this.Data4.AutoSize = true;
            this.Data4.BackColor = System.Drawing.SystemColors.Control;
            this.Data4.Location = new System.Drawing.Point(307, 298);
            this.Data4.Name = "Data4";
            this.Data4.Size = new System.Drawing.Size(47, 15);
            this.Data4.TabIndex = 9;
            this.Data4.Text = "Data4";
            // 
            // GetData
            // 
            this.GetData.Location = new System.Drawing.Point(253, 380);
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
            this.menuStrip1.Size = new System.Drawing.Size(521, 28);
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
            this.label4.Location = new System.Drawing.Point(37, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Serial Port:";
            // 
            // PortSelect
            // 
            this.PortSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortSelect.FormattingEnabled = true;
            this.PortSelect.Location = new System.Drawing.Point(164, 41);
            this.PortSelect.Name = "PortSelect";
            this.PortSelect.Size = new System.Drawing.Size(121, 23);
            this.PortSelect.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Conncet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reloadPortToolStripMenuItem
            // 
            this.reloadPortToolStripMenuItem.Name = "reloadPortToolStripMenuItem";
            this.reloadPortToolStripMenuItem.ShortcutKeyDisplayString = "R";
            this.reloadPortToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.reloadPortToolStripMenuItem.Text = "Reload(R)";
            this.reloadPortToolStripMenuItem.Click += new System.EventHandler(this.reloadPortToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.Load += new System.EventHandler(this.SettingLoad);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(521, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PortSelect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GetData);
            this.Controls.Add(this.Data4);
            this.Controls.Add(this.Data3);
            this.Controls.Add(this.Data2);
            this.Controls.Add(this.Data1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DevType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DataType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DTU Serial Data Decode";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DataType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox AddrList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DevType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Data1;
        private System.Windows.Forms.Label Data2;
        private System.Windows.Forms.Label Data3;
        private System.Windows.Forms.Label Data4;
        private System.Windows.Forms.Button GetData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PortSelect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem reloadPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

