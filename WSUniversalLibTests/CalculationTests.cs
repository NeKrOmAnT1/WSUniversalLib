using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WSUniversalLib.Tests
{
    [TestClass()]
    public class CalculationTests
    {
        [TestMethod()]
        public void GetQuantityForProductTest_114148()
        {
            //подготовка
            Calculation calculation1= new Calculation();
            int typeProduct = 3;
            int typeMaterial = 1;
            int count = 15;
            float width = 20f;
            float length = 45f;

            int expected = 114148;
            //тест
            var actual = calculation1.GetQuantityForProduct(typeProduct, typeMaterial, count, width, length);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void GetQuantityForProductTest_bad_tp()
        {
            //подготовка
            Calculation calculation1= new Calculation();
            int typeProduct = -3;
            int typeMaterial = 1;
            int count = 15;
            float width = 20f;
            float length = 45f;

            int expected = -1;
            //тест
            var actual = calculation1.GetQuantityForProduct(typeProduct, typeMaterial, count, width, length);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void GetQuantityForProductTest_bad_tm()
        {
            //подготовка
            Calculation calculation1 = new Calculation();
            int typeProduct = 3;
            int typeMaterial = -4;
            int count = 15;
            float width = 20f;
            float length = 45f;

            int expected = -1;
            //тест
            var actual = calculation1.GetQuantityForProduct(typeProduct, typeMaterial, count, width, length);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void GetQuantityForProductTest_bad_c()
        {
            //подготовка
            Calculation calculation1 = new Calculation();
            int typeProduct = 3;
            int typeMaterial = 1;
            int count = -29;
            float width = 20f;
            float length = 45f;

            int expected = -1;
            //тест
            var actual = calculation1.GetQuantityForProduct(typeProduct, typeMaterial, count, width, length);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void GetQuantityForProductTest_bad_w()
        {
            //подготовка
            Calculation calculation1 = new Calculation();
            int typeProduct = 3;
            int typeMaterial = 1;
            int count = 15;
            float width = -20f;
            float length = 45f;

            int expected = -1;
            //тест
            var actual = calculation1.GetQuantityForProduct(typeProduct, typeMaterial, count, width, length);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void GetQuantityForProductTest_bad_l()
        {
            //подготовка
            Calculation calculation1 = new Calculation();
            int typeProduct = 3;
            int typeMaterial = 1;
            int count = 15;
            float width = 20f;
            float length = -45f;

            int expected = -1;
            //тест
            var actual = calculation1.GetQuantityForProduct(typeProduct, typeMaterial, count, width, length);
            Assert.AreEqual(expected, actual);

        }
    }
}