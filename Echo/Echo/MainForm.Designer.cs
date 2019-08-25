namespace Echo
{
    partial class MainForm
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
            this.InsideFormPanel = new System.Windows.Forms.Panel();
            this.PatientButton = new Echo.StyleButton();
            this.DoctorButton = new Echo.StyleButton();
            this.ExitButton = new Echo.StyleButton();
            this.SuspendLayout();
            // 
            // InsideFormPanel
            // 
            this.InsideFormPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InsideFormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InsideFormPanel.Location = new System.Drawing.Point(162, 0);
            this.InsideFormPanel.Name = "InsideFormPanel";
            this.InsideFormPanel.Size = new System.Drawing.Size(1128, 686);
            this.InsideFormPanel.TabIndex = 1;
            // 
            // PatientButton
            // 
            this.PatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(126)))), ((int)(((byte)(127)))));
            this.PatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientButton.Location = new System.Drawing.Point(2, 115);
            this.PatientButton.Name = "PatientButton";
            this.PatientButton.Size = new System.Drawing.Size(154, 109);
            this.PatientButton.TabIndex = 2;
            this.PatientButton.TabStop = false;
            this.PatientButton.Text = "Данные Пациента";
            this.PatientButton.UseVisualStyleBackColor = true;
            this.PatientButton.Click += new System.EventHandler(this.PatientButton_Click);
            // 
            // DoctorButton
            // 
            this.DoctorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(126)))), ((int)(((byte)(127)))));
            this.DoctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoctorButton.Location = new System.Drawing.Point(3, 0);
            this.DoctorButton.Name = "DoctorButton";
            this.DoctorButton.Size = new System.Drawing.Size(154, 109);
            this.DoctorButton.TabIndex = 3;
            this.DoctorButton.TabStop = false;
            this.DoctorButton.Text = "Карта Врача";
            this.DoctorButton.UseVisualStyleBackColor = true;
            this.DoctorButton.Click += new System.EventHandler(this.DoctorButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(126)))), ((int)(((byte)(127)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(3, 577);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(154, 109);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.TabStop = false;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 713);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DoctorButton);
            this.Controls.Add(this.PatientButton);
            this.Controls.Add(this.InsideFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel InsideFormPanel;
        private StyleButton PatientButton;
        private StyleButton DoctorButton;
        private StyleButton ExitButton;
    }
}