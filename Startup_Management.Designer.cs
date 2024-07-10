namespace Windows_Tools
{
    partial class Startup_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startup_Management));
            this.Startup_DataGridView = new System.Windows.Forms.DataGridView();
            this.Program_Icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.Program_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Program_Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Program_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Illustrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enable_Eutton = new System.Windows.Forms.Button();
            this.Open_path_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Flushed_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Startup_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Startup_DataGridView
            // 
            this.Startup_DataGridView.AllowUserToAddRows = false;
            this.Startup_DataGridView.AllowUserToOrderColumns = true;
            this.Startup_DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Startup_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Startup_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Program_Icon,
            this.Program_Name,
            this.Program_Path,
            this.State,
            this.Program_info,
            this.Illustrate});
            this.Startup_DataGridView.Location = new System.Drawing.Point(13, 13);
            this.Startup_DataGridView.Name = "Startup_DataGridView";
            this.Startup_DataGridView.ReadOnly = true;
            this.Startup_DataGridView.RowTemplate.Height = 23;
            this.Startup_DataGridView.Size = new System.Drawing.Size(700, 435);
            this.Startup_DataGridView.TabIndex = 0;
            // 
            // Program_Icon
            // 
            this.Program_Icon.HeaderText = "程序图标";
            this.Program_Icon.Name = "Program_Icon";
            this.Program_Icon.ReadOnly = true;
            this.Program_Icon.Width = 60;
            // 
            // Program_Name
            // 
            this.Program_Name.HeaderText = "程序名称";
            this.Program_Name.Name = "Program_Name";
            this.Program_Name.ReadOnly = true;
            this.Program_Name.Width = 150;
            // 
            // Program_Path
            // 
            this.Program_Path.HeaderText = "程序路径";
            this.Program_Path.Name = "Program_Path";
            this.Program_Path.ReadOnly = true;
            // 
            // State
            // 
            this.State.HeaderText = "当前状态";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // Program_info
            // 
            this.Program_info.HeaderText = "类型";
            this.Program_info.Name = "Program_info";
            this.Program_info.ReadOnly = true;
            this.Program_info.Width = 70;
            // 
            // Illustrate
            // 
            this.Illustrate.HeaderText = "说明";
            this.Illustrate.Name = "Illustrate";
            this.Illustrate.ReadOnly = true;
            this.Illustrate.Width = 175;
            // 
            // Enable_Eutton
            // 
            this.Enable_Eutton.Location = new System.Drawing.Point(13, 454);
            this.Enable_Eutton.Name = "Enable_Eutton";
            this.Enable_Eutton.Size = new System.Drawing.Size(170, 35);
            this.Enable_Eutton.TabIndex = 1;
            this.Enable_Eutton.Text = "关闭启动项";
            this.Enable_Eutton.UseVisualStyleBackColor = true;
            // 
            // Open_path_Button
            // 
            this.Open_path_Button.Location = new System.Drawing.Point(541, 454);
            this.Open_path_Button.Name = "Open_path_Button";
            this.Open_path_Button.Size = new System.Drawing.Size(170, 35);
            this.Open_path_Button.TabIndex = 2;
            this.Open_path_Button.Text = "打开文件位置";
            this.Open_path_Button.UseVisualStyleBackColor = true;
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(189, 454);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(170, 35);
            this.Delete_Button.TabIndex = 3;
            this.Delete_Button.Text = "删除启动项";
            this.Delete_Button.UseVisualStyleBackColor = true;
            // 
            // Flushed_Button
            // 
            this.Flushed_Button.Location = new System.Drawing.Point(365, 454);
            this.Flushed_Button.Name = "Flushed_Button";
            this.Flushed_Button.Size = new System.Drawing.Size(170, 35);
            this.Flushed_Button.TabIndex = 4;
            this.Flushed_Button.Text = "刷新列表";
            this.Flushed_Button.UseVisualStyleBackColor = true;
            // 
            // Startup_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 501);
            this.Controls.Add(this.Flushed_Button);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Open_path_Button);
            this.Controls.Add(this.Enable_Eutton);
            this.Controls.Add(this.Startup_DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Startup_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "启动项管理";
            this.Load += new System.EventHandler(this.Startup_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Startup_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Startup_DataGridView;
        private System.Windows.Forms.Button Enable_Eutton;
        private System.Windows.Forms.Button Open_path_Button;
        private System.Windows.Forms.DataGridViewImageColumn Program_Icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program_Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn Illustrate;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Flushed_Button;
    }
}