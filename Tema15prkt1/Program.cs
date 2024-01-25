using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema14prkt2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sport[] pupils = new Sport[3];
            //for (int i = 1; i < pupils.Length; i++)
            //{
            //    Sport pupils1 = new Sport();
            //    Console.Write($"Введите Ф.И.О {i} ученика - ");
            //    pupils1.Fio = Console.ReadLine();
            //    Console.Write("Введите пол ученика - ");
            //    pupils1.Pol = Console.ReadLine();
            //    Console.Write("Введите дату рождения ученика - ");
            //    pupils1.Data = int.Parse(Console.ReadLine());
            //    Console.Write(pupils1.ToString());
            //    if (pupils1.Data > 2018)
            //    {
            //        Console.Write("Вы ошиблись датой\n");
            //    }
            //}
            //Не понял как подсчитать кол-во девочек и мальчиков
            //Задание 2
            Sport[] sportsmans = new Sport[3];
            int c = 0;
            for( int y = 0;y < sportsmans.Length;y++ )
            {
                Sport sportsmans1 = new Sport("Artem",2,3);
                Console.Write($"Введите Ф.И.О {y} ученика - ");
                sportsmans1.Fio2 = Console.ReadLine();
                Console.Write("Введите рост спортсмена - ");
                sportsmans1.Height = int.Parse(Console.ReadLine());
                Console.Write("Введите вес спортсмена - ");
                sportsmans1.Weight = double.Parse(Console.ReadLine());
                if(sportsmans1.Weight > 70)
                {
                    c++;
                }
                Console.WriteLine($"Кол-во спортсменов у которых вес 70+ = {c}");
                
                sportsmans1.Print();
            }



            Console.ReadKey();
        }
    }
}
