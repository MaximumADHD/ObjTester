namespace ObjTester
{
    partial class Input
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Input));
            this.inputBox = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.methodSelect = new System.Windows.Forms.ComboBox();
            this.methodTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Enabled = false;
            this.inputBox.Location = new System.Drawing.Point(12, 52);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(95, 20);
            this.inputBox.TabIndex = 1;
            // 
            // go
            // 
            this.go.Enabled = false;
            this.go.Location = new System.Drawing.Point(113, 52);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(20, 20);
            this.go.TabIndex = 4;
            this.go.Text = ">";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.showResults);
            // 
            // methodSelect
            // 
            this.methodSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodSelect.FormattingEnabled = true;
            this.methodSelect.Items.AddRange(new object[] {
            "AssetId",
            "UserId",
            "UserName"});
            this.methodSelect.Location = new System.Drawing.Point(12, 25);
            this.methodSelect.Name = "methodSelect";
            this.methodSelect.Size = new System.Drawing.Size(121, 21);
            this.methodSelect.TabIndex = 5;
            this.methodSelect.SelectedIndexChanged += new System.EventHandler(this.methodSelect_SelectedIndexChanged);
            // 
            // methodTitle
            // 
            this.methodTitle.AutoSize = true;
            this.methodTitle.Location = new System.Drawing.Point(12, 9);
            this.methodTitle.Name = "methodTitle";
            this.methodTitle.Size = new System.Drawing.Size(46, 13);
            this.methodTitle.TabIndex = 0;
            this.methodTitle.Text = "Method:";
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 97);
            this.Controls.Add(this.methodSelect);
            this.Controls.Add(this.go);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.methodTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Input";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obj Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.ComboBox methodSelect;
        private System.Windows.Forms.Label methodTitle;
    }
}

