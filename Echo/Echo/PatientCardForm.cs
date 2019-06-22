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

        private int[][] daysMounths = new int[][]
        {
            Enumerable.Range(1, 31).ToArray(),
            Enumerable.Range(1, 28).ToArray(),
            Enumerable.Range(1, 31).ToArray(),
            Enumerable.Range(1, 30).ToArray(),
            Enumerable.Range(1, 31).ToArray(),
            Enumerable.Range(1, 30).ToArray(),
            Enumerable.Range(1, 31).ToArray(),
            Enumerable.Range(1, 31).ToArray(),
            Enumerable.Range(1, 30).ToArray(),
            Enumerable.Range(1, 31).ToArray(),
            Enumerable.Range(1, 30).ToArray(),
            Enumerable.Range(1, 31).ToArray(),
        };   

        private static String[] mounths = new String[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август",
            "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"};

        private int selectedDay;

        public Form PatientWay { get; set; }
        public Panel MainPanel { get; set; }

        public PatientCardForm()
        {

            InitializeComponent();
        }



        private void PatientCardForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                comboMounth.Items.Add(mounths[i]);
            }

            comboDay.Text = "1";
            comboMounth.SelectedIndex = 0;
            comboDay.SelectedIndex = 0;
            numericBirthYear.Value = 1980;
            
            //comboDay.Text = "1";
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

        private void comboMounth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = comboDay.SelectedIndex;


            int index = comboMounth.SelectedIndex;
            int mounthLength = daysMounths[index].Length;
            //selectedDay = comboDay.SelectedIndex;

            if (comboDay.SelectedItem != null && (int)comboDay.SelectedItem > mounthLength)
            {
                //comboDay.Items.Clear();
                //comboDay.SelectedIndex = mounthLength;//mounthLength;
                comboDay.Text = mounthLength.ToString();
               // selectedDay = 
                // comboDay.Refresh();
            }

            comboDay.Items.Clear();

            
            for (int i = 0; i < mounthLength; i++)
            {
                comboDay.Items.Add(i + 1);
            }
            //comboDay.SelectedIndex = Convert.ToInt32(comboDay.Text);
            comboDay.SelectedIndex = Convert.ToInt32(comboDay.Text) - 1;                  
            labelAge.Text = comboDay.Text + " " + comboMounth.Text + " " + comboDay.SelectedIndex + " " + comboMounth.SelectedIndex;
        }

        private void comboDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelAge.Text = comboDay.Text + " " + comboMounth.Text + " " + comboDay.SelectedIndex + " " + comboMounth.SelectedIndex;
        }
    }
}
