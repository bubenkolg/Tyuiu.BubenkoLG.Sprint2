using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint2.Task0.V16.Lib;

namespace Tyuiu.BubenkoLG.Sprint2.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();

            bool[] res = new bool[6];

            int x = 1025;
            int y = 275;

            res = ds.GetCompareOperations(x, y);

            bool[] wait = new bool[6] { true, false, true, false, true, false };

            CollectionAssert.AreEqual(wait, res);

        }
    }
}
