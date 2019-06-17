namespace Echo
{
    partial class DoctorWayDialogForm
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
            this.CreateNewDoctorButton = new System.Windows.Forms.Button();
            this.ChooseOldPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateNewDoctorButton
            // 
            this.CreateNewDoctorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(126)))), ((int)(((byte)(127)))));
            this.CreateNewDoctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNewDoctorButton.Location = new System.Drawing.Point(186, 69);
            this.CreateNewDoctorButton.Name = "CreateNewDoctorButton";
            this.CreateNewDoctorButton.Size = new System.Drawing.Size(347, 105);
            this.CreateNewDoctorButton.TabIndex = 1;
            this.CreateNewDoctorButton.Text = "Ваше Имя";
            this.CreateNewDoctorButton.UseVisualStyleBackColor = false;
            // 
            // ChooseOldPatient
            // 
            this.ChooseOldPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(126)))), ((int)(((byte)(127)))));
            this.ChooseOldPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseOldPatient.Location = new System.Drawing.Point(186, 222);
            this.ChooseOldPatient.Name = "ChooseOldPatient";
            this.ChooseOldPatient.Size = new System.Drawing.Size(347, 105);
            this.ChooseOldPatient.TabIndex = 2;
            this.ChooseOldPatient.Text = "Выбрать Пациента";
            this.ChooseOldPatient.UseVisualStyleBackColor = false;
            // 
            // DoctorWayDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(103)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(721, 441);
            this.Controls.Add(this.ChooseOldPatient);
            this.Controls.Add(this.CreateNewDoctorButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorWayDialogForm";
            this.Text = "DoctorWayDialogForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateNewDoctorButton;
        private System.Windows.Forms.Button ChooseOldPatient;
    }
}