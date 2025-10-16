using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint2.Task5.V14.Lib;

namespace Tyuiu.BubenkoLG.Sprint2.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {

            DataService ds = new DataService();

            

            Assert.AreEqual("Понедельник", ds.FindDayName(6, 3));
            Assert.AreEqual("Вторник", ds.FindDayName(28, 3));
            Assert.AreEqual("Среда", ds.FindDayName(43, 3));
            Assert.AreEqual("Четверг", ds.FindDayName(37, 3));
            Assert.AreEqual("Пятница", ds.FindDayName(52, 3));
            Assert.AreEqual("Суббота", ds.FindDayName(60, 3));
            Assert.AreEqual("Воскресенье", ds.FindDayName(61, 3));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(-1,-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(366, 8);
            });


        }

    }
}