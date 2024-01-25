using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema14prkt2
{
    class Sport
    {
        /// <summary>
        /// статические поля
        /// </summary>
        //static string fio;
        //static string pol;
        //static int data;
        /// <summary>
        /// Свойства
        /// </summary>
        //public string Fio
        //{
        //    get { return fio; }
        //    set { fio = value; }
        //}
        //public string Pol
        //{
        //    get { return pol; }
        //    set { pol = value; }
        //}
        //public int Data
        //{
        //    get { return data; }
        //    set { data = value; }
        //}
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        //public Sport()
        //{
        //    this.Fio = fio;
        //    this.Pol = pol;
        //    this.Data = data;
        //}

        /// <summary>
        /// Вывод информации
        /// </summary>
        /// <returns></returns>
        //public override string ToString()
        //{
        //    return $"Ф.И.О - {Fio}\nПол -{Pol}\nДата рождения - {Data}\n";
        //}

        //Задание 2
        /// <summary>
        /// Статические поля 
        /// </summary>
        static string fio2;
        static int height;
        static double weight;
        
        /// <summary>
        /// Свойства для статических полей
        /// </summary>
        public string Fio2
        {
            get { return fio2; }
            set { fio2 = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        /// <summary>
        /// Конструктор с тремя параметрами
        /// </summary>
        /// <param name="Fio2"></param>
        /// <param name="Height"></param>
        /// <param name="Weight"></param>
        public Sport(string Fio2,int Height,double Weight)
        {
            this.Fio2 = fio2;
            this.Height = height;
            this.Weight = weight;
        }
        
        /// <summary>
        /// Метод вывода
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Ф.И.О - {fio2}\nРост = {height}\nВес = {weight}");
        }
        






    }
}
