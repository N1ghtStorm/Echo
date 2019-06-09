namespace Echo
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
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
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
            // PatientCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(103)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(740, 482);
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
    }
}