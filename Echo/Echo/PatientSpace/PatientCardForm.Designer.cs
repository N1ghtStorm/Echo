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
            this.numericBirthYear = new System.Windows.Forms.NumericUpDown();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelGrowth = new System.Windows.Forms.Label();
            this.GrowthTextBox = new System.Windows.Forms.TextBox();
            this.labelMass = new System.Windows.Forms.Label();
            this.MassTextBox = new System.Windows.Forms.TextBox();
            this.labelRhythm = new System.Windows.Forms.Label();
            this.RhythmTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new Echo.StyleButton();
            this.comboDay = new System.Windows.Forms.ComboBox();
            this.comboMounth = new System.Windows.Forms.ComboBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelMounth = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.Accept = new Echo.StyleButton();
            this.labelAge = new System.Windows.Forms.Label();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericBirthYear)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.White;
            this.NameTextBox.Location = new System.Drawing.Point(147, 15);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameTextBox.Size = new System.Drawing.Size(110, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // SecondNameTextBox
            // 
            this.SecondNameTextBox.BackColor = System.Drawing.Color.White;
            this.SecondNameTextBox.Location = new System.Drawing.Point(147, 55);
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            this.SecondNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SecondNameTextBox.Size = new System.Drawing.Size(110, 20);
            this.SecondNameTextBox.TabIndex = 1;
            // 
            // FatherNameTextBox
            // 
            this.FatherNameTextBox.BackColor = System.Drawing.Color.White;
            this.FatherNameTextBox.Location = new System.Drawing.Point(147, 96);
            this.FatherNameTextBox.Name = "FatherNameTextBox";
            this.FatherNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FatherNameTextBox.Size = new System.Drawing.Size(110, 20);
            this.FatherNameTextBox.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelName.Location = new System.Drawing.Point(3, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(80, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Имя Больного";
            // 
            // labelSecondNmae
            // 
            this.labelSecondNmae.AutoSize = true;
            this.labelSecondNmae.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSecondNmae.Location = new System.Drawing.Point(6, 55);
            this.labelSecondNmae.Name = "labelSecondNmae";
            this.labelSecondNmae.Size = new System.Drawing.Size(56, 13);
            this.labelSecondNmae.TabIndex = 4;
            this.labelSecondNmae.Text = "Фамилия";
            // 
            // labelFatherName
            // 
            this.labelFatherName.AutoSize = true;
            this.labelFatherName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFatherName.Location = new System.Drawing.Point(8, 96);
            this.labelFatherName.Name = "labelFatherName";
            this.labelFatherName.Size = new System.Drawing.Size(54, 13);
            this.labelFatherName.TabIndex = 5;
            this.labelFatherName.Text = "Отчество";
            // 
            // numericBirthYear
            // 
            this.numericBirthYear.Location = new System.Drawing.Point(369, 203);
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
            this.numericBirthYear.ValueChanged += new System.EventHandler(this.numericBirthYear_ValueChanged);
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBirthDate.Location = new System.Drawing.Point(21, 205);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(87, 13);
            this.labelBirthDate.TabIndex = 9;
            this.labelBirthDate.Text = "Дата Рождения";
            // 
            // labelGrowth
            // 
            this.labelGrowth.AutoSize = true;
            this.labelGrowth.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGrowth.Location = new System.Drawing.Point(23, 274);
            this.labelGrowth.Name = "labelGrowth";
            this.labelGrowth.Size = new System.Drawing.Size(58, 13);
            this.labelGrowth.TabIndex = 10;
            this.labelGrowth.Text = "Рост (См.)";
            // 
            // GrowthTextBox
            // 
            this.GrowthTextBox.BackColor = System.Drawing.Color.White;
            this.GrowthTextBox.Location = new System.Drawing.Point(136, 274);
            this.GrowthTextBox.Name = "GrowthTextBox";
            this.GrowthTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GrowthTextBox.Size = new System.Drawing.Size(51, 20);
            this.GrowthTextBox.TabIndex = 11;
            // 
            // labelMass
            // 
            this.labelMass.AutoSize = true;
            this.labelMass.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMass.Location = new System.Drawing.Point(23, 322);
            this.labelMass.Name = "labelMass";
            this.labelMass.Size = new System.Drawing.Size(64, 13);
            this.labelMass.TabIndex = 12;
            this.labelMass.Text = "Масса (Кг.)";
            // 
            // MassTextBox
            // 
            this.MassTextBox.BackColor = System.Drawing.Color.White;
            this.MassTextBox.Location = new System.Drawing.Point(136, 315);
            this.MassTextBox.Name = "MassTextBox";
            this.MassTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MassTextBox.Size = new System.Drawing.Size(51, 20);
            this.MassTextBox.TabIndex = 13;
            // 
            // labelRhythm
            // 
            this.labelRhythm.AutoSize = true;
            this.labelRhythm.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRhythm.Location = new System.Drawing.Point(23, 361);
            this.labelRhythm.Name = "labelRhythm";
            this.labelRhythm.Size = new System.Drawing.Size(85, 13);
            this.labelRhythm.TabIndex = 14;
            this.labelRhythm.Text = "Ритм(Уд./Мин.)";
            // 
            // RhythmTextBox
            // 
            this.RhythmTextBox.BackColor = System.Drawing.Color.White;
            this.RhythmTextBox.Location = new System.Drawing.Point(136, 358);
            this.RhythmTextBox.Name = "RhythmTextBox";
            this.RhythmTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RhythmTextBox.Size = new System.Drawing.Size(51, 20);
            this.RhythmTextBox.TabIndex = 15;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(126)))), ((int)(((byte)(127)))));
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(12, 405);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(121, 43);
            this.BackButton.TabIndex = 16;
            this.BackButton.TabStop = false;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // comboDay
            // 
            this.comboDay.FormattingEnabled = true;
            this.comboDay.ItemHeight = 13;
            this.comboDay.Location = new System.Drawing.Point(136, 202);
            this.comboDay.Name = "comboDay";
            this.comboDay.Size = new System.Drawing.Size(51, 21);
            this.comboDay.TabIndex = 17;
            this.comboDay.SelectedIndexChanged += new System.EventHandler(this.comboDay_SelectedIndexChanged);
            // 
            // comboMounth
            // 
            this.comboMounth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMounth.FormattingEnabled = true;
            this.comboMounth.Location = new System.Drawing.Point(233, 202);
            this.comboMounth.Name = "comboMounth";
            this.comboMounth.Size = new System.Drawing.Size(84, 21);
            this.comboMounth.TabIndex = 18;
            this.comboMounth.SelectedIndexChanged += new System.EventHandler(this.comboMounth_SelectedIndexChanged);
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDay.Location = new System.Drawing.Point(193, 205);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(34, 13);
            this.labelDay.TabIndex = 19;
            this.labelDay.Text = "День";
            // 
            // labelMounth
            // 
            this.labelMounth.AutoSize = true;
            this.labelMounth.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMounth.Location = new System.Drawing.Point(323, 205);
            this.labelMounth.Name = "labelMounth";
            this.labelMounth.Size = new System.Drawing.Size(40, 13);
            this.labelMounth.TabIndex = 20;
            this.labelMounth.Text = "Месяц";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.ForeColor = System.Drawing.SystemColors.Control;
            this.labelYear.Location = new System.Drawing.Point(440, 205);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(25, 13);
            this.labelYear.TabIndex = 21;
            this.labelYear.Text = "Год";
            // 
            // Accept
            // 
            this.Accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(126)))), ((int)(((byte)(127)))));
            this.Accept.FlatAppearance.BorderSize = 0;
            this.Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Accept.Location = new System.Drawing.Point(456, 405);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(140, 43);
            this.Accept.TabIndex = 22;
            this.Accept.TabStop = false;
            this.Accept.Text = "Применить";
            this.Accept.UseVisualStyleBackColor = false;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAge.Location = new System.Drawing.Point(471, 205);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(0, 13);
            this.labelAge.TabIndex = 23;
            // 
            // comboGender
            // 
            this.comboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGender.FormattingEnabled = true;
            this.comboGender.ItemHeight = 13;
            this.comboGender.Location = new System.Drawing.Point(136, 238);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(100, 21);
            this.comboGender.TabIndex = 24;
            this.comboGender.SelectedIndexChanged += new System.EventHandler(this.comboGender_SelectedIndexChanged);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGender.Location = new System.Drawing.Point(40, 241);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(27, 13);
            this.labelGender.TabIndex = 25;
            this.labelGender.Text = "Пол";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.SecondNameTextBox);
            this.groupBox1.Controls.Add(this.labelSecondNmae);
            this.groupBox1.Controls.Add(this.labelFatherName);
            this.groupBox1.Controls.Add(this.FatherNameTextBox);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 129);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ф.И.О.";
            // 
            // PatientCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(103)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(608, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelMounth);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.comboMounth);
            this.Controls.Add(this.comboDay);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RhythmTextBox);
            this.Controls.Add(this.labelRhythm);
            this.Controls.Add(this.MassTextBox);
            this.Controls.Add(this.labelMass);
            this.Controls.Add(this.GrowthTextBox);
            this.Controls.Add(this.labelGrowth);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.numericBirthYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientCardForm";
            this.Text = "PatientCardForm";
            this.Load += new System.EventHandler(this.PatientCardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericBirthYear)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.NumericUpDown numericBirthYear;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelGrowth;
        private System.Windows.Forms.TextBox GrowthTextBox;
        private System.Windows.Forms.Label labelMass;
        private System.Windows.Forms.TextBox MassTextBox;
        private System.Windows.Forms.Label labelRhythm;
        private System.Windows.Forms.TextBox RhythmTextBox;
        private StyleButton BackButton;
        private System.Windows.Forms.ComboBox comboDay;
        private System.Windows.Forms.ComboBox comboMounth;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelMounth;
        private System.Windows.Forms.Label labelYear;
        private StyleButton Accept;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}