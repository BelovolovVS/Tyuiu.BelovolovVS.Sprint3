using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BelovolovVS.Sprint3.Task0.V27.Lib;

namespace Tyuiu.BelovolovVS.Sprint3.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int value = 9;
            int startValue = 14;
            int stopValue = 20;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double expected = 129;

            Assert.AreEqual(expected, res);
        }
    }
}