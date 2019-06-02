namespace Echo
{
    partial class StyleForm
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
            this.StyleFormHeaderPanel = new System.Windows.Forms.Panel();
            this.StyleFormCloseButton = new System.Windows.Forms.Button();
            this.StyleFormHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StyleFormHeaderPanel
            // 
            this.StyleFormHeaderPanel.Controls.Add(this.StyleFormCloseButton);
            this.StyleFormHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.StyleFormHeaderPanel.Name = "StyleFormHeaderPanel";
            this.StyleFormHeaderPanel.Size = new System.Drawing.Size(761, 30);
            this.StyleFormHeaderPanel.TabIndex = 1;
            this.StyleFormHeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StyleFormHeaderPanel_MouseDown);
            this.StyleFormHeaderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StyleFormHeaderPanel_MouseMove);
            // 
            // StyleFormCloseButton
            // 
            this.StyleFormCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StyleFormCloseButton.Location = new System.Drawing.Point(718, 3);
            this.StyleFormCloseButton.Name = "StyleFormCloseButton";
            this.StyleFormCloseButton.Size = new System.Drawing.Size(29, 23);
            this.StyleFormCloseButton.TabIndex = 1;
            this.StyleFormCloseButton.UseVisualStyleBackColor = true;
            this.StyleFormCloseButton.Click += new System.EventHandler(this.StyleFormCloseButton_Click);
            // 
            // StyleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(103)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(759, 470);
            this.Controls.Add(this.StyleFormHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StyleForm";
            this.Text = "StyleForm";
            this.Load += new System.EventHandler(this.StyleForm_Load);
            this.StyleFormHeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StyleFormHeaderPanel;
        private System.Windows.Forms.Button StyleFormCloseButton;
    }
}