namespace Echo
{
    partial class PatientWayDialogForm
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
            this.CreateNewPatientButton = new System.Windows.Forms.Button();
            this.ChooseOldPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateNewPatientButton
            // 
            this.CreateNewPatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(126)))), ((int)(((byte)(127)))));
            this.CreateNewPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNewPatientButton.Location = new System.Drawing.Point(192, 81);
            this.CreateNewPatientButton.Name = "CreateNewPatientButton";
            this.CreateNewPatientButton.Size = new System.Drawing.Size(347, 105);
            this.CreateNewPatientButton.TabIndex = 0;
            this.CreateNewPatientButton.Text = "Новый Пациент";
            this.CreateNewPatientButton.UseVisualStyleBackColor = false;
            this.CreateNewPatientButton.Click += new System.EventHandler(this.CreateNewPatientButton_Click);
            // 
            // ChooseOldPatient
            // 
            this.ChooseOldPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(126)))), ((int)(((byte)(127)))));
            this.ChooseOldPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseOldPatient.Location = new System.Drawing.Point(192, 228);
            this.ChooseOldPatient.Name = "ChooseOldPatient";
            this.ChooseOldPatient.Size = new System.Drawing.Size(347, 105);
            this.ChooseOldPatient.TabIndex = 1;
            this.ChooseOldPatient.Text = "Выбрать Пациента";
            this.ChooseOldPatient.UseVisualStyleBackColor = false;
            this.ChooseOldPatient.Click += new System.EventHandler(this.ChooseOldPatient_Click);
            // 
            // PatientWayDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(103)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(693, 444);
            this.Controls.Add(this.ChooseOldPatient);
            this.Controls.Add(this.CreateNewPatientButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientWayDialogForm";
            this.Text = "PatientWayDialogForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateNewPatientButton;
        private System.Windows.Forms.Button ChooseOldPatient;
    }
}