using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalsagovUA.Sprint3.Task1.V17.Lib;
namespace Tyuiu.MalsagovUA.Sprint3.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 4;
            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = 482982.891;
            Assert.AreEqual(wait, res);
        }
    }
}
