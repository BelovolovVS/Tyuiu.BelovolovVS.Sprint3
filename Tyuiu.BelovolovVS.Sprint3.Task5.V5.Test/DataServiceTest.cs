using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BelovolovVS.Sprint3.Task5.V5.Lib;

namespace Tyuiu.BelovolovVS.Sprint3.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            double wait = 98.286; 
            double res = ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2);

            Assert.AreEqual(wait, res);
        }
    }
}