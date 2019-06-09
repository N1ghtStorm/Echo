﻿namespace Echo
{
    partial class PatientCardForm
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SecondNameTextBox = new System.Windows.Forms.TextBox();
            this.FatherNameTextBox = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSecondNmae = new System.Windows.Forms.Label();
            this.labelFatherName = new System.Windows.Forms.Label();
            this.numericBirthDay = new System.Windows.Forms.NumericUpDown();
            this.numericBirthMounth = new System.Windows.Forms.NumericUpDown();
            this.numericBirthYear = new System.Windows.Forms.NumericUpDown();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelGrowth = new System.Windows.Forms.Label();
            this.GrowthTextBox = new System.Windows.Forms.TextBox();
            this.labelMass = new System.Windows.Forms.Label();
            this.MassTextBox = new System.Windows.Forms.TextBox();
            this.labelRhythm = new System.Windows.Forms.Label();
            this.RhythmTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericBirthDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBirthMounth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBirthYear)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.White;
            this.NameTextBox.Location = new System.Drawing.Point(107, 37);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameTextBox.Size = new System.Drawing.Size(110, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // SecondNameTextBox
            // 
            this.SecondNameTextBox.BackColor = System.Drawing.Color.White;
            this.SecondNameTextBox.Location = new System.Drawing.Point(107, 78);
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            this.SecondNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SecondNameTextBox.Size = new System.Drawing.Size(110, 20);
            this.SecondNameTextBox.TabIndex = 1;
            // 
            // FatherNameTextBox
            // 
            this.FatherNameTextBox.BackColor = System.Drawing.Color.White;
            this.FatherNameTextBox.Location = new System.Drawing.Point(107, 118);
            this.FatherNameTextBox.Name = "FatherNameTextBox";
            this.FatherNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FatherNameTextBox.Size = new System.Drawing.Size(110, 20);
            this.FatherNameTextBox.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelName.Location = new System.Drawing.Point(21, 37);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(80, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Имя Больного";
            // 
            // labelSecondNmae
            // 
            this.labelSecondNmae.AutoSize = true;
            this.labelSecondNmae.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSecondNmae.Location = new System.Drawing.Point(34, 81);
            this.labelSecondNmae.Name = "labelSecondNmae";
            this.labelSecondNmae.Size = new System.Drawing.Size(56, 13);
            this.labelSecondNmae.TabIndex = 4;
            this.labelSecondNmae.Text = "Фамилия";
            // 
            // labelFatherName
            // 
            this.labelFatherName.AutoSize = true;
            this.labelFatherName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFatherName.Location = new System.Drawing.Point(34, 121);
            this.labelFatherName.Name = "labelFatherName";
            this.labelFatherName.Size = new System.Drawing.Size(54, 13);
            this.labelFatherName.TabIndex = 5;
            this.labelFatherName.Text = "Отчество";
            // 
            // numericBirthDay
            // 
            this.numericBirthDay.Location = new System.Drawing.Point(107, 157);
            this.numericBirthDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericBirthDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericBirthDay.Name = "numericBirthDay";
            this.numericBirthDay.Size = new System.Drawing.Size(40, 20);
            this.numericBirthDay.TabIndex = 6;
            this.numericBirthDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericBirthMounth
            // 
            this.numericBirthMounth.Location = new System.Drawing.Point(163, 157);
            this.numericBirthMounth.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericBirthMounth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericBirthMounth.Name = "numericBirthMounth";
            this.numericBirthMounth.Size = new System.Drawing.Size(40, 20);
            this.numericBirthMounth.TabIndex = 7;
            this.numericBirthMounth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericBirthYear
            // 
            this.numericBirthYear.Location = new System.Drawing.Point(222, 157);
            this.numericBirthYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericBirthYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericBirthYear.Name = "numericBirthYear";
            this.numericBirthYear.Size = new System.Drawing.Size(65, 20);
            this.numericBirthYear.TabIndex = 8;
            this.numericBirthYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBirthDate.Location = new System.Drawing.Point(14, 164);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(87, 13);
            this.labelBirthDate.TabIndex = 9;
            this.labelBirthDate.Text = "Дата Рождения";
            // 
            // labelGrowth
            // 
            this.labelGrowth.AutoSize = true;
            this.labelGrowth.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGrowth.Location = new System.Drawing.Point(38, 202);
            this.labelGrowth.Name = "labelGrowth";
            this.labelGrowth.Size = new System.Drawing.Size(58, 13);
            this.labelGrowth.TabIndex = 10;
            this.labelGrowth.Text = "Рост (См.)";
            // 
            // GrowthTextBox
            // 
            this.GrowthTextBox.BackColor = System.Drawing.Color.White;
            this.GrowthTextBox.Location = new System.Drawing.Point(136, 199);
            this.GrowthTextBox.Name = "GrowthTextBox";
            this.GrowthTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GrowthTextBox.Size = new System.Drawing.Size(51, 20);
            this.GrowthTextBox.TabIndex = 11;
            // 
            // labelMass
            // 
            this.labelMass.AutoSize = true;
            this.labelMass.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMass.Location = new System.Drawing.Point(32, 244);
            this.labelMass.Name = "labelMass";
            this.labelMass.Size = new System.Drawing.Size(64, 13);
            this.labelMass.TabIndex = 12;
            this.labelMass.Text = "Масса (Кг.)";
            // 
            // MassTextBox
            // 
            this.MassTextBox.BackColor = System.Drawing.Color.White;
            this.MassTextBox.Location = new System.Drawing.Point(136, 244);
            this.MassTextBox.Name = "MassTextBox";
            this.MassTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MassTextBox.Size = new System.Drawing.Size(51, 20);
            this.MassTextBox.TabIndex = 13;
            // 
            // labelRhythm
            // 
            this.labelRhythm.AutoSize = true;
            this.labelRhythm.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRhythm.Location = new System.Drawing.Point(34, 293);
            this.labelRhythm.Name = "labelRhythm";
            this.labelRhythm.Size = new System.Drawing.Size(85, 13);
            this.labelRhythm.TabIndex = 14;
            this.labelRhythm.Text = "Ритм(Уд./Мин.)";
            // 
            // RhythmTextBox
            // 
            this.RhythmTextBox.BackColor = System.Drawing.Color.White;
            this.RhythmTextBox.Location = new System.Drawing.Point(136, 286);
            this.RhythmTextBox.Name = "RhythmTextBox";
            this.RhythmTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RhythmTextBox.Size = new System.Drawing.Size(51, 20);
            this.RhythmTextBox.TabIndex = 15;
            // 
            // PatientCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(103)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(740, 482);
            this.Controls.Add(this.RhythmTextBox);
            this.Controls.Add(this.labelRhythm);
            this.Controls.Add(this.MassTextBox);
            this.Controls.Add(this.labelMass);
            this.Controls.Add(this.GrowthTextBox);
            this.Controls.Add(this.labelGrowth);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.numericBirthYear);
            this.Controls.Add(this.numericBirthMounth);
            this.Controls.Add(this.numericBirthDay);
            this.Controls.Add(this.labelFatherName);
            this.Controls.Add(this.labelSecondNmae);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.FatherNameTextBox);
            this.Controls.Add(this.SecondNameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientCardForm";
            this.Text = "PatientCardForm";
            this.Load += new System.EventHandler(this.PatientCardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericBirthDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBirthMounth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBirthYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SecondNameTextBox;
        private System.Windows.Forms.TextBox FatherNameTextBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSecondNmae;
        private System.Windows.Forms.Label labelFatherName;
        private System.Windows.Forms.NumericUpDown numericBirthDay;
        private System.Windows.Forms.NumericUpDown numericBirthMounth;
        private System.Windows.Forms.NumericUpDown numericBirthYear;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelGrowth;
        private System.Windows.Forms.TextBox GrowthTextBox;
        private System.Windows.Forms.Label labelMass;
        private System.Windows.Forms.TextBox MassTextBox;
        private System.Windows.Forms.Label labelRhythm;
        private System.Windows.Forms.TextBox RhythmTextBox;
    }
}