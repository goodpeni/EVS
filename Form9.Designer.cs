namespace E_Voting_System
{
    partial class Form9
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
            btnAdd = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // btnGoBack
            // 
            btnGoBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGoBack.Location = new Point(689, 12);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(99, 34);
            btnGoBack.TabIndex = 11;
            btnGoBack.Text = "Go Back";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14.25F);
            btnAdd.Location = new Point(666, 393);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(122, 45);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 14.25F);
            btnClear.Location = new Point(12, 393);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(122, 45);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGoBack);
            Controls.Add(btnAdd);
            Controls.Add(btnClear);
            Name = "Form9";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Candidate";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGoBack;
        private Button btnAdd;
        private Button btnClear;
    }
}