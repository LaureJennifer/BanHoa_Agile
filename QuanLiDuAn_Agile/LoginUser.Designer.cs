namespace QuanLiDuAn_Agile
{
    partial class LoginUser
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
            lb_acc = new Label();
            lb_pass = new Label();
            txt_acc = new TextBox();
            txt_pass = new TextBox();
            btn_Login = new Button();
            btn_Back = new Button();
            lbl_ForgotPass = new LinkLabel();
            btn_register = new Button();
            SuspendLayout();
            // 
            // lb_acc
            // 
            lb_acc.AutoSize = true;
            lb_acc.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb_acc.Location = new Point(26, 25);
            lb_acc.Name = "lb_acc";
            lb_acc.Size = new Size(96, 30);
            lb_acc.TabIndex = 0;
            lb_acc.Text = "Account ";
            // 
            // lb_pass
            // 
            lb_pass.AutoSize = true;
            lb_pass.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lb_pass.Location = new Point(24, 89);
            lb_pass.Name = "lb_pass";
            lb_pass.Size = new Size(99, 30);
            lb_pass.TabIndex = 1;
            lb_pass.Text = "Password";
            // 
            // txt_acc
            // 
            txt_acc.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_acc.Location = new Point(154, 20);
            txt_acc.Name = "txt_acc";
            txt_acc.Size = new Size(373, 35);
            txt_acc.TabIndex = 2;
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.Location = new Point(154, 87);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(373, 35);
            txt_pass.TabIndex = 3;
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Login.Location = new Point(36, 199);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(150, 35);
            btn_Login.TabIndex = 4;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            // 
            // btn_Back
            // 
            btn_Back.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Back.Location = new Point(377, 199);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(150, 35);
            btn_Back.TabIndex = 5;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = true;
            // 
            // lbl_ForgotPass
            // 
            lbl_ForgotPass.AutoSize = true;
            lbl_ForgotPass.Location = new Point(221, 152);
            lbl_ForgotPass.Name = "lbl_ForgotPass";
            lbl_ForgotPass.Size = new Size(122, 15);
            lbl_ForgotPass.TabIndex = 6;
            lbl_ForgotPass.TabStop = true;
            lbl_ForgotPass.Text = "Forgot your password";
            // 
            // btn_register
            // 
            btn_register.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_register.Location = new Point(204, 199);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(150, 35);
            btn_register.TabIndex = 7;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            // 
            // LoginUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 269);
            Controls.Add(btn_register);
            Controls.Add(lbl_ForgotPass);
            Controls.Add(btn_Back);
            Controls.Add(btn_Login);
            Controls.Add(txt_pass);
            Controls.Add(txt_acc);
            Controls.Add(lb_pass);
            Controls.Add(lb_acc);
            Name = "LoginUser";
            Text = "Login User";
            Load += LoginUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_acc;
        private Label lb_pass;
        private TextBox txt_acc;
        private TextBox txt_pass;
        private Button btn_Login;
        private Button btn_Back;
        private LinkLabel lbl_ForgotPass;
        private Button btn_register;
    }
}