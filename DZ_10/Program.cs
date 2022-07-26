using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10
{
    class Program
    {
        static void Main(string[] args)
        {
            AngularSecond angularsecond;
            do
            {
                Console.Write("Введите данные\nВведите градусы:");
                double gradus_ = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите минуты:");
                double min_ = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите секунды:");
                double sec_ = Convert.ToDouble(Console.ReadLine());

                angularsecond = new AngularSecond(gradus_, min_, sec_);
            }
            while (angularsecond.isCorrect == false);

            double totalRadians = angularsecond.ToRadians();
            Console.WriteLine(totalRadians);
            Console.ReadKey();
        }
    }
}