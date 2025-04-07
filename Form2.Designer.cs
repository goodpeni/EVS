namespace E_Voting_System
{
    partial class Form2
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
            txtStudentID = new TextBox();
            txtStudentPass = new TextBox();
            lblLogin = new Label();
            chkShowPass = new CheckBox();
            btnGoBack = new Button();
            btnLogin = new Button();
            lblStudentID = new Label();
            lblPassword = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtStudentID
            // 
            txtStudentID.BackColor = Color.Gainsboro;
            txtStudentID.Font = new Font("Arial", 13.8F);
            txtStudentID.Location = new Point(68, 69);
            txtStudentID.Margin = new Padding(3, 4, 3, 4);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(310, 34);
            txtStudentID.TabIndex = 0;
            // 
            // txtStudentPass
            // 
            txtStudentPass.BackColor = Color.Gainsboro;
            txtStudentPass.Font = new Font("Arial", 13.8F);
            txtStudentPass.Location = new Point(68, 182);
            txtStudentPass.Margin = new Padding(3, 4, 3, 4);
            txtStudentPass.Name = "txtStudentPass";
            txtStudentPass.PasswordChar = '*';
            txtStudentPass.Size = new Size(310, 34);
            txtStudentPass.TabIndex = 1;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Impact", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(326, 43);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(280, 98);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "SIGN IN";
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.Font = new Font("Arial", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            chkShowPass.Location = new Point(144, 229);
            chkShowPass.Margin = new Padding(3, 4, 3, 4);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(147, 24);
            chkShowPass.TabIndex = 3;
            chkShowPass.Text = "show password";
            chkShowPass.UseVisualStyleBackColor = true;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // btnGoBack
            // 
            btnGoBack.BackColor = Color.Maroon;
            btnGoBack.FlatStyle = FlatStyle.Flat;
            btnGoBack.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoBack.ForeColor = Color.White;
            btnGoBack.Location = new Point(68, 272);
            btnGoBack.Margin = new Padding(3, 4, 3, 4);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(153, 60);
            btnGoBack.TabIndex = 4;
            btnGoBack.Text = "Back";
            btnGoBack.UseVisualStyleBackColor = false;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SeaGreen;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(227, 272);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(151, 60);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentID.Location = new Point(68, 39);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(135, 27);
            lblStudentID.TabIndex = 6;
            lblStudentID.Text = "Student ID:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(68, 146);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(129, 27);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblStudentID);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(btnGoBack);
            panel1.Controls.Add(txtStudentID);
            panel1.Controls.Add(chkShowPass);
            panel1.Controls.Add(txtStudentPass);
            panel1.Location = new Point(244, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 377);
            panel1.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = Properties.Resources.Untitled_design__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 577);
            Controls.Add(panel1);
            Controls.Add(lblLogin);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentID;
        private TextBox txtStudentPass;
        private Label lblLogin;
        private CheckBox chkShowPass;
        private Button btnGoBack;
        private Button btnLogin;
        private Label lblStudentID;
        private Label lblPassword;
        private Panel panel1;
    }
}