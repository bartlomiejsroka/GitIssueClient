namespace GitIssueClient
{
    partial class EditIssue
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
            btnUpdate = new Button();
            lblDescription = new Label();
            lblTitle = new Label();
            textBoxDescription = new TextBox();
            textBoxTitle = new TextBox();
            label1 = new Label();
            textBoxIssueNumber = new TextBox();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 144);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(205, 23);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update  issue";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(12, 97);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(122, 15);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "New issue description";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 53);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(83, 15);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "New issue title";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(12, 115);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(205, 23);
            textBoxDescription.TabIndex = 6;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(12, 71);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(205, 23);
            textBoxTitle.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 10;
            label1.Text = "Issue number";
            // 
            // textBoxIssueNumber
            // 
            textBoxIssueNumber.Location = new Point(12, 27);
            textBoxIssueNumber.Name = "textBoxIssueNumber";
            textBoxIssueNumber.Size = new Size(205, 23);
            textBoxIssueNumber.TabIndex = 11;
            // 
            // EditIssue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 178);
            Controls.Add(textBoxIssueNumber);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxTitle);
            Name = "EditIssue";
            Text = "EditIssue";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Label lblDescription;
        private Label lblTitle;
        private TextBox textBoxDescription;
        private TextBox textBoxTitle;
        private Label label1;
        private TextBox textBoxIssueNumber;
    }
}