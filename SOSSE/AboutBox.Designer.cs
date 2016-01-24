namespace SOSSE
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.okButton = new System.Windows.Forms.Button();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.creditLabel = new System.Windows.Forms.Label();
            this.creditLabel2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(123, 158);
            this.okButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(150, 33);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            // 
            // labelCopyright
            // 
            this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCopyright.Location = new System.Drawing.Point(12, 76);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(12, 0, 6, 0);
            this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 33);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(378, 33);
            this.labelCopyright.TabIndex = 21;
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVersion
            // 
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.Location = new System.Drawing.Point(12, 38);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(12, 0, 6, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 33);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(378, 33);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProductName
            // 
            this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductName.Location = new System.Drawing.Point(12, 0);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(12, 0, 6, 0);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 33);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(378, 33);
            this.labelProductName.TabIndex = 19;
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.creditLabel2, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.creditLabel, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.labelProductName, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelVersion, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelCopyright, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.okButton, 0, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(18, 17);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23069F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.2307F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.2307F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23108F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07684F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(396, 237);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // creditLabel
            // 
            this.creditLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creditLabel.Location = new System.Drawing.Point(12, 114);
            this.creditLabel.Margin = new System.Windows.Forms.Padding(12, 0, 6, 0);
            this.creditLabel.MaximumSize = new System.Drawing.Size(0, 33);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(378, 33);
            this.creditLabel.TabIndex = 25;
            this.creditLabel.Text = "Credit to barubary for dsdecmp";
            this.creditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creditLabel2
            // 
            this.creditLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creditLabel2.Location = new System.Drawing.Point(12, 197);
            this.creditLabel2.Margin = new System.Windows.Forms.Padding(12, 0, 6, 0);
            this.creditLabel2.MaximumSize = new System.Drawing.Size(0, 33);
            this.creditLabel2.Name = "creditLabel2";
            this.creditLabel2.Size = new System.Drawing.Size(378, 33);
            this.creditLabel2.TabIndex = 26;
            this.creditLabel2.Text = "Credit to Alex193a for EUR fix";
            this.creditLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutBox
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 271);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.Label creditLabel2;

    }
}
