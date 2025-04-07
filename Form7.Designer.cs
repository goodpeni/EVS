namespace E_Voting_System
{
    partial class Form7
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
            btnLogout = new Button();
            lblAdminName = new Label();
            btnAddCandidate = new Button();
            btnAddStudent = new Button();
            btnStatistics = new Button();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(689, 9);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(99, 34);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdminName.Location = new Point(12, 9);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(109, 21);
            lblAdminName.TabIndex = 6;
            lblAdminName.Text = "Admin Name: ";
            // 
            // btnAddCandidate
            // 
            btnAddCandidate.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnAddCandidate.Location = new Point(298, 202);
            btnAddCandidate.Name = "btnAddCandidate";
            btnAddCandidate.Size = new Size(218, 66);
            btnAddCandidate.TabIndex = 5;
            btnAddCandidate.Text = "Add Candidate";
            btnAddCandidate.UseVisualStyleBackColor = true;
            btnAddCandidate.Click += btnAddCandidate_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnAddStudent.Location = new Point(298, 130);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(218, 66);
            btnAddStudent.TabIndex = 4;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnStatistics.Location = new Point(298, 274);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(218, 66);
            btnStatistics.TabIndex = 8;
            btnStatistics.Text = "Statistics";
            btnStatistics.UseVisualStyleBackColor = true;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStatistics);
            Controls.Add(btnLogout);
            Controls.Add(lblAdminName);
            Controls.Add(btnAddCandidate);
            Controls.Add(btnAddStudent);
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Interface";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private Label lblAdminName;
        private Button btnAddCandidate;
        private Button btnAddStudent;
        private Button btnStatistics;
    }
}