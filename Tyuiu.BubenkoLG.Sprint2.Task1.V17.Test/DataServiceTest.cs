﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint2.Task1.V17.Lib;

namespace Tyuiu.BubenkoLG.Sprint2.Task1.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {

            DataService ds = new DataService();

            int a = 135, b = 123, c = 455, d = 321;

            bool[] res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, false, true, true, true, false };

            CollectionAssert.AreEqual(res, wait);

        }
    }
}