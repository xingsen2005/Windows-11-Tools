namespace Windows_Tools
{
    partial class Activation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activation));
            this.What_This_Button = new System.Windows.Forms.Button();
            this.Choose_KMS_Server_GroupBox = new System.Windows.Forms.GroupBox();
            this.Set_Activation_Version_ComboBox = new System.Windows.Forms.ComboBox();
            this.Set_Activation_Version_Label = new System.Windows.Forms.Label();
            this.KMS_Tips_Label = new System.Windows.Forms.Label();
            this.Get_Ping_Button = new System.Windows.Forms.Button();
            this.Choose_KMS_Server_ComboBox = new System.Windows.Forms.ComboBox();
            this.Choose_KMS_Server_Lable = new System.Windows.Forms.Label();
            this.Activation_Windows = new System.Windows.Forms.GroupBox();
            this.Activations_Tips_Lable = new System.Windows.Forms.Label();
            this.Spw_Code = new System.Windows.Forms.Button();
            this.Code_TextBox = new System.Windows.Forms.TextBox();
            this.Code_Lable = new System.Windows.Forms.Label();
            this.Start_Activation_Button = new System.Windows.Forms.Button();
            this.Backup_Windows_Key_Button = new System.Windows.Forms.Button();
            this.Check_Activation_Button = new System.Windows.Forms.Button();
            this.OEM_Activation_RadioButton = new System.Windows.Forms.RadioButton();
            this.KMS_Activation_RadioButton = new System.Windows.Forms.RadioButton();
            this.HWID_Activation_RadioButton = new System.Windows.Forms.RadioButton();
            this.Start_Activation_Office_Button = new System.Windows.Forms.Button();
            this.Activation_Office = new System.Windows.Forms.GroupBox();
            this.Backup_Office_Key_Button = new System.Windows.Forms.Button();
            this.Office_Setup_Version_ComboBox = new System.Windows.Forms.ComboBox();
            this.Office_Setup_Version_Label = new System.Windows.Forms.Label();
            this.Choose_KMS_Server_GroupBox.SuspendLayout();
            this.Activation_Windows.SuspendLayout();
            this.Activation_Office.SuspendLayout();
            this.SuspendLayout();
            // 
            // What_This_Button
            // 
            this.What_This_Button.Location = new System.Drawing.Point(401, 59);
            this.What_This_Button.Name = "What_This_Button";
            this.What_This_Button.Size = new System.Drawing.Size(90, 21);
            this.What_This_Button.TabIndex = 14;
            this.What_This_Button.Text = "有何区别?";
            this.What_This_Button.UseVisualStyleBackColor = true;
            this.What_This_Button.Click += new System.EventHandler(this.What_This_Button_Click);
            // 
            // Choose_KMS_Server_GroupBox
            // 
            this.Choose_KMS_Server_GroupBox.Controls.Add(this.What_This_Button);
            this.Choose_KMS_Server_GroupBox.Controls.Add(this.Set_Activation_Version_ComboBox);
            this.Choose_KMS_Server_GroupBox.Controls.Add(this.Set_Activation_Version_Label);
            this.Choose_KMS_Server_GroupBox.Controls.Add(this.KMS_Tips_Label);
            this.Choose_KMS_Server_GroupBox.Controls.Add(this.Get_Ping_Button);
            this.Choose_KMS_Server_GroupBox.Controls.Add(this.Choose_KMS_Server_ComboBox);
            this.Choose_KMS_Server_GroupBox.Controls.Add(this.Choose_KMS_Server_Lable);
            this.Choose_KMS_Server_GroupBox.Location = new System.Drawing.Point(13, 266);
            this.Choose_KMS_Server_GroupBox.Name = "Choose_KMS_Server_GroupBox";
            this.Choose_KMS_Server_GroupBox.Size = new System.Drawing.Size(500, 120);
            this.Choose_KMS_Server_GroupBox.TabIndex = 6;
            this.Choose_KMS_Server_GroupBox.TabStop = false;
            this.Choose_KMS_Server_GroupBox.Text = "自定义激活配置";
            // 
            // Set_Activation_Version_ComboBox
            // 
            this.Set_Activation_Version_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Set_Activation_Version_ComboBox.FormattingEnabled = true;
            this.Set_Activation_Version_ComboBox.Items.AddRange(new object[] {
            "专业版",
            "专业版 N",
            "专业工作站版",
            "专业工作站版 N",
            "专业教育版",
            "专业教育版 N",
            "教育版",
            "教育版 N",
            "企业版",
            "企业版 N",
            "企业版 G",
            "企业版 G N"});
            this.Set_Activation_Version_ComboBox.Location = new System.Drawing.Point(149, 59);
            this.Set_Activation_Version_ComboBox.Name = "Set_Activation_Version_ComboBox";
            this.Set_Activation_Version_ComboBox.Size = new System.Drawing.Size(246, 20);
            this.Set_Activation_Version_ComboBox.TabIndex = 13;
            // 
            // Set_Activation_Version_Label
            // 
            this.Set_Activation_Version_Label.AutoSize = true;
            this.Set_Activation_Version_Label.Location = new System.Drawing.Point(11, 62);
            this.Set_Activation_Version_Label.Name = "Set_Activation_Version_Label";
            this.Set_Activation_Version_Label.Size = new System.Drawing.Size(119, 12);
            this.Set_Activation_Version_Label.TabIndex = 12;
            this.Set_Activation_Version_Label.Text = "将 Windows 激活为：";
            // 
            // KMS_Tips_Label
            // 
            this.KMS_Tips_Label.AutoSize = true;
            this.KMS_Tips_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.KMS_Tips_Label.Location = new System.Drawing.Point(11, 93);
            this.KMS_Tips_Label.Name = "KMS_Tips_Label";
            this.KMS_Tips_Label.Size = new System.Drawing.Size(455, 12);
            this.KMS_Tips_Label.TabIndex = 11;
            this.KMS_Tips_Label.Text = "软件会自动寻找可用且延时最低的 KMS 服务器，因此除非特殊需求，不必自行选择。";
            // 
            // Get_Ping_Button
            // 
            this.Get_Ping_Button.Location = new System.Drawing.Point(401, 28);
            this.Get_Ping_Button.Name = "Get_Ping_Button";
            this.Get_Ping_Button.Size = new System.Drawing.Size(90, 21);
            this.Get_Ping_Button.TabIndex = 10;
            this.Get_Ping_Button.Text = "再次寻找";
            this.Get_Ping_Button.UseVisualStyleBackColor = true;
            this.Get_Ping_Button.Click += new System.EventHandler(this.Get_Ping_Button_Click);
            // 
            // Choose_KMS_Server_ComboBox
            // 
            this.Choose_KMS_Server_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Choose_KMS_Server_ComboBox.FormattingEnabled = true;
            this.Choose_KMS_Server_ComboBox.Location = new System.Drawing.Point(149, 28);
            this.Choose_KMS_Server_ComboBox.Name = "Choose_KMS_Server_ComboBox";
            this.Choose_KMS_Server_ComboBox.Size = new System.Drawing.Size(246, 20);
            this.Choose_KMS_Server_ComboBox.TabIndex = 9;
            // 
            // Choose_KMS_Server_Lable
            // 
            this.Choose_KMS_Server_Lable.AutoSize = true;
            this.Choose_KMS_Server_Lable.Location = new System.Drawing.Point(11, 32);
            this.Choose_KMS_Server_Lable.Name = "Choose_KMS_Server_Lable";
            this.Choose_KMS_Server_Lable.Size = new System.Drawing.Size(119, 12);
            this.Choose_KMS_Server_Lable.TabIndex = 8;
            this.Choose_KMS_Server_Lable.Text = "设置 KMS 服务器为：";
            // 
            // Activation_Windows
            // 
            this.Activation_Windows.Controls.Add(this.Activations_Tips_Lable);
            this.Activation_Windows.Controls.Add(this.Spw_Code);
            this.Activation_Windows.Controls.Add(this.Code_TextBox);
            this.Activation_Windows.Controls.Add(this.Code_Lable);
            this.Activation_Windows.Controls.Add(this.Start_Activation_Button);
            this.Activation_Windows.Controls.Add(this.Backup_Windows_Key_Button);
            this.Activation_Windows.Controls.Add(this.Check_Activation_Button);
            this.Activation_Windows.Controls.Add(this.OEM_Activation_RadioButton);
            this.Activation_Windows.Controls.Add(this.KMS_Activation_RadioButton);
            this.Activation_Windows.Controls.Add(this.HWID_Activation_RadioButton);
            this.Activation_Windows.Location = new System.Drawing.Point(13, 13);
            this.Activation_Windows.Name = "Activation_Windows";
            this.Activation_Windows.Size = new System.Drawing.Size(500, 140);
            this.Activation_Windows.TabIndex = 4;
            this.Activation_Windows.TabStop = false;
            this.Activation_Windows.Text = "激活 Windows";
            // 
            // Activations_Tips_Lable
            // 
            this.Activations_Tips_Lable.AutoSize = true;
            this.Activations_Tips_Lable.ForeColor = System.Drawing.Color.Red;
            this.Activations_Tips_Lable.Location = new System.Drawing.Point(95, 92);
            this.Activations_Tips_Lable.Name = "Activations_Tips_Lable";
            this.Activations_Tips_Lable.Size = new System.Drawing.Size(275, 12);
            this.Activations_Tips_Lable.TabIndex = 9;
            this.Activations_Tips_Lable.Text = "出现了 Windows 激活序列号中不应该出现的字符。";
            this.Activations_Tips_Lable.Visible = false;
            // 
            // Spw_Code
            // 
            this.Spw_Code.Enabled = false;
            this.Spw_Code.Location = new System.Drawing.Point(401, 63);
            this.Spw_Code.Name = "Spw_Code";
            this.Spw_Code.Size = new System.Drawing.Size(87, 21);
            this.Spw_Code.TabIndex = 8;
            this.Spw_Code.Text = "生成序列号";
            this.Spw_Code.UseVisualStyleBackColor = true;
            this.Spw_Code.Click += new System.EventHandler(this.Spw_Code_Click);
            // 
            // Code_TextBox
            // 
            this.Code_TextBox.Enabled = false;
            this.Code_TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Code_TextBox.Location = new System.Drawing.Point(95, 61);
            this.Code_TextBox.MaxLength = 29;
            this.Code_TextBox.Name = "Code_TextBox";
            this.Code_TextBox.Size = new System.Drawing.Size(300, 21);
            this.Code_TextBox.TabIndex = 7;
            this.Code_TextBox.TextChanged += new System.EventHandler(this.Code_TextBox_TextChanged);
            // 
            // Code_Lable
            // 
            this.Code_Lable.AutoSize = true;
            this.Code_Lable.Enabled = false;
            this.Code_Lable.Location = new System.Drawing.Point(11, 67);
            this.Code_Lable.Name = "Code_Lable";
            this.Code_Lable.Size = new System.Drawing.Size(77, 12);
            this.Code_Lable.TabIndex = 6;
            this.Code_Lable.Text = "选择序列号：";
            // 
            // Start_Activation_Button
            // 
            this.Start_Activation_Button.Location = new System.Drawing.Point(340, 97);
            this.Start_Activation_Button.Name = "Start_Activation_Button";
            this.Start_Activation_Button.Size = new System.Drawing.Size(150, 32);
            this.Start_Activation_Button.TabIndex = 5;
            this.Start_Activation_Button.Text = "开始激活";
            this.Start_Activation_Button.UseVisualStyleBackColor = true;
            this.Start_Activation_Button.Click += new System.EventHandler(this.Start_Activation_Button_Click);
            // 
            // Backup_Windows_Key_Button
            // 
            this.Backup_Windows_Key_Button.Location = new System.Drawing.Point(174, 97);
            this.Backup_Windows_Key_Button.Name = "Backup_Windows_Key_Button";
            this.Backup_Windows_Key_Button.Size = new System.Drawing.Size(150, 32);
            this.Backup_Windows_Key_Button.TabIndex = 4;
            this.Backup_Windows_Key_Button.Text = "查询当前序列号";
            this.Backup_Windows_Key_Button.UseVisualStyleBackColor = true;
            this.Backup_Windows_Key_Button.Click += new System.EventHandler(this.Backup_Windows_Key_Button_Click);
            // 
            // Check_Activation_Button
            // 
            this.Check_Activation_Button.Location = new System.Drawing.Point(8, 97);
            this.Check_Activation_Button.Name = "Check_Activation_Button";
            this.Check_Activation_Button.Size = new System.Drawing.Size(150, 32);
            this.Check_Activation_Button.TabIndex = 3;
            this.Check_Activation_Button.Text = "检查系统是否激活";
            this.Check_Activation_Button.UseVisualStyleBackColor = true;
            this.Check_Activation_Button.Click += new System.EventHandler(this.Check_Activation_Button_Click);
            // 
            // OEM_Activation_RadioButton
            // 
            this.OEM_Activation_RadioButton.AutoSize = true;
            this.OEM_Activation_RadioButton.Location = new System.Drawing.Point(351, 31);
            this.OEM_Activation_RadioButton.Name = "OEM_Activation_RadioButton";
            this.OEM_Activation_RadioButton.Size = new System.Drawing.Size(113, 16);
            this.OEM_Activation_RadioButton.TabIndex = 2;
            this.OEM_Activation_RadioButton.Text = "伪装为 OEM 激活";
            this.OEM_Activation_RadioButton.UseVisualStyleBackColor = true;
            this.OEM_Activation_RadioButton.CheckedChanged += new System.EventHandler(this.OEM_Activation_RadioButton_CheckedChanged_1);
            // 
            // KMS_Activation_RadioButton
            // 
            this.KMS_Activation_RadioButton.AutoSize = true;
            this.KMS_Activation_RadioButton.Location = new System.Drawing.Point(179, 31);
            this.KMS_Activation_RadioButton.Name = "KMS_Activation_RadioButton";
            this.KMS_Activation_RadioButton.Size = new System.Drawing.Size(125, 16);
            this.KMS_Activation_RadioButton.TabIndex = 1;
            this.KMS_Activation_RadioButton.Text = "基于 KMS 服务激活";
            this.KMS_Activation_RadioButton.UseVisualStyleBackColor = true;
            this.KMS_Activation_RadioButton.CheckedChanged += new System.EventHandler(this.KMS_Activation_RadioButton_CheckedChanged);
            // 
            // HWID_Activation_RadioButton
            // 
            this.HWID_Activation_RadioButton.AutoSize = true;
            this.HWID_Activation_RadioButton.Checked = true;
            this.HWID_Activation_RadioButton.Location = new System.Drawing.Point(12, 31);
            this.HWID_Activation_RadioButton.Name = "HWID_Activation_RadioButton";
            this.HWID_Activation_RadioButton.Size = new System.Drawing.Size(131, 16);
            this.HWID_Activation_RadioButton.TabIndex = 0;
            this.HWID_Activation_RadioButton.TabStop = true;
            this.HWID_Activation_RadioButton.Text = "基于数字许可证激活";
            this.HWID_Activation_RadioButton.UseVisualStyleBackColor = true;
            this.HWID_Activation_RadioButton.CheckedChanged += new System.EventHandler(this.HWID_Activation_RadioButton_CheckedChanged);
            // 
            // Start_Activation_Office_Button
            // 
            this.Start_Activation_Office_Button.Location = new System.Drawing.Point(340, 54);
            this.Start_Activation_Office_Button.Name = "Start_Activation_Office_Button";
            this.Start_Activation_Office_Button.Size = new System.Drawing.Size(150, 32);
            this.Start_Activation_Office_Button.TabIndex = 5;
            this.Start_Activation_Office_Button.Text = "开始激活";
            this.Start_Activation_Office_Button.UseVisualStyleBackColor = true;
            this.Start_Activation_Office_Button.Click += new System.EventHandler(this.Start_Activation_Office_Button_Click);
            // 
            // Activation_Office
            // 
            this.Activation_Office.Controls.Add(this.Backup_Office_Key_Button);
            this.Activation_Office.Controls.Add(this.Office_Setup_Version_ComboBox);
            this.Activation_Office.Controls.Add(this.Office_Setup_Version_Label);
            this.Activation_Office.Controls.Add(this.Start_Activation_Office_Button);
            this.Activation_Office.Location = new System.Drawing.Point(13, 160);
            this.Activation_Office.Name = "Activation_Office";
            this.Activation_Office.Size = new System.Drawing.Size(500, 100);
            this.Activation_Office.TabIndex = 5;
            this.Activation_Office.TabStop = false;
            this.Activation_Office.Text = "激活 Office";
            // 
            // Backup_Office_Key_Button
            // 
            this.Backup_Office_Key_Button.Location = new System.Drawing.Point(174, 54);
            this.Backup_Office_Key_Button.Name = "Backup_Office_Key_Button";
            this.Backup_Office_Key_Button.Size = new System.Drawing.Size(150, 32);
            this.Backup_Office_Key_Button.TabIndex = 11;
            this.Backup_Office_Key_Button.Text = "查询当前序列号";
            this.Backup_Office_Key_Button.UseVisualStyleBackColor = true;
            this.Backup_Office_Key_Button.Click += new System.EventHandler(this.Backup_Office_Key_Button_Click);
            // 
            // Office_Setup_Version_ComboBox
            // 
            this.Office_Setup_Version_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Office_Setup_Version_ComboBox.FormattingEnabled = true;
            this.Office_Setup_Version_ComboBox.Items.AddRange(new object[] {
            "Microsoft 365 Apps for enterprise"});
            this.Office_Setup_Version_ComboBox.Location = new System.Drawing.Point(149, 25);
            this.Office_Setup_Version_ComboBox.Name = "Office_Setup_Version_ComboBox";
            this.Office_Setup_Version_ComboBox.Size = new System.Drawing.Size(335, 20);
            this.Office_Setup_Version_ComboBox.TabIndex = 7;
            // 
            // Office_Setup_Version_Label
            // 
            this.Office_Setup_Version_Label.AutoSize = true;
            this.Office_Setup_Version_Label.Location = new System.Drawing.Point(11, 28);
            this.Office_Setup_Version_Label.Name = "Office_Setup_Version_Label";
            this.Office_Setup_Version_Label.Size = new System.Drawing.Size(137, 12);
            this.Office_Setup_Version_Label.TabIndex = 6;
            this.Office_Setup_Version_Label.Text = "已安装的 Office 版本：";
            // 
            // Activation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 396);
            this.Controls.Add(this.Choose_KMS_Server_GroupBox);
            this.Controls.Add(this.Activation_Windows);
            this.Controls.Add(this.Activation_Office);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Activation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "激活组件";
            this.Load += new System.EventHandler(this.Activation_Load);
            this.Choose_KMS_Server_GroupBox.ResumeLayout(false);
            this.Choose_KMS_Server_GroupBox.PerformLayout();
            this.Activation_Windows.ResumeLayout(false);
            this.Activation_Windows.PerformLayout();
            this.Activation_Office.ResumeLayout(false);
            this.Activation_Office.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button What_This_Button;
        private System.Windows.Forms.GroupBox Choose_KMS_Server_GroupBox;
        private System.Windows.Forms.ComboBox Set_Activation_Version_ComboBox;
        private System.Windows.Forms.Label Set_Activation_Version_Label;
        private System.Windows.Forms.Label KMS_Tips_Label;
        private System.Windows.Forms.Button Get_Ping_Button;
        private System.Windows.Forms.ComboBox Choose_KMS_Server_ComboBox;
        private System.Windows.Forms.Label Choose_KMS_Server_Lable;
        private System.Windows.Forms.GroupBox Activation_Windows;
        private System.Windows.Forms.Label Activations_Tips_Lable;
        private System.Windows.Forms.Button Spw_Code;
        private System.Windows.Forms.TextBox Code_TextBox;
        private System.Windows.Forms.Label Code_Lable;
        private System.Windows.Forms.Button Start_Activation_Button;
        private System.Windows.Forms.Button Backup_Windows_Key_Button;
        private System.Windows.Forms.Button Check_Activation_Button;
        private System.Windows.Forms.RadioButton OEM_Activation_RadioButton;
        private System.Windows.Forms.RadioButton KMS_Activation_RadioButton;
        private System.Windows.Forms.RadioButton HWID_Activation_RadioButton;
        private System.Windows.Forms.Button Start_Activation_Office_Button;
        private System.Windows.Forms.GroupBox Activation_Office;
        private System.Windows.Forms.Button Backup_Office_Key_Button;
        private System.Windows.Forms.ComboBox Office_Setup_Version_ComboBox;
        private System.Windows.Forms.Label Office_Setup_Version_Label;
    }
}