using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo.DataModel
{

    public class CalculateAge
    {
        private DateTime dateAndTime;
        //private 

        public CalculateAge()
        {
            dateAndTime = DateTime.Now;
            //currentDate = dateAndTime.Date;
        }

        public TimeSpan GetAge(int day, int mounth, int year)
        {
            String stringBirthDay = day.ToString() + "/" + mounth.ToString() + "/" + year.ToString();
            DateTime birthDay = Convert.ToDateTime(stringBirthDay);
            var age = dateAndTime - birthDay;

            return age;
        }
    }
}
