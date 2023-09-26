using App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ing
{
    internal class Program
    {
        /// <summary>
        /// Запуск
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double Colbasa, Hleb;

            Console.WriteLine("Введите стоимость колбасы:");
            Colbasa = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите стоимость хлеба:");
            Hleb = double.Parse(Console.ReadLine());

            double price = PriceCalculator.GetPrice(Colbasa, Hleb);
            Console.WriteLine(price);         
        }
    }
}
