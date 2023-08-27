namespace GitIssueClient
{
    partial class ImportIssues
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
            btnImport = new Button();
            btnPath = new Button();
            lbl = new Label();
            textBoxPath = new TextBox();
            SuspendLayout();
            // 
            // btnImport
            // 
            btnImport.Enabled = false;
            btnImport.Location = new Point(12, 102);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(260, 23);
            btnImport.TabIndex = 7;
            btnImport.Text = "Import Isses";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnPath
            // 
            btnPath.Location = new Point(12, 56);
            btnPath.Name = "btnPath";
            btnPath.Size = new Size(260, 23);
            btnPath.TabIndex = 6;
            btnPath.Text = "Select file:";
            btnPath.UseVisualStyleBackColor = true;
            btnPath.Click += btnPath_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(12, 9);
            lbl.Name = "lbl";
            lbl.Size = new Size(34, 15);
            lbl.TabIndex = 5;
            lbl.Text = "Path:";
            // 
            // textBoxPath
            // 
            textBoxPath.Location = new Point(12, 27);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.ReadOnly = true;
            textBoxPath.Size = new Size(260, 23);
            textBoxPath.TabIndex = 4;
            // 
            // ImportIssues
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 160);
            Controls.Add(btnImport);
            Controls.Add(btnPath);
            Controls.Add(lbl);
            Controls.Add(textBoxPath);
            Name = "ImportIssues";
            Text = "ImportIssues";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImport;
        private Button btnPath;
        private Label lbl;
        private TextBox textBoxPath;
    }
}