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
        private Button[] buttons = new Button[2];
        private Color readyButtonColor;
        private Color pressedButtonColor;

        public Form InsideForm { get; set; }
        public Patient Patient { get; set; }

        public MainForm()
        {
            InitializeComponent();

            readyButtonColor = Color.FromArgb(115, 126, 127);
            pressedButtonColor = Color.FromArgb(0, 122, 199);
            Patient = new Patient();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainFormHeaderPanel.Width = this.Width;
            MainFormCloseButton.TabStop = false;
            MainFormCloseButton.FlatStyle = FlatStyle.Flat;
            MainFormCloseButton.FlatAppearance.BorderSize = 0;
            MainFormHeaderPanel.Location = new Point(0, 0);

            buttons[0] = DoctorButton;
            buttons[1] = PatientButton;

            // isPressedButtons[0] = isDoctorButtonPressed = false;
            // isPressedButtons[1] = isPatientButtonPressed = false;
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

        private void DoctorButton_Click(object sender, EventArgs e)
        {
            InsideFormPanel.Controls.Clear();
            //InsideFormPanel.Controls.Clear();
            var doctorCardForm = new DoctorCardForm();
            InsideForm = doctorCardForm;
            InsideForm.Size = InsideFormPanel.Size;
            InsideForm.TopLevel = false;
            InsideFormPanel.Controls.Add(InsideForm);
            InsideForm.Show();

            for (int i = 0; i < buttons.Length; i++)
            {
                if (buttons[i] != sender)
                {
                    buttons[i].Enabled = true;
                    buttons[i].BackColor = readyButtonColor;
                }
                else
                {
                    buttons[i].Enabled = false;
                    buttons[i].BackColor = pressedButtonColor;
                }
            }

        }

        private void PatientButton_Click(object sender, EventArgs e)
        {

            InsideFormPanel.Controls.Clear();
            //PatientCardForm patientcardform = new PatientCardForm();
            var patientWayDialogForm = new PatientWayDialogForm();
            var patientCardForm = new PatientCardForm();

            //patientCardForm.MainPanel = InsideFormPanel;
            patientCardForm.PatientWay = InsideForm;

            InsideForm = patientWayDialogForm;
            InsideForm.TopLevel = false;
            //InsideForm.BackColor = Color.Blue;
            patientWayDialogForm.MainPanel = InsideFormPanel;
            InsideFormPanel.Controls.Add(InsideForm);
            InsideForm.Size = InsideFormPanel.Size;
            InsideForm.Show();
            // PatientButton.Active

            // PatientButton.Enabled = false;
            // PatientButton.BackColor = Color.FromArgb(0, 122, 199);

            //if (InsideForm.CreateNewPatientButton.IsPressed)

            for (int i = 0; i < buttons.Length; i++)
            {
                if (buttons[i] != sender)
                {
                    buttons[i].Enabled = true;
                    buttons[i].BackColor = readyButtonColor;
                }
                else
                {
                    buttons[i].Enabled = false;
                    buttons[i].BackColor = pressedButtonColor;
                }
            }

        }

        private void MainFormCloseButton_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White);
            e.Graphics.DrawLine(pen, 5, 5, MainFormCloseButton.Width - 5, MainFormCloseButton.Height - 5);
            e.Graphics.DrawLine(pen, MainFormCloseButton.Width - 5, 5, 5, MainFormCloseButton.Height - 5);
        }
    }
}
