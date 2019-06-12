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
    public partial class PatientCardForm : Form
    {
        public Form PatientWay { get; set; }
        public Panel MainPanel { get; set; }

        public PatientCardForm()
        {
            InitializeComponent();
        }

        private void PatientCardForm_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            PatientWayDialogForm patientWayDialogForm = new PatientWayDialogForm();
            PatientWay = patientWayDialogForm;
            PatientWay.TopLevel = false;
            MainPanel.Controls.Add(patientWayDialogForm) ;
            //PatientWay.Size = patientWayDialogForm.MainPanel.Size;
            PatientWay.Size = this.Size;
            PatientWay.Show();
            patientWayDialogForm.MainPanel = this.MainPanel;
            //MainPanel.Controls.Add(PatientWay);
            //PatientWay.Show();

            this.Dispose();
          
        }
    }
}
