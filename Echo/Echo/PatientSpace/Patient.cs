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

        // Полости Сердца:
        #region Левый Желудочек
        //========================================================================================
        //========================================================================================
        // Левый Желудочек(Left Ventricle):
        public float LeftVenFinalDiasSize { get; set; }
        public float LeftVenFinalSistSize { get; set; }
        //public float LeftVenFunc2D { get; set; }

        // Сократительная функция лж:
        //========================================================================================
        //Формула одной плоскости
        //========================================================================================
        //Формула двух плоскостей
        //========================================================================================
        //Формула Симпсона


        // Конечное диастолическое давление: (НЕ нужно!!!!)
        //public float LeftVenFinalDiasPresMaxSpeedFast { get; set; }
        //public float LeftVenFinalDiasPresMaxSpeedArte { get; set; }
        //public float LeftVenFinalDiasPresDurationFast { get; set; }
        //public float LeftVenFinalDiasPresDurationArte { get; set; }

        // Масса Миокарда: Масса Миокарда по формуле площадь-длина:
        public float LeftVenMiocMassLongHalfAxis { get; set; }
        public float LeftVenMiocMassShortHalfAxis { get; set; }
        public float LeftVenMiocMassMiocThick { get; set; }
        public float LeftVenMiocMassEndoArea { get; set; }
        public float LeftVenMiocMassEpicArea { get; set; }

        // Масса Миокарда: Масса Миокарда по формуле усечённого эллипса:
        public float LeftVenMiocMassShortHalfAxisRadius { get; set; }

        // Оценка сердечной недостаточности:
        public float LeftVenHeartFailRelaxIsoPhase { get; set; }
        public float LeftVenHeartFailMaxSpeedFast { get; set; }
        public float LeftVenHeartFailMaxSpeedSlow { get; set; }

        // Оценка сердечной недостаточности: Оценка диастолической функции:

        public float LeftVenHeartFailIvsDEchoKg { get; set; }
        public float LeftVenHeartFailExileTimeDEchoKg { get; set; }
        public float LeftVenHeartFailIvrTdi { get; set; }
        public float LeftVenHeartFailIvsTdi { get; set; }
        public float LeftVenHeartFailExileTimeTdi { get; set; }
        public float LeftVenHeartFailMaxSistSpeedTdi { get; set; }
        public float LeftVenHeartFailMaxEarlyDiastSpeedTdi { get; set; }
        public float LeftVenHeartFailMaxLateDiastSpeedTdi { get; set; }
        public float LeftVenHeartFailMaxSWaveSpeedLvd { get; set; }
        public float LeftVenHeartFailMaxDWaveSpeedLvd { get; set; }
        public float LeftVenHeartFailReversWaveSpeedLvd { get; set; }
        public float LeftVenHeartFailReversWaveTimeLvd { get; set; }
        public float LeftVenHeartFailMitralFloatMoveSpeed { get; set; }

        public string LeftVenCavitySpecifics { get; set; }

        //=======================================================================================

        // Задняя стенка левого желудочка:
        
        public float LeftVenBackWallDiastThick { get; set; }
        public float LeftVenBackWallSistThick { get; set; }
        //public float LeftVenBackWallSistExcurt { get; set; } //НЕ НУЖНО
        //public float LeftVenBackWallMaxContractionSpeed { get; set; } //НЕ НУЖНО
        //public float LeftVenBackWallMaxRelaxSpeed { get; set; } //НЕ НУЖНО
        //public float LeftVenBackWallContractionPeriod { get; set; } //НЕ НУЖНО

        public string LeftVenBackWallSpecifics { get; set; }

        //========================================================================================
        #endregion
        #region Остальные полости сердца
        // Межжелудочковая перегородка:

        public float InterVenSeptumDiastThick { get; set; }
        public float InterVenSeptumSistThick { get; set; }
        // public float InterVenSeptumExcurtIntoSiast { get; set; } //НЕ НУЖНО

        public string InterVenSeptumSpecifics { get; set; }

        //===========================================================================================

        // Правый Желудочек (Right Ventricle)

        public float RightVenFinalDiasSize { get; set; }
        //public float RightVenFinalSiastSize { get; set; } //НЕ НУЖНО

        public string RightVenSpecifics { get; set; }

        //===========================================================================================

        // Левое предсердие (Left Auricle)

        public float LeftAuricSistSize { get; set; }
        //public float LeftAuricArterialPressToSist { get; set; }
        //public float LeftAuricSistGradient { get; set; }

        public string LeftAuricSpecifics { get; set; }

        //===========================================================================================

        // Правое предсердие (Right Auricle)

        public float RightAuricUpperBottomSize { get; set; }
        public float RightAuricMidealLatterSize { get; set; }

        public string RightAuricSpecifics { get; set; }

        //===========================================================================================

        // Межпредсердная перегородка

        public string InterAuricSpecifics { get; set; }

        //============================================================================================
        //============================================================================================
        #endregion


        public double BodyArea()
        {
            double bodyArea;
            bodyArea = bodyAreaCoefficient * Math.Pow(Mass, 0.425f) * Math.Pow(Growth, 0.725f);
            return bodyArea;
        }
    }
}
