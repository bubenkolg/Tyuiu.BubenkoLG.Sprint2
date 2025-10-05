using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint2.Task2.V7.Lib;

namespace Tyuiu.BubenkoLG.Sprint2.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {

            DataService ds = new DataService();

            int x = 12;
            int y = 9;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(res, wait);

        }
    }
}