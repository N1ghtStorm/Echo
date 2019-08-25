using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Echo.DataModel;

namespace Echo
{
    public partial class PatientCardForm : Form
    {
        private CalculateAge calculateAge;
        private ReturnAgePhrase returnAgePharse;
        private String phrase;
        private Patient mainPatient;
        private bool isFemale;
  

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
            mainPatient = (this.Owner as MainForm).Patient;
        }

        private void PatientCardForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                comboMounth.Items.Add(mounths[i]);
            }

            comboGender.Items.Add("Женский");
            comboGender.Items.Add("Мужской");
            //comboGender.DropDownStyle = DropDownList;

            calculateAge = new CalculateAge();
            returnAgePharse = new ReturnAgePhrase();

            
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

        // Смена Месяца
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
            //comboDay.MaxLength = mounthLength;

            for (int i = 0; i < mounthLength; i++)
            {
                comboDay.Items.Add(i + 1);
            }

            try
            {
               comboDay.SelectedIndex = Convert.ToInt32(comboDay.Text) - 1;
            }
            catch(Exception exep)
            {

            }

            var ageSpan = calculateAge.GetAge(comboDay.SelectedIndex + 1, comboMounth.SelectedIndex + 1, (int)numericBirthYear.Value);
            returnAgePharse.ReturnPhrase(labelAge, ageSpan, comboDay.SelectedIndex, comboMounth.SelectedIndex, numericBirthYear.Value);
        }

        // Смена дня
        private void comboDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboMounth.SelectedIndex;
            int mounthLength = daysMounths[index].Length;
            /*
            for (int i = 0; i < mounthLength; i++)
            {
                if (Convert.ToInt32(comboDay.Text) != i + 1)
                {
                    comboDay.Text = "1";
                    comboDay.SelectedIndex = 0;
                }
            } */
            bool found = daysMounths[index].Contains(Convert.ToInt32(comboDay.Text));
            if (!found)
            {
                comboDay.Text = "1";
                comboDay.SelectedIndex = 0;
            }

            var ageSpan = calculateAge.GetAge(comboDay.SelectedIndex + 1, comboMounth.SelectedIndex + 1, (int)numericBirthYear.Value);
            returnAgePharse.ReturnPhrase(labelAge, ageSpan, comboDay.SelectedIndex, comboMounth.SelectedIndex, numericBirthYear.Value);
        }

        // Смена года
        private void numericBirthYear_ValueChanged(object sender, EventArgs e)
        {
            var ageSpan = calculateAge.GetAge(comboDay.SelectedIndex + 1, comboMounth.SelectedIndex + 1, (int)numericBirthYear.Value);
            returnAgePharse.ReturnPhrase(labelAge, ageSpan, comboDay.SelectedIndex, comboMounth.SelectedIndex, numericBirthYear.Value);
        }

        private void comboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboGender.SelectedIndex == 0)
            {
                isFemale = true;
            }
            else
            {
                isFemale = false;
            }

        }

        private void Accept_Click(object sender, EventArgs e)
        {
            XmlSerializer writer = new XmlSerializer(typeof(Patient));
        }
    }
}
