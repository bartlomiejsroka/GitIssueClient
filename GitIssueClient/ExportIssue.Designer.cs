namespace GitIssueClient
{
    partial class ExportIssue
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
            textBoxPath = new TextBox();
            lbl = new Label();
            btnPath = new Button();
            btnExport = new Button();
            SuspendLayout();
            // 
            // textBoxPath
            // 
            textBoxPath.Location = new Point(12, 27);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.ReadOnly = true;
            textBoxPath.Size = new Size(260, 23);
            textBoxPath.TabIndex = 0;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(12, 9);
            lbl.Name = "lbl";
            lbl.Size = new Size(34, 15);
            lbl.TabIndex = 1;
            lbl.Text = "Path:";
            // 
            // btnPath
            // 
            btnPath.Location = new Point(12, 56);
            btnPath.Name = "btnPath";
            btnPath.Size = new Size(260, 23);
            btnPath.TabIndex = 2;
            btnPath.Text = "Select folder:";
            btnPath.UseVisualStyleBackColor = true;
            btnPath.Click += btnPath_Click;
            // 
            // btnExport
            // 
            btnExport.Enabled = false;
            btnExport.Location = new Point(12, 102);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(260, 23);
            btnExport.TabIndex = 3;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // ExportIssue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 174);
            Controls.Add(btnExport);
            Controls.Add(btnPath);
            Controls.Add(lbl);
            Controls.Add(textBoxPath);
            Name = "ExportIssue";
            Text = "IssueExport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPath;
        private Label lbl;
        private Button btnPath;
        private Button btnExport;
    }
}