namespace GitIssueClient
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblGitProvider = new Label();
            button1 = new Button();
            btnGitLab = new Button();
            SuspendLayout();
            // 
            // lblGitProvider
            // 
            lblGitProvider.AutoSize = true;
            lblGitProvider.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGitProvider.Location = new Point(292, 21);
            lblGitProvider.Name = "lblGitProvider";
            lblGitProvider.Size = new Size(138, 21);
            lblGitProvider.TabIndex = 0;
            lblGitProvider.Text = "Chose git provider";
            // 
            // button1
            // 
            button1.Location = new Point(257, 89);
            button1.Name = "button1";
            button1.Size = new Size(234, 67);
            button1.TabIndex = 1;
            button1.Text = "GitHub";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGitLab
            // 
            btnGitLab.Location = new Point(257, 183);
            btnGitLab.Name = "btnGitLab";
            btnGitLab.Size = new Size(234, 67);
            btnGitLab.TabIndex = 2;
            btnGitLab.Text = "GitLab";
            btnGitLab.UseVisualStyleBackColor = true;
            btnGitLab.Click += btnGitLab_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGitLab);
            Controls.Add(button1);
            Controls.Add(lblGitProvider);
            Name = "MainWindow";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGitProvider;
        private Button button1;
        private Button btnGitLab;
    }
}