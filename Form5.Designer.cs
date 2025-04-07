namespace E_Voting_System
{
    partial class Form5
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
            btnGoBack = new Button();
            lblYearLevel = new Label();
            btnLogout = new Button();
            lblStudentName = new Label();
            SuspendLayout();
            // 
            // btnGoBack
            // 
            btnGoBack.Font = new Font("Segoe UI", 14.25F);
            btnGoBack.Location = new Point(666, 393);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(122, 45);
            btnGoBack.TabIndex = 13;
            btnGoBack.Text = "Go Back";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // lblYearLevel
            // 
            lblYearLevel.AutoSize = true;
            lblYearLevel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYearLevel.Location = new Point(12, 42);
            lblYearLevel.Name = "lblYearLevel";
            lblYearLevel.Size = new Size(87, 21);
            lblYearLevel.TabIndex = 16;
            lblYearLevel.Text = "Year Level: ";
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(689, 9);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(99, 34);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentName.Location = new Point(12, 9);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(116, 21);
            lblStudentName.TabIndex = 14;
            lblStudentName.Text = "Student Name: ";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblYearLevel);
            Controls.Add(btnLogout);
            Controls.Add(lblStudentName);
            Controls.Add(btnGoBack);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vote Now";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGoBack;
        private Label lblYearLevel;
        private Button btnLogout;
        private Label lblStudentName;
    }
}