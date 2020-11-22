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
            this.label1 = new System.Windows.Forms.Label();
            this.timeHours = new System.Windows.Forms.NumericUpDown();
            this.timeMinutes = new System.Windows.Forms.NumericUpDown();
            this.timeSeconds = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.goldNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(5, 162);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 99;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(86, 162);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // goldNumeric
            // 
            this.goldNumeric.Location = new System.Drawing.Point(88, 7);
            this.goldNumeric.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.goldNumeric.Name = "goldNumeric";
            this.goldNumeric.Size = new System.Drawing.Size(118, 20);
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Time:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeHours
            // 
            this.timeHours.Location = new System.Drawing.Point(86, 33);
            this.timeHours.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.timeHours.Name = "timeHours";
            this.timeHours.Size = new System.Drawing.Size(36, 20);
            this.timeHours.TabIndex = 101;
            // 
            // timeMinutes
            // 
            this.timeMinutes.Location = new System.Drawing.Point(128, 33);
            this.timeMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.timeMinutes.Name = "timeMinutes";
            this.timeMinutes.Size = new System.Drawing.Size(36, 20);
            this.timeMinutes.TabIndex = 102;
            // 
            // timeSeconds
            // 
            this.timeSeconds.Location = new System.Drawing.Point(170, 33);
            this.timeSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.timeSeconds.Name = "timeSeconds";
            this.timeSeconds.Size = new System.Drawing.Size(36, 20);
            this.timeSeconds.TabIndex = 103;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 197);
            this.Controls.Add(this.timeSeconds);
            this.Controls.Add(this.timeMinutes);
            this.Controls.Add(this.timeHours);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.timeHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSeconds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown goldNumeric;
        private System.Windows.Forms.Label goldLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown timeHours;
        private System.Windows.Forms.NumericUpDown timeMinutes;
        private System.Windows.Forms.NumericUpDown timeSeconds;
    }
}