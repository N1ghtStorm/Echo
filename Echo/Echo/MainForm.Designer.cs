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
            this.MainFormHeaderPanel = new System.Windows.Forms.Panel();
            this.MainFormCloseButton = new System.Windows.Forms.Button();
            this.InsideFormPanel = new System.Windows.Forms.Panel();
            this.PatientButton = new System.Windows.Forms.Button();
            this.DoctorButton = new System.Windows.Forms.Button();
            this.MainFormHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormHeaderPanel
            // 
            this.MainFormHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.MainFormHeaderPanel.Controls.Add(this.MainFormCloseButton);
            this.MainFormHeaderPanel.Location = new System.Drawing.Point(2, 2);
            this.MainFormHeaderPanel.Name = "MainFormHeaderPanel";
            this.MainFormHeaderPanel.Size = new System.Drawing.Size(925, 30);
            this.MainFormHeaderPanel.TabIndex = 0;
            this.MainFormHeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainFormHeaderPanel_MouseDown);
            this.MainFormHeaderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainFormHeaderPanel_MouseMove);
            // 
            // MainFormCloseButton
            // 
            this.MainFormCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainFormCloseButton.Location = new System.Drawing.Point(897, 3);
            this.MainFormCloseButton.Name = "MainFormCloseButton";
            this.MainFormCloseButton.Size = new System.Drawing.Size(25, 25);
            this.MainFormCloseButton.TabIndex = 0;
            this.MainFormCloseButton.UseVisualStyleBackColor = true;
            this.MainFormCloseButton.Click += new System.EventHandler(this.MainFormCloseButton_Click);
            this.MainFormCloseButton.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormCloseButton_Paint);
            // 
            // InsideFormPanel
            // 
            this.InsideFormPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InsideFormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InsideFormPanel.Location = new System.Drawing.Point(162, 30);
            this.InsideFormPanel.Name = "InsideFormPanel";
            this.InsideFormPanel.Size = new System.Drawing.Size(753, 512);
            this.InsideFormPanel.TabIndex = 1;
            // 
            // PatientButton
            // 
            this.PatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientButton.Location = new System.Drawing.Point(2, 145);
            this.PatientButton.Name = "PatientButton";
            this.PatientButton.Size = new System.Drawing.Size(154, 109);
            this.PatientButton.TabIndex = 2;
            this.PatientButton.Text = "Данные Пациента";
            this.PatientButton.UseVisualStyleBackColor = true;
            this.PatientButton.Click += new System.EventHandler(this.PatientButton_Click);
            // 
            // DoctorButton
            // 
            this.DoctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoctorButton.Location = new System.Drawing.Point(2, 38);
            this.DoctorButton.Name = "DoctorButton";
            this.DoctorButton.Size = new System.Drawing.Size(154, 109);
            this.DoctorButton.TabIndex = 3;
            this.DoctorButton.Text = "Карта Врача";
            this.DoctorButton.UseVisualStyleBackColor = true;
            this.DoctorButton.Click += new System.EventHandler(this.DoctorButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(103)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(927, 554);
            this.Controls.Add(this.DoctorButton);
            this.Controls.Add(this.PatientButton);
            this.Controls.Add(this.InsideFormPanel);
            this.Controls.Add(this.MainFormHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainFormHeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainFormHeaderPanel;
        private System.Windows.Forms.Button MainFormCloseButton;
        private System.Windows.Forms.Panel InsideFormPanel;
        private System.Windows.Forms.Button PatientButton;
        private System.Windows.Forms.Button DoctorButton;
    }
}