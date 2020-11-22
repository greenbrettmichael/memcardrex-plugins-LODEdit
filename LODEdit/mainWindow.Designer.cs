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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.party1 = new System.Windows.Forms.ListBox();
            this.party2 = new System.Windows.Forms.ListBox();
            this.party3 = new System.Windows.Forms.ListBox();
            this.hits = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.addition = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.sp = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.mp = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.dartMaxHP = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.hp = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.dexp = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.dlvl = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.exp = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lvl = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.character = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.goldNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dartMaxHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(5, 370);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 99;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(86, 370);
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
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "Party 1:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(83, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 105;
            this.label3.Text = "Party 2:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(157, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 106;
            this.label4.Text = "Party 3:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // party1
            // 
            this.party1.FormattingEnabled = true;
            this.party1.Items.AddRange(new object[] {
            "None",
            "Dart",
            "Lavitz",
            "Shana",
            "Rose",
            "Haschel",
            "Albert",
            "Meru",
            "Kongol",
            "Miranda"});
            this.party1.Location = new System.Drawing.Point(15, 79);
            this.party1.Name = "party1";
            this.party1.Size = new System.Drawing.Size(65, 56);
            this.party1.TabIndex = 107;
            // 
            // party2
            // 
            this.party2.FormattingEnabled = true;
            this.party2.Items.AddRange(new object[] {
            "None",
            "Dart",
            "Lavitz",
            "Shana",
            "Rose",
            "Haschel",
            "Albert",
            "Meru",
            "Kongol",
            "Miranda"});
            this.party2.Location = new System.Drawing.Point(86, 79);
            this.party2.Name = "party2";
            this.party2.Size = new System.Drawing.Size(65, 56);
            this.party2.TabIndex = 108;
            // 
            // party3
            // 
            this.party3.FormattingEnabled = true;
            this.party3.Items.AddRange(new object[] {
            "None",
            "Dart",
            "Lavitz",
            "Shana",
            "Rose",
            "Haschel",
            "Albert",
            "Meru",
            "Kongol",
            "Miranda"});
            this.party3.Location = new System.Drawing.Point(157, 79);
            this.party3.Name = "party3";
            this.party3.Size = new System.Drawing.Size(65, 56);
            this.party3.TabIndex = 109;
            // 
            // hits
            // 
            this.hits.Location = new System.Drawing.Point(512, 139);
            this.hits.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.hits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hits.Name = "hits";
            this.hits.Size = new System.Drawing.Size(72, 20);
            this.hits.TabIndex = 140;
            this.hits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(438, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 139;
            this.label14.Text = "Hits:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addition
            // 
            this.addition.FormattingEnabled = true;
            this.addition.Items.AddRange(new object[] {
            "Double Slash",
            "Volcano",
            "Burning Rush",
            "Crush Dance",
            "Madness Hero",
            "Moon Strike",
            "Blazing Dynamo"});
            this.addition.Location = new System.Drawing.Point(312, 139);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(121, 21);
            this.addition.TabIndex = 138;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(241, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 137;
            this.label13.Text = "Addition:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sp
            // 
            this.sp.Location = new System.Drawing.Point(513, 84);
            this.sp.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.sp.Name = "sp";
            this.sp.Size = new System.Drawing.Size(72, 20);
            this.sp.TabIndex = 136;
            this.sp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(439, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 135;
            this.label12.Text = "SP:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mp
            // 
            this.mp.Location = new System.Drawing.Point(513, 61);
            this.mp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mp.Name = "mp";
            this.mp.Size = new System.Drawing.Size(72, 20);
            this.mp.TabIndex = 134;
            this.mp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(439, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 133;
            this.label11.Text = "MP:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dartMaxHP
            // 
            this.dartMaxHP.Location = new System.Drawing.Point(109, 145);
            this.dartMaxHP.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.dartMaxHP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dartMaxHP.Name = "dartMaxHP";
            this.dartMaxHP.Size = new System.Drawing.Size(72, 20);
            this.dartMaxHP.TabIndex = 132;
            this.dartMaxHP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(12, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 131;
            this.label10.Text = "Dart Max HP:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hp
            // 
            this.hp.Location = new System.Drawing.Point(512, 37);
            this.hp.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.hp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(72, 20);
            this.hp.TabIndex = 130;
            this.hp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(438, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 129;
            this.label9.Text = "HP:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dexp
            // 
            this.dexp.Location = new System.Drawing.Point(315, 109);
            this.dexp.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.dexp.Name = "dexp";
            this.dexp.Size = new System.Drawing.Size(118, 20);
            this.dexp.TabIndex = 128;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(241, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 127;
            this.label8.Text = "D Exp:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dlvl
            // 
            this.dlvl.Location = new System.Drawing.Point(315, 86);
            this.dlvl.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.dlvl.Name = "dlvl";
            this.dlvl.Size = new System.Drawing.Size(36, 20);
            this.dlvl.TabIndex = 126;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(241, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 125;
            this.label7.Text = "D Lv:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(315, 61);
            this.exp.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(118, 20);
            this.exp.TabIndex = 124;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(241, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 123;
            this.label6.Text = "Exp:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvl
            // 
            this.lvl.Location = new System.Drawing.Point(315, 38);
            this.lvl.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.lvl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lvl.Name = "lvl";
            this.lvl.Size = new System.Drawing.Size(36, 20);
            this.lvl.TabIndex = 122;
            this.lvl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(241, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 121;
            this.label5.Text = "Lv:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(241, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 141;
            this.label15.Text = "Character:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // character
            // 
            this.character.FormattingEnabled = true;
            this.character.Items.AddRange(new object[] {
            "Dart",
            "Lavitz",
            "Shana",
            "Rose",
            "Haschel",
            "Albert",
            "Meru",
            "Kongol",
            "Miranda"});
            this.character.Location = new System.Drawing.Point(315, 6);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(269, 21);
            this.character.TabIndex = 142;
            this.character.SelectedIndexChanged += new System.EventHandler(this.character_SelectedIndexChanged);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 433);
            this.Controls.Add(this.character);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.hits);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.sp);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.mp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dartMaxHP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.hp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dexp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dlvl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lvl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.party3);
            this.Controls.Add(this.party2);
            this.Controls.Add(this.party1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
            ((System.ComponentModel.ISupportInitialize)(this.hits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dartMaxHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox party1;
        private System.Windows.Forms.ListBox party2;
        private System.Windows.Forms.ListBox party3;
        private System.Windows.Forms.NumericUpDown hits;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox addition;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown sp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown mp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown dartMaxHP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown hp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown dexp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown dlvl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown exp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown lvl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox character;
    }
}