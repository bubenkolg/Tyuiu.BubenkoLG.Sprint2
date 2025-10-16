using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint2.Task6.V6.Lib;

namespace Tyuiu.BubenkoLG.Sprint2.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {

            DataService ds = new DataService();



            Assert.AreEqual("Дама пик", ds.FindCardNameAndValue(1, 12));
            

            /*Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(-1, 5);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(5, 15);
            });*/


        }

    }
}