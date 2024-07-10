namespace Windows_Tools
{
    partial class Network_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Network_Settings));
            this.Set_MAC_GroupBox = new System.Windows.Forms.GroupBox();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Select_NIC_ComboBox = new System.Windows.Forms.ComboBox();
            this.Select_NIC_Label = new System.Windows.Forms.Label();
            this.Restore_the_Default_Button = new System.Windows.Forms.Button();
            this.MAC_Add_TextBox = new System.Windows.Forms.TextBox();
            this.MAC_Add_Label = new System.Windows.Forms.Label();
            this.Set_MAC_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Set_MAC_GroupBox
            // 
            this.Set_MAC_GroupBox.Controls.Add(this.Save_Button);
            this.Set_MAC_GroupBox.Controls.Add(this.Select_NIC_ComboBox);
            this.Set_MAC_GroupBox.Controls.Add(this.Select_NIC_Label);
            this.Set_MAC_GroupBox.Controls.Add(this.Restore_the_Default_Button);
            this.Set_MAC_GroupBox.Controls.Add(this.MAC_Add_TextBox);
            this.Set_MAC_GroupBox.Controls.Add(this.MAC_Add_Label);
            this.Set_MAC_GroupBox.Location = new System.Drawing.Point(13, 13);
            this.Set_MAC_GroupBox.Name = "Set_MAC_GroupBox";
            this.Set_MAC_GroupBox.Size = new System.Drawing.Size(440, 100);
            this.Set_MAC_GroupBox.TabIndex = 0;
            this.Set_MAC_GroupBox.TabStop = false;
            this.Set_MAC_GroupBox.Text = "修改 MAC 地址";
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(355, 60);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 5;
            this.Save_Button.Text = "保存设置";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Select_NIC_ComboBox
            // 
            this.Select_NIC_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Select_NIC_ComboBox.FormattingEnabled = true;
            this.Select_NIC_ComboBox.Location = new System.Drawing.Point(129, 61);
            this.Select_NIC_ComboBox.Name = "Select_NIC_ComboBox";
            this.Select_NIC_ComboBox.Size = new System.Drawing.Size(220, 20);
            this.Select_NIC_ComboBox.TabIndex = 4;
            this.Select_NIC_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Select_NIC_ComboBox_SelectedIndexChanged);
            // 
            // Select_NIC_Label
            // 
            this.Select_NIC_Label.AutoSize = true;
            this.Select_NIC_Label.Location = new System.Drawing.Point(13, 65);
            this.Select_NIC_Label.Name = "Select_NIC_Label";
            this.Select_NIC_Label.Size = new System.Drawing.Size(113, 12);
            this.Select_NIC_Label.TabIndex = 3;
            this.Select_NIC_Label.Text = "选择要设置的网卡：";
            // 
            // Restore_the_Default_Button
            // 
            this.Restore_the_Default_Button.Location = new System.Drawing.Point(355, 26);
            this.Restore_the_Default_Button.Name = "Restore_the_Default_Button";
            this.Restore_the_Default_Button.Size = new System.Drawing.Size(75, 23);
            this.Restore_the_Default_Button.TabIndex = 2;
            this.Restore_the_Default_Button.Text = "恢复默认";
            this.Restore_the_Default_Button.UseVisualStyleBackColor = true;
            // 
            // MAC_Add_TextBox
            // 
            this.MAC_Add_TextBox.Location = new System.Drawing.Point(129, 26);
            this.MAC_Add_TextBox.Name = "MAC_Add_TextBox";
            this.MAC_Add_TextBox.Size = new System.Drawing.Size(220, 21);
            this.MAC_Add_TextBox.TabIndex = 1;
            this.MAC_Add_TextBox.TextChanged += new System.EventHandler(this.MAC_Add_TextBox_TextChanged);
            // 
            // MAC_Add_Label
            // 
            this.MAC_Add_Label.AutoSize = true;
            this.MAC_Add_Label.Location = new System.Drawing.Point(13, 31);
            this.MAC_Add_Label.Name = "MAC_Add_Label";
            this.MAC_Add_Label.Size = new System.Drawing.Size(107, 12);
            this.MAC_Add_Label.TabIndex = 0;
            this.MAC_Add_Label.Text = "设置 MAC 地址为：";
            // 
            // Network_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 121);
            this.Controls.Add(this.Set_MAC_GroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Network_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "网络设置";
            this.Load += new System.EventHandler(this.Network_Settings_Load);
            this.Set_MAC_GroupBox.ResumeLayout(false);
            this.Set_MAC_GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Set_MAC_GroupBox;
        private System.Windows.Forms.Label MAC_Add_Label;
        private System.Windows.Forms.TextBox MAC_Add_TextBox;
        private System.Windows.Forms.Button Restore_the_Default_Button;
        private System.Windows.Forms.ComboBox Select_NIC_ComboBox;
        private System.Windows.Forms.Label Select_NIC_Label;
        private System.Windows.Forms.Button Save_Button;
    }
}