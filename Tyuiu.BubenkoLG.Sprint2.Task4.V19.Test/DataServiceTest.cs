using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint2.Task4.V19.Lib;

namespace Tyuiu.BubenkoLG.Sprint2.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {

            DataService ds = new DataService();

            double x = 10.0;
            double y = 8.0;
            double res = ds.Calculate(x,y); // false
            double wait = Math.Round(1.4474930729556619, 3);

            Assert.AreEqual(res, wait);

        }
        [TestMethod]
        public void ValidCondition2()
        {

            DataService ds = new DataService();

            double x = 0;
            double y = 7.0;
            double res = ds.Calculate(x,y); // true
            double wait = Math.Round(1.0, 3);

            Assert.AreEqual(res, wait);

        }
        
    }
}