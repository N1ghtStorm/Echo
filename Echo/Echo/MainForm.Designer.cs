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
            this.PatientButton = new StyleButton();
            this.DoctorButton = new StyleButton();
            this.ExitButton = new StyleButton();
            this.SuspendLayout();
            // 
            // InsideFormPanel
            // 
            this.InsideFormPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InsideFormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InsideFormPanel.Location = new System.Drawing.Point(241, 14);
            this.InsideFormPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InsideFormPanel.Name = "InsideFormPanel";
            this.InsideFormPanel.Size = new System.Drawing.Size(1692, 936);
            this.InsideFormPanel.TabIndex = 1;
            // 
            // PatientButton
            // 
            this.PatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientButton.Location = new System.Drawing.Point(3, 235);
            this.PatientButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PatientButton.Name = "PatientButton";
            this.PatientButton.Size = new System.Drawing.Size(231, 168);
            this.PatientButton.TabIndex = 2;
            this.PatientButton.Text = "Данные Пациента";
            this.PatientButton.UseVisualStyleBackColor = true;
            this.PatientButton.Click += new System.EventHandler(this.PatientButton_Click);
            // 
            // DoctorButton
            // 
            this.DoctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoctorButton.Location = new System.Drawing.Point(4, 0);
            this.DoctorButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DoctorButton.Name = "DoctorButton";
            this.DoctorButton.Size = new System.Drawing.Size(231, 168);
            this.DoctorButton.TabIndex = 3;
            this.DoctorButton.Text = "Карта Врача";
            this.DoctorButton.UseVisualStyleBackColor = true;
            this.DoctorButton.Click += new System.EventHandler(this.DoctorButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(4, 820);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(231, 168);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1946, 1002);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DoctorButton);
            this.Controls.Add(this.PatientButton);
            this.Controls.Add(this.InsideFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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