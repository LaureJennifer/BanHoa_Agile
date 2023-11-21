namespace QuanLiDuAn_Agile
{
    partial class ChangeLogin
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
            btn_Admin = new Button();
            btn_User = new Button();
            SuspendLayout();
            // 
            // btn_Admin
            // 
            btn_Admin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Admin.Location = new Point(71, 55);
            btn_Admin.Name = "btn_Admin";
            btn_Admin.Size = new Size(150, 60);
            btn_Admin.TabIndex = 0;
            btn_Admin.Text = "Admin";
            btn_Admin.UseVisualStyleBackColor = true;
            btn_Admin.Click += btn_Admin_Click;
            // 
            // btn_User
            // 
            btn_User.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_User.Location = new Point(322, 55);
            btn_User.Name = "btn_User";
            btn_User.Size = new Size(150, 60);
            btn_User.TabIndex = 1;
            btn_User.Text = "Khách";
            btn_User.UseVisualStyleBackColor = true;
            btn_User.Click += btn_User_Click;
            // 
            // ChangeLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 182);
            Controls.Add(btn_User);
            Controls.Add(btn_Admin);
            Name = "ChangeLogin";
            Text = "ChangeLogin";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Admin;
        private Button btn_User;
    }
}