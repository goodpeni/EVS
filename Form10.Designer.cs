namespace E_Voting_System
{
    partial class Form10
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
            SuspendLayout();
            // 
            // btnGoBack
            // 
            btnGoBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGoBack.Location = new Point(689, 12);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(99, 34);
            btnGoBack.TabIndex = 12;
            btnGoBack.Text = "Go Back";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGoBack);
            Name = "Form10";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Statistics";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGoBack;
    }
}