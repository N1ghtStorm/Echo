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
    public partial class PatientWayDialogForm : Form
    {
        public Form InsideForm { get; set; }
        public Panel MainPanel { get; set; }

        public PatientWayDialogForm()
        {
            InitializeComponent();
        }

        private void CreateNewPatientButton_Click(object sender, EventArgs e)
        {
            PatientCardForm patientCardForm = new PatientCardForm();
            //var patientwaydialogform = new PatientWayDialogForm();
            InsideForm = patientCardForm;
            InsideForm.TopLevel = false;
            //InsideForm.BackColor = Color.Blue;
            //this.Controls.Add(InsideForm);          
            InsideForm.Size = this.Size;
            //CreateNewPatientButton.Hide();
            // ChooseOldPatient.Hide();
            MainPanel.Controls.Add(InsideForm);
            InsideForm.Show();
            patientCardForm.MainPanel = this.MainPanel;
            this.Dispose();
            //this.Dispose();
            
        }

        private void ChooseOldPatient_Click(object sender, EventArgs e)
        {

        }
    }
}
