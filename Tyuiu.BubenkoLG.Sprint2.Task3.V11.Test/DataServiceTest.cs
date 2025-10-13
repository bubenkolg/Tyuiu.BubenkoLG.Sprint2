using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint2.Task3.V11.Lib;

namespace Tyuiu.BubenkoLG.Sprint2.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {

            DataService ds = new DataService();

            double x = 10.0;
            double res = ds.Calculate(x);
            double wait = Math.Round(10.002800753897258,3);

            Assert.AreEqual(res, wait);

        }
        public void ValidCondition2()
        {

            DataService ds = new DataService();

            double x = 0;
            double res = ds.Calculate(x);
            double wait = Math.Round(0.9166666666666666,3);

            Assert.AreEqual(res, wait);

        }
        public void ValidCondition3()
        {

            DataService ds = new DataService();

            double x = -1.0;
            double res = ds.Calculate(x);
            double wait = 2.0;

            Assert.AreEqual(res, wait);

        }
        public void ValidCondition4()
        {

            DataService ds = new DataService();

            double x = -16.0;
            double res = ds.Calculate(x);
            double wait = Math.Round(-175.9375,3);

            Assert.AreEqual(res, wait);

        }
    }
}