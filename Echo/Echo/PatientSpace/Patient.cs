using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo
{
    [Serializable]
    public class Patient
    {
        private const double bodyAreaCoefficient = 0.007184f; //Коэфициент из Википедии

        //Номер Карты Больного
        public int CardNumber { get; set; }

        //Имя Больного
        public String Name { get; set; }
        public String SecondName { get; set; }
        public String FatherName { get; set; }

        //Остальные Реквезиты
        public String Department { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public int Growth { get; set; }
        public int Mass { get; set; }
        public int Rhythm { get; set; }
        public int ExilePeriod { get; set; } //Период изгнания

        public double BodyArea()
        {
            double bodyArea;
            bodyArea = bodyAreaCoefficient * Math.Pow(Mass, 0.425f) * Math.Pow(Growth, 0.725f);
            return bodyArea;
        }
    }
}
