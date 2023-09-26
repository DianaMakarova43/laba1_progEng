using Microsoft.VisualStudio.TestTools.UnitTesting;
using App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace App.Tests
{
    /// <summary>
    /// Тестирование
    /// </summary>
    [TestClass()]
    public class PriceCalculatorTests
    {
        /// <summary>
        /// Валидный тест
        /// </summary>
        /// <param name="price"></param>
        /// <param name="Colbasa"></param>
        /// <param name="Hleb"></param>
        [TestMethod()]
        [DataRow(300, 250, 50)]
        [DataRow(1890, 1800, 90)]
        [DataRow(80, 60, 20)]

        public void GetPriceTest(double price, double Colbasa, double Hleb)
        {
            var _price = PriceCalculator.GetPrice(Colbasa, Hleb);
            
            Assert.AreEqual(price, _price);
        }

        /// <summary>
        /// Невалидный тест
        /// </summary>
        /// <param name="price"></param>
        /// <param name="Colbasa"></param>
        /// <param name="Hleb"></param>
        [TestMethod()]
        [DataRow(300, 25000, 50)]
        [DataRow(1890, 18000, 90)]
        [DataRow(80, 6000, 20)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void GetPriceInvalidTest(double price, double Colbasa, double Hleb)
        {
            var _price = PriceCalculator.GetPrice(Colbasa, Hleb);

            Assert.AreEqual(price, _price);
        }
    }
}