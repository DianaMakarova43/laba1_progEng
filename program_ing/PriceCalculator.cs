using program_ing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App
{
    /// <summary>
    /// Вычисляет итоговую цену
    /// </summary>
    public class PriceCalculator
    {
        #region
        /// <summary>
        /// Макс цена хлеба
        /// </summary>
        public const double MaxHlebPrice = 100;
        /// <summary>
        /// Мин цена хлеба
        /// </summary>
        public const double MinHlebPrice = 15;
        /// <summary>
        /// Макс цена колбасы
        /// </summary>
        public const double MaxColbasaPrice = 2000;
        /// <summary>
        /// Мин цена колбасы
        /// </summary>
        public const double MinColbasaPrice = 50;
        #endregion

        /// <summary>
        /// Вычисляет итоговую цену
        /// </summary>
        /// <param name="Colbasa"></param>
        /// <param name="Hleb"></param>
        /// <returns>индекс bmi</returns>
        public static double GetPrice(double Colbasa, double Hleb)
        {
            double price;

            ValidationHelper.CheckRangeValue(Hleb, MinHlebPrice, MaxHlebPrice, "Хлеб должен быть от {0} до {1} рублей за 1 шт");
            ValidationHelper.CheckRangeValue(Colbasa, MinColbasaPrice, MaxColbasaPrice, "Колбаса должна быть от {0} до {1} рублей за 1 кг");
            
            price = Hleb + Colbasa;

            string description = ValuePrice.GetPriceDescription(price);
            Console.WriteLine($"Продукты за такую стоимость {description}");

            return price;
        }     
    }
}