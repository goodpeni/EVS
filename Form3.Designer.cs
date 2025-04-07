namespace E_Voting_System
{
    partial class Form3
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
            lblPassword = new Label();
            lblAdminID = new Label();
            btnLogin = new Button();
            btnGoBack = new Button();
            chkShowPass = new CheckBox();
            lblLogin = new Label();
            txtAdminPass = new TextBox();
            txtAdminID = new TextBox();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 14.25F);
            lblPassword.Location = new Point(142, 197);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(95, 25);
            lblPassword.TabIndex = 15;
            lblPassword.Text = "Password:";
            // 
            // lblAdminID
            // 
            lblAdminID.AutoSize = true;
            lblAdminID.Font = new Font("Segoe UI", 14.25F);
            lblAdminID.Location = new Point(142, 140);
            lblAdminID.Name = "lblAdminID";
            lblAdminID.Size = new Size(94, 25);
            lblAdminID.TabIndex = 14;
            lblAdminID.Text = "Admin ID:";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 14.25F);
            btnLogin.Location = new Point(463, 332);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(122, 45);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnGoBack
            // 
            btnGoBack.Font = new Font("Segoe UI", 14.25F);
            btnGoBack.Location = new Point(213, 332);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(122, 45);
            btnGoBack.TabIndex = 12;
            btnGoBack.Text = "Go Back";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.Font = new Font("Segoe UI", 14.25F);
            chkShowPass.Location = new Point(425, 253);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(160, 29);
            chkShowPass.TabIndex = 11;
            chkShowPass.Text = "show password";
            chkShowPass.UseVisualStyleBackColor = true;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(268, 22);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(226, 79);
            lblLogin.TabIndex = 10;
            lblLogin.Text = "LOGIN";
            // 
            // txtAdminPass
            // 
            txtAdminPass.Font = new Font("Segoe UI", 14.25F);
            txtAdminPass.Location = new Point(313, 194);
            txtAdminPass.Name = "txtAdminPass";
            txtAdminPass.PasswordChar = '*';
            txtAdminPass.Size = new Size(272, 33);
            txtAdminPass.TabIndex = 9;
            // 
            // txtAdminID
            // 
            txtAdminID.Font = new Font("Segoe UI", 14.25F);
            txtAdminID.Location = new Point(313, 132);
            txtAdminID.Name = "txtAdminID";
            txtAdminID.Size = new Size(272, 33);
            txtAdminID.TabIndex = 8;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPassword);
            Controls.Add(lblAdminID);
            Controls.Add(btnLogin);
            Controls.Add(btnGoBack);
            Controls.Add(chkShowPass);
            Controls.Add(lblLogin);
            Controls.Add(txtAdminPass);
            Controls.Add(txtAdminID);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPassword;
        private Label lblAdminID;
        private Button btnLogin;
        private Button btnGoBack;
        private CheckBox chkShowPass;
        private Label lblLogin;
        private TextBox txtAdminPass;
        private TextBox txtAdminID;
    }
}