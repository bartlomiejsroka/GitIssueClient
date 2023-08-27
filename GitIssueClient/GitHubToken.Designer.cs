namespace GitIssueClient
{
    partial class GitHubToken
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
            lblAcessToken = new Label();
            textBoxToken = new TextBox();
            btnCheck = new Button();
            btnAddNewIssue = new Button();
            btnModifyIssue = new Button();
            btnCloseIssue = new Button();
            btnExportAllIssues = new Button();
            btnImportIssue = new Button();
            textBoxRepoName = new TextBox();
            lblRepoName = new Label();
            textBoxUserName = new TextBox();
            lblUserName = new Label();
            SuspendLayout();
            // 
            // lblAcessToken
            // 
            lblAcessToken.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAcessToken.AutoSize = true;
            lblAcessToken.Location = new Point(12, 9);
            lblAcessToken.Name = "lblAcessToken";
            lblAcessToken.Size = new Size(131, 15);
            lblAcessToken.TabIndex = 0;
            lblAcessToken.Text = "Enter your access token";
            // 
            // textBoxToken
            // 
            textBoxToken.Location = new Point(12, 27);
            textBoxToken.Name = "textBoxToken";
            textBoxToken.Size = new Size(303, 23);
            textBoxToken.TabIndex = 1;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(12, 144);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(303, 23);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnAddNewIssue
            // 
            btnAddNewIssue.Enabled = false;
            btnAddNewIssue.Location = new Point(12, 223);
            btnAddNewIssue.Name = "btnAddNewIssue";
            btnAddNewIssue.Size = new Size(303, 23);
            btnAddNewIssue.TabIndex = 3;
            btnAddNewIssue.Text = "Add new issue";
            btnAddNewIssue.UseVisualStyleBackColor = true;
            btnAddNewIssue.Click += btnAddNewIssue_Click;
            // 
            // btnModifyIssue
            // 
            btnModifyIssue.Enabled = false;
            btnModifyIssue.Location = new Point(12, 252);
            btnModifyIssue.Name = "btnModifyIssue";
            btnModifyIssue.Size = new Size(303, 23);
            btnModifyIssue.TabIndex = 4;
            btnModifyIssue.Text = "Modify issue";
            btnModifyIssue.UseVisualStyleBackColor = true;
            btnModifyIssue.Click += btnModifyIssue_Click;
            // 
            // btnCloseIssue
            // 
            btnCloseIssue.Enabled = false;
            btnCloseIssue.Location = new Point(12, 281);
            btnCloseIssue.Name = "btnCloseIssue";
            btnCloseIssue.Size = new Size(303, 23);
            btnCloseIssue.TabIndex = 5;
            btnCloseIssue.Text = "Close issue";
            btnCloseIssue.UseVisualStyleBackColor = true;
            btnCloseIssue.Click += btnCloseIssue_Click;
            // 
            // btnExportAllIssues
            // 
            btnExportAllIssues.Enabled = false;
            btnExportAllIssues.Location = new Point(12, 310);
            btnExportAllIssues.Name = "btnExportAllIssues";
            btnExportAllIssues.Size = new Size(303, 23);
            btnExportAllIssues.TabIndex = 6;
            btnExportAllIssues.Text = "Export all issues";
            btnExportAllIssues.UseVisualStyleBackColor = true;
            btnExportAllIssues.Click += btnExportAllIssues_Click;
            // 
            // btnImportIssue
            // 
            btnImportIssue.Enabled = false;
            btnImportIssue.Location = new Point(12, 339);
            btnImportIssue.Name = "btnImportIssue";
            btnImportIssue.Size = new Size(303, 23);
            btnImportIssue.TabIndex = 7;
            btnImportIssue.Text = "Import issue from file";
            btnImportIssue.UseVisualStyleBackColor = true;
            btnImportIssue.Click += btnImportIssue_Click;
            // 
            // textBoxRepoName
            // 
            textBoxRepoName.Location = new Point(12, 115);
            textBoxRepoName.Name = "textBoxRepoName";
            textBoxRepoName.Size = new Size(303, 23);
            textBoxRepoName.TabIndex = 13;
            // 
            // lblRepoName
            // 
            lblRepoName.AutoSize = true;
            lblRepoName.Location = new Point(12, 97);
            lblRepoName.Name = "lblRepoName";
            lblRepoName.Size = new Size(67, 15);
            lblRepoName.TabIndex = 12;
            lblRepoName.Text = "Repo name";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(12, 71);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(303, 23);
            textBoxUserName.TabIndex = 11;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(12, 53);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(63, 15);
            lblUserName.TabIndex = 10;
            lblUserName.Text = "User name";
            // 
            // GitHubToken
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 374);
            Controls.Add(textBoxRepoName);
            Controls.Add(lblRepoName);
            Controls.Add(textBoxUserName);
            Controls.Add(lblUserName);
            Controls.Add(btnImportIssue);
            Controls.Add(btnExportAllIssues);
            Controls.Add(btnCloseIssue);
            Controls.Add(btnModifyIssue);
            Controls.Add(btnAddNewIssue);
            Controls.Add(btnCheck);
            Controls.Add(textBoxToken);
            Controls.Add(lblAcessToken);
            Name = "GitHubToken";
            Text = "GitHubToken";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAcessToken;
        private TextBox textBoxToken;
        private Button btnCheck;
        private Button btnAddNewIssue;
        private Button btnModifyIssue;
        private Button btnCloseIssue;
        private Button btnExportAllIssues;
        private Button btnImportIssue;
        private TextBox textBoxRepoName;
        private Label lblRepoName;
        private TextBox textBoxUserName;
        private Label lblUserName;
    }
}