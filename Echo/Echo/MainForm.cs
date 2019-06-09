using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Echo
{   
/// <summary>
/// Главная Форма Проекта
/// </summary>
    public partial class MainForm : Form
    {
        private Point mouseLocation;

        public Form InsideForm { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainFormHeaderPanel.Location = new Point(0,0);
        }

        private void MainFormCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Перетаскивание Мышью
        private void MainFormHeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void MainFormHeaderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void PatientButton_Click(object sender, EventArgs e)
        {
            PatientCardForm patientcardform = new PatientCardForm();
            InsideForm = patientcardform;
            InsideForm.TopLevel = false;
            InsideFormPanel.Controls.Add(InsideForm);
            InsideForm.Size = InsideFormPanel.Size;
            InsideForm.Show();
        }
    }
}
