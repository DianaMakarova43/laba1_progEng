using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace program_ing
{
    internal class ValuePrice
    {
        /// <summary>
        /// Описание к сумме за хлеб и колбасу
        /// </summary>
        static Dictionary<double, string> description = new()
        {
            { 200 , "из пятерочки"},
            { 500 , "из рынка"},
            { 1000 , "из перекрестка"},
            { 2000 , "из другой страны"},
        };
        /// <summary>
        /// Получение описания
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public static string GetPriceDescription(double price)
        {
            foreach (var entry in description)
            {
                if (price < entry.Key)
                {
                    return entry.Value;
                }
            }
            return "невозможное значение";
        }
    }
}
