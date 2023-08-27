namespace GitIssueClient
{
    partial class CloseIssue
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
            textBoxIssueNumber = new TextBox();
            label1 = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // textBoxIssueNumber
            // 
            textBoxIssueNumber.Location = new Point(12, 27);
            textBoxIssueNumber.Name = "textBoxIssueNumber";
            textBoxIssueNumber.Size = new Size(205, 23);
            textBoxIssueNumber.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 13;
            label1.Text = "Issue number";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(12, 56);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(205, 23);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close issue";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // CloseIssue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 126);
            Controls.Add(btnClose);
            Controls.Add(textBoxIssueNumber);
            Controls.Add(label1);
            Name = "CloseIssue";
            Text = "CloseIssue";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIssueNumber;
        private Label label1;
        private Button btnClose;
    }
}