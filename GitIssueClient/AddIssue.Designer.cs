namespace GitIssueClient
{
    partial class AddIssue
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
            textBoxTitle = new TextBox();
            textBoxDescription = new TextBox();
            lblTitle = new Label();
            lblDescription = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(12, 27);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(205, 23);
            textBoxTitle.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(12, 71);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(205, 23);
            textBoxDescription.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(56, 15);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Issue title";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(12, 53);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(95, 15);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Issue description";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 100);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(205, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add issue";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddIssue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 144);
            Controls.Add(btnAdd);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxTitle);
            Name = "AddIssue";
            Text = "AddIssueForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTitle;
        private TextBox textBoxDescription;
        private Label lblTitle;
        private Label lblDescription;
        private Button btnAdd;
    }
}