namespace Echo
{
    partial class DoctorCardForm
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
            this.SecondNameBox = new System.Windows.Forms.TextBox();
            this.FatherNameBox = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.White;
            this.NameTextBox.Location = new System.Drawing.Point(187, 71);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameTextBox.Size = new System.Drawing.Size(110, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // SecondNameBox
            // 
            this.SecondNameBox.BackColor = System.Drawing.Color.White;
            this.SecondNameBox.Location = new System.Drawing.Point(187, 136);
            this.SecondNameBox.Name = "SecondNameBox";
            this.SecondNameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SecondNameBox.Size = new System.Drawing.Size(110, 20);
            this.SecondNameBox.TabIndex = 2;
            // 
            // FatherNameBox
            // 
            this.FatherNameBox.BackColor = System.Drawing.Color.White;
            this.FatherNameBox.Location = new System.Drawing.Point(187, 199);
            this.FatherNameBox.Name = "FatherNameBox";
            this.FatherNameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FatherNameBox.Size = new System.Drawing.Size(110, 20);
            this.FatherNameBox.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelName.Location = new System.Drawing.Point(70, 74);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(70, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(70, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Отчество";
            // 
            // DoctorCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(103)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(744, 463);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.FatherNameBox);
            this.Controls.Add(this.SecondNameBox);
            this.Controls.Add(this.NameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorCardForm";
            this.Text = "DoctorCardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SecondNameBox;
        private System.Windows.Forms.TextBox FatherNameBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}