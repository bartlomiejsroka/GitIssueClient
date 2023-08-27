namespace GitIssueClient
{
    partial class GitLabToken
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
            textBoxProjectId = new TextBox();
            lblRepoName = new Label();
            btnImportIssue = new Button();
            btnExportAllIssues = new Button();
            btnCloseIssue = new Button();
            btnModifyIssue = new Button();
            btnAddNewIssue = new Button();
            btnCheck = new Button();
            textBoxToken = new TextBox();
            lblAcessToken = new Label();
            SuspendLayout();
            // 
            // textBoxProjectId
            // 
            textBoxProjectId.Location = new Point(11, 71);
            textBoxProjectId.Name = "textBoxProjectId";
            textBoxProjectId.Size = new Size(303, 23);
            textBoxProjectId.TabIndex = 26;
            // 
            // lblRepoName
            // 
            lblRepoName.AutoSize = true;
            lblRepoName.Location = new Point(11, 53);
            lblRepoName.Name = "lblRepoName";
            lblRepoName.Size = new Size(57, 15);
            lblRepoName.TabIndex = 25;
            lblRepoName.Text = "Project id";
            // 
            // btnImportIssue
            // 
            btnImportIssue.Enabled = false;
            btnImportIssue.Location = new Point(12, 294);
            btnImportIssue.Name = "btnImportIssue";
            btnImportIssue.Size = new Size(303, 23);
            btnImportIssue.TabIndex = 21;
            btnImportIssue.Text = "Import issue from file";
            btnImportIssue.UseVisualStyleBackColor = true;
            btnImportIssue.Click += btnImportIssue_Click;
            // 
            // btnExportAllIssues
            // 
            btnExportAllIssues.Enabled = false;
            btnExportAllIssues.Location = new Point(12, 265);
            btnExportAllIssues.Name = "btnExportAllIssues";
            btnExportAllIssues.Size = new Size(303, 23);
            btnExportAllIssues.TabIndex = 20;
            btnExportAllIssues.Text = "Export all issues";
            btnExportAllIssues.UseVisualStyleBackColor = true;
            btnExportAllIssues.Click += btnExportAllIssues_Click;
            // 
            // btnCloseIssue
            // 
            btnCloseIssue.Enabled = false;
            btnCloseIssue.Location = new Point(11, 236);
            btnCloseIssue.Name = "btnCloseIssue";
            btnCloseIssue.Size = new Size(303, 23);
            btnCloseIssue.TabIndex = 19;
            btnCloseIssue.Text = "Close issue";
            btnCloseIssue.UseVisualStyleBackColor = true;
            btnCloseIssue.Click += btnCloseIssue_Click;
            // 
            // btnModifyIssue
            // 
            btnModifyIssue.Enabled = false;
            btnModifyIssue.Location = new Point(12, 207);
            btnModifyIssue.Name = "btnModifyIssue";
            btnModifyIssue.Size = new Size(303, 23);
            btnModifyIssue.TabIndex = 18;
            btnModifyIssue.Text = "Modify issue";
            btnModifyIssue.UseVisualStyleBackColor = true;
            btnModifyIssue.Click += btnModifyIssue_Click;
            // 
            // btnAddNewIssue
            // 
            btnAddNewIssue.Enabled = false;
            btnAddNewIssue.Location = new Point(12, 178);
            btnAddNewIssue.Name = "btnAddNewIssue";
            btnAddNewIssue.Size = new Size(303, 23);
            btnAddNewIssue.TabIndex = 17;
            btnAddNewIssue.Text = "Add new issue";
            btnAddNewIssue.UseVisualStyleBackColor = true;
            btnAddNewIssue.Click += btnAddNewIssue_Click;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(12, 100);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(303, 23);
            btnCheck.TabIndex = 16;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // textBoxToken
            // 
            textBoxToken.Location = new Point(12, 27);
            textBoxToken.Name = "textBoxToken";
            textBoxToken.Size = new Size(303, 23);
            textBoxToken.TabIndex = 15;
            // 
            // lblAcessToken
            // 
            lblAcessToken.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAcessToken.AutoSize = true;
            lblAcessToken.Location = new Point(12, 9);
            lblAcessToken.Name = "lblAcessToken";
            lblAcessToken.Size = new Size(131, 15);
            lblAcessToken.TabIndex = 14;
            lblAcessToken.Text = "Enter your access token";
            // 
            // GitLabToken
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 324);
            Controls.Add(textBoxProjectId);
            Controls.Add(lblRepoName);
            Controls.Add(btnImportIssue);
            Controls.Add(btnExportAllIssues);
            Controls.Add(btnCloseIssue);
            Controls.Add(btnModifyIssue);
            Controls.Add(btnAddNewIssue);
            Controls.Add(btnCheck);
            Controls.Add(textBoxToken);
            Controls.Add(lblAcessToken);
            Name = "GitLabToken";
            Text = "GitLabToken";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProjectId;
        private Label lblRepoName;
        private Button btnImportIssue;
        private Button btnExportAllIssues;
        private Button btnCloseIssue;
        private Button btnModifyIssue;
        private Button btnAddNewIssue;
        private Button btnCheck;
        private TextBox textBoxToken;
        private Label lblAcessToken;
    }
}