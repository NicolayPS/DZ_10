using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10
{
    class AngularSecond
    {
        double gradus;//ввод данных 
        double min;
        double sec;
        public bool isCorrect = true;

        public double Gradus //проверка градусов
        {
            get
            {
                return gradus;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                    gradus = value % 360;
            }
        }
        public double Min //проверка минут
        {
            get
            {
                return min;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                {
                    Gradus += value / 60;
                    min = value % 60;
                }
            }
        }
        public double Sec //проверка секунд
        {
            get
            {
                return sec;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                {
                    Min += value / 60;
                    sec = value % 60;
                }
            }
        }

        public AngularSecond(double gradus, double min, double sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }

        public double ToRadians()
        {
            return (gradus + (min + sec / 60) / 60)*Math.PI/180;
        }
    }
}