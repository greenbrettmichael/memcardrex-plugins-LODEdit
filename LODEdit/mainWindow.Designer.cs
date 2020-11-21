namespace LODEdit
{
    partial class mainWindow
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.goldNumeric = new System.Windows.Forms.NumericUpDown();
            this.goldLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.goldNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(5, 35);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 99;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(87, 35);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // goldNumeric
            // 
            this.goldNumeric.Location = new System.Drawing.Point(86, 7);
            this.goldNumeric.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.goldNumeric.Name = "goldNumeric";
            this.goldNumeric.Size = new System.Drawing.Size(76, 20);
            this.goldNumeric.TabIndex = 9;
            // 
            // goldLabel
            // 
            this.goldLabel.Location = new System.Drawing.Point(12, 9);
            this.goldLabel.Name = "goldLabel";
            this.goldLabel.Size = new System.Drawing.Size(68, 13);
            this.goldLabel.TabIndex = 13;
            this.goldLabel.Text = "Gold:";
            this.goldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 65);
            this.Controls.Add(this.goldLabel);
            this.Controls.Add(this.goldNumeric);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "mainWindow";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.mainWindow_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.goldNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown goldNumeric;
        private System.Windows.Forms.Label goldLabel;
    }
}