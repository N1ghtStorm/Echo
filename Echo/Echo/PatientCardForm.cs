using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Echo.DataModel;

namespace Echo
{
    public partial class PatientCardForm : Form
    {
        private CalculateAge calculateAge;

        // Заполняем дни в месяцах
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
            calculateAge = new CalculateAge();
            comboDay.Text = "1";
            comboMounth.SelectedIndex = 0;
            comboDay.SelectedIndex = 0;
            numericBirthYear.Value = 1980;
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            PatientWayDialogForm patientWayDialogForm = new PatientWayDialogForm();
            PatientWay = patientWayDialogForm;
            PatientWay.TopLevel = false;
            MainPanel.Controls.Add(patientWayDialogForm) ;
            PatientWay.Size = this.Size;
            PatientWay.Show();
            patientWayDialogForm.MainPanel = this.MainPanel;

            this.Dispose();         
        }

        private void comboMounth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = comboDay.SelectedIndex;


            int index = comboMounth.SelectedIndex;
            int mounthLength = daysMounths[index].Length;

            if (comboDay.SelectedItem != null && (int)comboDay.SelectedItem > mounthLength)
            {
                comboDay.Text = mounthLength.ToString();
            }

            comboDay.Items.Clear();
            
            for (int i = 0; i < mounthLength; i++)
            {
                comboDay.Items.Add(i + 1);
            }
            comboDay.SelectedIndex = Convert.ToInt32(comboDay.Text) - 1;

            var age = calculateAge.GetAge(Convert.ToInt32(comboDay.Text), comboMounth.SelectedIndex + 1, (int)numericBirthYear.Value);
            labelAge.Text = comboDay.Text + " " + comboMounth.Text + " " + comboDay.SelectedIndex + " " + comboMounth.SelectedIndex + " " + age;
        }

        private void comboDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            var age = calculateAge.GetAge(comboDay.SelectedIndex + 1, comboMounth.SelectedIndex + 1, (int)numericBirthYear.Value);
            labelAge.Text = comboDay.Text + " " + comboMounth.Text + " " + comboDay.SelectedIndex + " " + comboMounth.SelectedIndex + " " + age;
        }

        private void numericBirthYear_ValueChanged(object sender, EventArgs e)
        {           
            var age = calculateAge.GetAge(comboDay.SelectedIndex + 1, comboMounth.SelectedIndex + 1, (int)numericBirthYear.Value);
            labelAge.Text = comboDay.Text + " " + comboMounth.Text + " " + comboDay.SelectedIndex + " " + comboMounth.SelectedIndex + " " + age;                           
        }
    }
}
