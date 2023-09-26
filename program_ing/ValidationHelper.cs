using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ing
{

    internal class ValidationHelper
    {
        /// <summary>
        /// Проверка на число в диапазоне
        /// </summary>
        /// <param name="value"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <param name="message"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static void CheckRangeValue(double value, double minValue, double maxValue, string message)
        {
            if (value <= minValue || value >= maxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                    string.Format(message, minValue, maxValue));
            }
        }
    }
}
