namespace Windows_Tools
{
    partial class Main_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Window));
            this.Github_Pages_Button = new System.Windows.Forms.Button();
            this.System_GroupBox = new System.Windows.Forms.GroupBox();
            this.Remove_Windows_Defender_CheckBox = new System.Windows.Forms.CheckBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Disable_SmartScreen_CheckBox = new System.Windows.Forms.CheckBox();
            this.Disable_UAC_CheckBox = new System.Windows.Forms.CheckBox();
            this.Disable_Firewall_CheckBox = new System.Windows.Forms.CheckBox();
            this.Disable_Update_CheckBox = new System.Windows.Forms.CheckBox();
            this.Desktop_GroupBox = new System.Windows.Forms.GroupBox();
            this.Disable_AD_CheckBox = new System.Windows.Forms.CheckBox();
            this.Restore_the_Context_Menu_CheckBox = new System.Windows.Forms.CheckBox();
            this.Taskbar_Right_RadioButton = new System.Windows.Forms.RadioButton();
            this.Taskbar_Left_RadioButton = new System.Windows.Forms.RadioButton();
            this.Taskbar_Down_RadioButton = new System.Windows.Forms.RadioButton();
            this.Taskbar_UP_RadioButton = new System.Windows.Forms.RadioButton();
            this.Customize_Taskbar_CheckBox = new System.Windows.Forms.CheckBox();
            this.Disable_Link_CheckBox = new System.Windows.Forms.CheckBox();
            this.Disable_ShieldIcon_CheckBox = new System.Windows.Forms.CheckBox();
            this.Disable_ShortcutArrows_CheckBox = new System.Windows.Forms.CheckBox();
            this.Activation_Button = new System.Windows.Forms.Button();
            this.Startup_Management_Button = new System.Windows.Forms.Button();
            this.Re_Explorer = new System.Windows.Forms.Button();
            this.Clear_Disktop_Icon_Cache_Button = new System.Windows.Forms.Button();
            this.Disclaimer_Button = new System.Windows.Forms.Button();
            this.Right_ClickMenuManagement_Button = new System.Windows.Forms.Button();
            this.Network_Settings_Button = new System.Windows.Forms.Button();
            this.System_GroupBox.SuspendLayout();
            this.Desktop_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Github_Pages_Button
            // 
            this.Github_Pages_Button.Location = new System.Drawing.Point(511, 266);
            this.Github_Pages_Button.Name = "Github_Pages_Button";
            this.Github_Pages_Button.Size = new System.Drawing.Size(160, 32);
            this.Github_Pages_Button.TabIndex = 24;
            this.Github_Pages_Button.Text = "开放源代码";
            this.Github_Pages_Button.UseVisualStyleBackColor = true;
            this.Github_Pages_Button.Click += new System.EventHandler(this.Github_Pages_Button_Click);
            // 
            // System_GroupBox
            // 
            this.System_GroupBox.Controls.Add(this.Remove_Windows_Defender_CheckBox);
            this.System_GroupBox.Controls.Add(this.DateTimePicker);
            this.System_GroupBox.Controls.Add(this.checkBox1);
            this.System_GroupBox.Controls.Add(this.Disable_SmartScreen_CheckBox);
            this.System_GroupBox.Controls.Add(this.Disable_UAC_CheckBox);
            this.System_GroupBox.Controls.Add(this.Disable_Firewall_CheckBox);
            this.System_GroupBox.Controls.Add(this.Disable_Update_CheckBox);
            this.System_GroupBox.Location = new System.Drawing.Point(378, 12);
            this.System_GroupBox.Name = "System_GroupBox";
            this.System_GroupBox.Size = new System.Drawing.Size(295, 210);
            this.System_GroupBox.TabIndex = 23;
            this.System_GroupBox.TabStop = false;
            this.System_GroupBox.Text = "安全";
            // 
            // Remove_Windows_Defender_CheckBox
            // 
            this.Remove_Windows_Defender_CheckBox.AutoSize = true;
            this.Remove_Windows_Defender_CheckBox.Location = new System.Drawing.Point(13, 174);
            this.Remove_Windows_Defender_CheckBox.Name = "Remove_Windows_Defender_CheckBox";
            this.Remove_Windows_Defender_CheckBox.Size = new System.Drawing.Size(150, 16);
            this.Remove_Windows_Defender_CheckBox.TabIndex = 26;
            this.Remove_Windows_Defender_CheckBox.Text = "移除 Windows Defender";
            this.Remove_Windows_Defender_CheckBox.UseVisualStyleBackColor = true;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(145, 26);
            this.DateTimePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker.MinDate = new System.DateTime(2024, 7, 2, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(135, 21);
            this.DateTimePicker.TabIndex = 20;
            this.DateTimePicker.Value = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 145);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(168, 16);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "关闭“打开文件安全警告”";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Disable_SmartScreen_CheckBox
            // 
            this.Disable_SmartScreen_CheckBox.AutoSize = true;
            this.Disable_SmartScreen_CheckBox.Location = new System.Drawing.Point(13, 87);
            this.Disable_SmartScreen_CheckBox.Name = "Disable_SmartScreen_CheckBox";
            this.Disable_SmartScreen_CheckBox.Size = new System.Drawing.Size(162, 16);
            this.Disable_SmartScreen_CheckBox.TabIndex = 18;
            this.Disable_SmartScreen_CheckBox.Text = "关闭 SmartScreen 筛选器";
            this.Disable_SmartScreen_CheckBox.UseVisualStyleBackColor = true;
            this.Disable_SmartScreen_CheckBox.CheckedChanged += new System.EventHandler(this.Disable_SmartScreen_CheckBox_CheckedChanged);
            // 
            // Disable_UAC_CheckBox
            // 
            this.Disable_UAC_CheckBox.AutoSize = true;
            this.Disable_UAC_CheckBox.Location = new System.Drawing.Point(13, 115);
            this.Disable_UAC_CheckBox.Name = "Disable_UAC_CheckBox";
            this.Disable_UAC_CheckBox.Size = new System.Drawing.Size(102, 16);
            this.Disable_UAC_CheckBox.TabIndex = 17;
            this.Disable_UAC_CheckBox.Text = "关闭 UAC 通知";
            this.Disable_UAC_CheckBox.UseVisualStyleBackColor = true;
            this.Disable_UAC_CheckBox.CheckedChanged += new System.EventHandler(this.Disable_UAC_CheckBox_CheckedChanged);
            // 
            // Disable_Firewall_CheckBox
            // 
            this.Disable_Firewall_CheckBox.AutoSize = true;
            this.Disable_Firewall_CheckBox.Location = new System.Drawing.Point(13, 58);
            this.Disable_Firewall_CheckBox.Name = "Disable_Firewall_CheckBox";
            this.Disable_Firewall_CheckBox.Size = new System.Drawing.Size(108, 16);
            this.Disable_Firewall_CheckBox.TabIndex = 16;
            this.Disable_Firewall_CheckBox.Text = "关闭防火墙通知";
            this.Disable_Firewall_CheckBox.UseVisualStyleBackColor = true;
            this.Disable_Firewall_CheckBox.CheckedChanged += new System.EventHandler(this.Disable_Firewall_CheckBox_CheckedChanged);
            // 
            // Disable_Update_CheckBox
            // 
            this.Disable_Update_CheckBox.AutoSize = true;
            this.Disable_Update_CheckBox.Location = new System.Drawing.Point(13, 29);
            this.Disable_Update_CheckBox.Name = "Disable_Update_CheckBox";
            this.Disable_Update_CheckBox.Size = new System.Drawing.Size(126, 16);
            this.Disable_Update_CheckBox.TabIndex = 0;
            this.Disable_Update_CheckBox.Text = "关闭系统更新到...";
            this.Disable_Update_CheckBox.UseVisualStyleBackColor = true;
            this.Disable_Update_CheckBox.CheckedChanged += new System.EventHandler(this.Disable_Update_CheckBox_CheckedChanged);
            // 
            // Desktop_GroupBox
            // 
            this.Desktop_GroupBox.Controls.Add(this.Disable_AD_CheckBox);
            this.Desktop_GroupBox.Controls.Add(this.Restore_the_Context_Menu_CheckBox);
            this.Desktop_GroupBox.Controls.Add(this.Taskbar_Right_RadioButton);
            this.Desktop_GroupBox.Controls.Add(this.Taskbar_Left_RadioButton);
            this.Desktop_GroupBox.Controls.Add(this.Taskbar_Down_RadioButton);
            this.Desktop_GroupBox.Controls.Add(this.Taskbar_UP_RadioButton);
            this.Desktop_GroupBox.Controls.Add(this.Customize_Taskbar_CheckBox);
            this.Desktop_GroupBox.Controls.Add(this.Disable_Link_CheckBox);
            this.Desktop_GroupBox.Controls.Add(this.Disable_ShieldIcon_CheckBox);
            this.Desktop_GroupBox.Controls.Add(this.Disable_ShortcutArrows_CheckBox);
            this.Desktop_GroupBox.Location = new System.Drawing.Point(12, 12);
            this.Desktop_GroupBox.Name = "Desktop_GroupBox";
            this.Desktop_GroupBox.Size = new System.Drawing.Size(360, 210);
            this.Desktop_GroupBox.TabIndex = 22;
            this.Desktop_GroupBox.TabStop = false;
            this.Desktop_GroupBox.Text = "桌面";
            // 
            // Disable_AD_CheckBox
            // 
            this.Disable_AD_CheckBox.AutoSize = true;
            this.Disable_AD_CheckBox.Location = new System.Drawing.Point(12, 174);
            this.Disable_AD_CheckBox.Name = "Disable_AD_CheckBox";
            this.Disable_AD_CheckBox.Size = new System.Drawing.Size(156, 16);
            this.Disable_AD_CheckBox.TabIndex = 25;
            this.Disable_AD_CheckBox.Text = "关闭任务栏和搜素栏广告";
            this.Disable_AD_CheckBox.UseVisualStyleBackColor = true;
            this.Disable_AD_CheckBox.CheckedChanged += new System.EventHandler(this.Disable_AD_CheckBox_CheckedChanged);
            // 
            // Restore_the_Context_Menu_CheckBox
            // 
            this.Restore_the_Context_Menu_CheckBox.AutoSize = true;
            this.Restore_the_Context_Menu_CheckBox.Location = new System.Drawing.Point(12, 145);
            this.Restore_the_Context_Menu_CheckBox.Name = "Restore_the_Context_Menu_CheckBox";
            this.Restore_the_Context_Menu_CheckBox.Size = new System.Drawing.Size(120, 16);
            this.Restore_the_Context_Menu_CheckBox.TabIndex = 24;
            this.Restore_the_Context_Menu_CheckBox.Text = "恢复经典右键菜单";
            this.Restore_the_Context_Menu_CheckBox.UseVisualStyleBackColor = true;
            this.Restore_the_Context_Menu_CheckBox.CheckedChanged += new System.EventHandler(this.Restore_the_Context_Menu_CheckBox_CheckedChanged);
            // 
            // Taskbar_Right_RadioButton
            // 
            this.Taskbar_Right_RadioButton.AutoSize = true;
            this.Taskbar_Right_RadioButton.Enabled = false;
            this.Taskbar_Right_RadioButton.Location = new System.Drawing.Point(304, 115);
            this.Taskbar_Right_RadioButton.Name = "Taskbar_Right_RadioButton";
            this.Taskbar_Right_RadioButton.Size = new System.Drawing.Size(47, 16);
            this.Taskbar_Right_RadioButton.TabIndex = 23;
            this.Taskbar_Right_RadioButton.Text = "右边";
            this.Taskbar_Right_RadioButton.UseVisualStyleBackColor = true;
            this.Taskbar_Right_RadioButton.CheckedChanged += new System.EventHandler(this.Taskbar_Right_RadioButton_CheckedChanged);
            // 
            // Taskbar_Left_RadioButton
            // 
            this.Taskbar_Left_RadioButton.AutoSize = true;
            this.Taskbar_Left_RadioButton.Enabled = false;
            this.Taskbar_Left_RadioButton.Location = new System.Drawing.Point(251, 115);
            this.Taskbar_Left_RadioButton.Name = "Taskbar_Left_RadioButton";
            this.Taskbar_Left_RadioButton.Size = new System.Drawing.Size(47, 16);
            this.Taskbar_Left_RadioButton.TabIndex = 22;
            this.Taskbar_Left_RadioButton.Text = "左边";
            this.Taskbar_Left_RadioButton.UseVisualStyleBackColor = true;
            this.Taskbar_Left_RadioButton.CheckedChanged += new System.EventHandler(this.Taskbar_Left_RadioButton_CheckedChanged);
            // 
            // Taskbar_Down_RadioButton
            // 
            this.Taskbar_Down_RadioButton.AutoSize = true;
            this.Taskbar_Down_RadioButton.Checked = true;
            this.Taskbar_Down_RadioButton.Enabled = false;
            this.Taskbar_Down_RadioButton.Location = new System.Drawing.Point(198, 115);
            this.Taskbar_Down_RadioButton.Name = "Taskbar_Down_RadioButton";
            this.Taskbar_Down_RadioButton.Size = new System.Drawing.Size(47, 16);
            this.Taskbar_Down_RadioButton.TabIndex = 21;
            this.Taskbar_Down_RadioButton.TabStop = true;
            this.Taskbar_Down_RadioButton.Text = "底部";
            this.Taskbar_Down_RadioButton.UseVisualStyleBackColor = true;
            this.Taskbar_Down_RadioButton.CheckedChanged += new System.EventHandler(this.Taskbar_Down_RadioButton_CheckedChanged);
            // 
            // Taskbar_UP_RadioButton
            // 
            this.Taskbar_UP_RadioButton.AutoSize = true;
            this.Taskbar_UP_RadioButton.Enabled = false;
            this.Taskbar_UP_RadioButton.Location = new System.Drawing.Point(145, 115);
            this.Taskbar_UP_RadioButton.Name = "Taskbar_UP_RadioButton";
            this.Taskbar_UP_RadioButton.Size = new System.Drawing.Size(47, 16);
            this.Taskbar_UP_RadioButton.TabIndex = 20;
            this.Taskbar_UP_RadioButton.Text = "顶部";
            this.Taskbar_UP_RadioButton.UseVisualStyleBackColor = true;
            this.Taskbar_UP_RadioButton.CheckedChanged += new System.EventHandler(this.Taskbar_UP_RadioButton_CheckedChanged);
            // 
            // Customize_Taskbar_CheckBox
            // 
            this.Customize_Taskbar_CheckBox.AutoSize = true;
            this.Customize_Taskbar_CheckBox.Location = new System.Drawing.Point(12, 116);
            this.Customize_Taskbar_CheckBox.Name = "Customize_Taskbar_CheckBox";
            this.Customize_Taskbar_CheckBox.Size = new System.Drawing.Size(126, 16);
            this.Customize_Taskbar_CheckBox.TabIndex = 19;
            this.Customize_Taskbar_CheckBox.Text = "将任务栏设置到...";
            this.Customize_Taskbar_CheckBox.UseVisualStyleBackColor = true;
            this.Customize_Taskbar_CheckBox.CheckedChanged += new System.EventHandler(this.Customize_Taskbar_CheckBox_CheckedChanged);
            // 
            // Disable_Link_CheckBox
            // 
            this.Disable_Link_CheckBox.AutoSize = true;
            this.Disable_Link_CheckBox.Location = new System.Drawing.Point(12, 87);
            this.Disable_Link_CheckBox.Name = "Disable_Link_CheckBox";
            this.Disable_Link_CheckBox.Size = new System.Drawing.Size(240, 16);
            this.Disable_Link_CheckBox.TabIndex = 18;
            this.Disable_Link_CheckBox.Text = "创建快捷方式时不显示“快捷方式”后缀";
            this.Disable_Link_CheckBox.UseVisualStyleBackColor = true;
            this.Disable_Link_CheckBox.CheckedChanged += new System.EventHandler(this.Disable_Link_CheckBox_CheckedChanged);
            // 
            // Disable_ShieldIcon_CheckBox
            // 
            this.Disable_ShieldIcon_CheckBox.AutoSize = true;
            this.Disable_ShieldIcon_CheckBox.Location = new System.Drawing.Point(12, 58);
            this.Disable_ShieldIcon_CheckBox.Name = "Disable_ShieldIcon_CheckBox";
            this.Disable_ShieldIcon_CheckBox.Size = new System.Drawing.Size(168, 16);
            this.Disable_ShieldIcon_CheckBox.TabIndex = 17;
            this.Disable_ShieldIcon_CheckBox.Text = "隐藏快捷方式右下角的盾牌";
            this.Disable_ShieldIcon_CheckBox.UseVisualStyleBackColor = true;
            this.Disable_ShieldIcon_CheckBox.CheckedChanged += new System.EventHandler(this.Disable_ShieldIcon_CheckBox_CheckedChanged);
            // 
            // Disable_ShortcutArrows_CheckBox
            // 
            this.Disable_ShortcutArrows_CheckBox.AutoSize = true;
            this.Disable_ShortcutArrows_CheckBox.Location = new System.Drawing.Point(12, 29);
            this.Disable_ShortcutArrows_CheckBox.Name = "Disable_ShortcutArrows_CheckBox";
            this.Disable_ShortcutArrows_CheckBox.Size = new System.Drawing.Size(132, 16);
            this.Disable_ShortcutArrows_CheckBox.TabIndex = 0;
            this.Disable_ShortcutArrows_CheckBox.Text = "隐藏快捷方式小箭头";
            this.Disable_ShortcutArrows_CheckBox.UseVisualStyleBackColor = true;
            this.Disable_ShortcutArrows_CheckBox.CheckedChanged += new System.EventHandler(this.Disable_ShortcutArrows_CheckBox_CheckedChanged);
            // 
            // Activation_Button
            // 
            this.Activation_Button.Location = new System.Drawing.Point(179, 228);
            this.Activation_Button.Name = "Activation_Button";
            this.Activation_Button.Size = new System.Drawing.Size(160, 32);
            this.Activation_Button.TabIndex = 21;
            this.Activation_Button.Text = "激活系统和 Office";
            this.Activation_Button.UseVisualStyleBackColor = true;
            this.Activation_Button.Click += new System.EventHandler(this.Activation_Button_Click);
            // 
            // Startup_Management_Button
            // 
            this.Startup_Management_Button.Location = new System.Drawing.Point(12, 228);
            this.Startup_Management_Button.Name = "Startup_Management_Button";
            this.Startup_Management_Button.Size = new System.Drawing.Size(160, 32);
            this.Startup_Management_Button.TabIndex = 20;
            this.Startup_Management_Button.Text = "管理启动项";
            this.Startup_Management_Button.UseVisualStyleBackColor = true;
            this.Startup_Management_Button.Click += new System.EventHandler(this.Startup_Management_Button_Click);
            // 
            // Re_Explorer
            // 
            this.Re_Explorer.Location = new System.Drawing.Point(12, 266);
            this.Re_Explorer.Name = "Re_Explorer";
            this.Re_Explorer.Size = new System.Drawing.Size(160, 32);
            this.Re_Explorer.TabIndex = 19;
            this.Re_Explorer.Text = "重启资源管理器";
            this.Re_Explorer.UseVisualStyleBackColor = true;
            this.Re_Explorer.Click += new System.EventHandler(this.Re_Explorer_Click);
            // 
            // Clear_Disktop_Icon_Cache_Button
            // 
            this.Clear_Disktop_Icon_Cache_Button.Location = new System.Drawing.Point(179, 266);
            this.Clear_Disktop_Icon_Cache_Button.Name = "Clear_Disktop_Icon_Cache_Button";
            this.Clear_Disktop_Icon_Cache_Button.Size = new System.Drawing.Size(160, 32);
            this.Clear_Disktop_Icon_Cache_Button.TabIndex = 25;
            this.Clear_Disktop_Icon_Cache_Button.Text = "清除桌面图标缓存";
            this.Clear_Disktop_Icon_Cache_Button.UseVisualStyleBackColor = true;
            this.Clear_Disktop_Icon_Cache_Button.Click += new System.EventHandler(this.Clear_Disktop_Icon_Cache_Button_Click);
            // 
            // Disclaimer_Button
            // 
            this.Disclaimer_Button.Location = new System.Drawing.Point(345, 266);
            this.Disclaimer_Button.Name = "Disclaimer_Button";
            this.Disclaimer_Button.Size = new System.Drawing.Size(160, 32);
            this.Disclaimer_Button.TabIndex = 27;
            this.Disclaimer_Button.Text = "免责声明";
            this.Disclaimer_Button.UseVisualStyleBackColor = true;
            this.Disclaimer_Button.Click += new System.EventHandler(this.Disclaimer_Button_Click);
            // 
            // Right_ClickMenuManagement_Button
            // 
            this.Right_ClickMenuManagement_Button.Location = new System.Drawing.Point(345, 228);
            this.Right_ClickMenuManagement_Button.Name = "Right_ClickMenuManagement_Button";
            this.Right_ClickMenuManagement_Button.Size = new System.Drawing.Size(160, 32);
            this.Right_ClickMenuManagement_Button.TabIndex = 26;
            this.Right_ClickMenuManagement_Button.Text = "管理右键菜单";
            this.Right_ClickMenuManagement_Button.UseVisualStyleBackColor = true;
            // 
            // Network_Settings_Button
            // 
            this.Network_Settings_Button.Location = new System.Drawing.Point(511, 228);
            this.Network_Settings_Button.Name = "Network_Settings_Button";
            this.Network_Settings_Button.Size = new System.Drawing.Size(160, 32);
            this.Network_Settings_Button.TabIndex = 28;
            this.Network_Settings_Button.Text = "网络设定";
            this.Network_Settings_Button.UseVisualStyleBackColor = true;
            this.Network_Settings_Button.Click += new System.EventHandler(this.Network_Settings_Button_Click);
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 306);
            this.Controls.Add(this.Network_Settings_Button);
            this.Controls.Add(this.Disclaimer_Button);
            this.Controls.Add(this.Right_ClickMenuManagement_Button);
            this.Controls.Add(this.Clear_Disktop_Icon_Cache_Button);
            this.Controls.Add(this.Github_Pages_Button);
            this.Controls.Add(this.System_GroupBox);
            this.Controls.Add(this.Desktop_GroupBox);
            this.Controls.Add(this.Activation_Button);
            this.Controls.Add(this.Startup_Management_Button);
            this.Controls.Add(this.Re_Explorer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows 11 个性化工具";
            this.Load += new System.EventHandler(this.Main_Window_Load);
            this.System_GroupBox.ResumeLayout(false);
            this.System_GroupBox.PerformLayout();
            this.Desktop_GroupBox.ResumeLayout(false);
            this.Desktop_GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Github_Pages_Button;
        private System.Windows.Forms.GroupBox System_GroupBox;
        private System.Windows.Forms.CheckBox Remove_Windows_Defender_CheckBox;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox Disable_SmartScreen_CheckBox;
        private System.Windows.Forms.CheckBox Disable_UAC_CheckBox;
        private System.Windows.Forms.CheckBox Disable_Firewall_CheckBox;
        private System.Windows.Forms.CheckBox Disable_Update_CheckBox;
        private System.Windows.Forms.GroupBox Desktop_GroupBox;
        private System.Windows.Forms.CheckBox Disable_AD_CheckBox;
        private System.Windows.Forms.CheckBox Restore_the_Context_Menu_CheckBox;
        private System.Windows.Forms.RadioButton Taskbar_Right_RadioButton;
        private System.Windows.Forms.RadioButton Taskbar_Left_RadioButton;
        private System.Windows.Forms.RadioButton Taskbar_Down_RadioButton;
        private System.Windows.Forms.RadioButton Taskbar_UP_RadioButton;
        private System.Windows.Forms.CheckBox Customize_Taskbar_CheckBox;
        private System.Windows.Forms.CheckBox Disable_Link_CheckBox;
        private System.Windows.Forms.CheckBox Disable_ShieldIcon_CheckBox;
        private System.Windows.Forms.CheckBox Disable_ShortcutArrows_CheckBox;
        private System.Windows.Forms.Button Activation_Button;
        private System.Windows.Forms.Button Startup_Management_Button;
        private System.Windows.Forms.Button Re_Explorer;
        private System.Windows.Forms.Button Clear_Disktop_Icon_Cache_Button;
        private System.Windows.Forms.Button Disclaimer_Button;
        private System.Windows.Forms.Button Right_ClickMenuManagement_Button;
        private System.Windows.Forms.Button Network_Settings_Button;
    }
}

