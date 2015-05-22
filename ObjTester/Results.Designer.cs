namespace ObjTester
{
    partial class Results
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
            this.backButton = new System.Windows.Forms.Button();
            this.resultsList = new System.Windows.Forms.ListBox();
            this.openUrl = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(145, 206);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(121, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Go Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // resultsList
            // 
            this.resultsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultsList.FormattingEnabled = true;
            this.resultsList.Location = new System.Drawing.Point(13, 27);
            this.resultsList.Name = "resultsList";
            this.resultsList.Size = new System.Drawing.Size(253, 169);
            this.resultsList.TabIndex = 1;
            this.resultsList.SelectedIndexChanged += new System.EventHandler(this.resultsList_SelectedIndexChanged);
            // 
            // openUrl
            // 
            this.openUrl.Enabled = false;
            this.openUrl.Location = new System.Drawing.Point(12, 206);
            this.openUrl.Name = "openUrl";
            this.openUrl.Size = new System.Drawing.Size(121, 23);
            this.openUrl.TabIndex = 2;
            this.openUrl.Text = "Open URL";
            this.openUrl.UseVisualStyleBackColor = true;
            this.openUrl.Click += new System.EventHandler(this.openUrl_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(10, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(254, 15);
            this.title.TabIndex = 3;
            this.title.Text = "Select a URL to enable the Open URL button.";
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 246);
            this.Controls.Add(this.title);
            this.Controls.Add(this.openUrl);
            this.Controls.Add(this.resultsList);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Results";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListBox resultsList;
        private System.Windows.Forms.Button openUrl;
        private System.Windows.Forms.Label title;
    }
}