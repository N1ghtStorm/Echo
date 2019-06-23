using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Echo.DataModel
{
    public class ReturnAgePhrase
    {
        private String phrase;
        public void ReturnPhrase(Label label, TimeSpan ageSpan, int dayIndex, int mounthIndex, decimal year)
        {
            CalculateAge calculateAge = new CalculateAge();
            ageSpan = calculateAge.GetAge(dayIndex + 1, mounthIndex + 1, (int)year);
            int age;
            if ((int)(ageSpan.TotalDays / 365) > 4)
            {
                phrase = " лет";
                age = (int)(ageSpan.TotalDays / 365);
            }
            else if ((int)(ageSpan.TotalDays / 365) > 1)
            {
                phrase = " года";
                age = (int)(ageSpan.TotalDays / 365);
            }
            else if ((int)(ageSpan.TotalDays / 365) == 1)
            {
                phrase = " год";
                age = (int)(ageSpan.TotalDays / 365);
            }
            else if ((int)(ageSpan.TotalDays) > 60)
            {
                phrase = " месяцев";
                age = (int)(ageSpan.TotalDays / 30);
            }
            else if ((int)(ageSpan.TotalDays) >= 30)
            {
                phrase = " месяц";
                age = (int)(ageSpan.TotalDays / 30);
            }
            else if ((int)(ageSpan.TotalDays) < 30 && (int)(ageSpan.TotalDays) >= 0)
            {
                phrase = " дней/день/дня";
                age = (int)(ageSpan.TotalDays);
            }
            else
            {
                age = 0;
            }

            if ((int)(ageSpan.TotalDays) >= 0)
            {
                label.Text = "Возраст:" + age + phrase;
                label.ForeColor = Color.White;
            }
            else
            {
                label.Text = "Введена некорректная дата";
                label.ForeColor = Color.FromArgb(145, 3, 27);
            }

            //return "";
        }
    }
}
