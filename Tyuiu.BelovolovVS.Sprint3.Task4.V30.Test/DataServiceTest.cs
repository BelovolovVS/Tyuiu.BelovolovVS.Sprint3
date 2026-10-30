using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BelovolovVS.Sprint3.Task2.V30.Lib;

namespace Tyuiu.BelovolovVS.Sprint3.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double value = 0; // не используется
            int startValue = -5;
            int stopValue = 5;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 1.924;

            Assert.AreEqual(wait, res);
        }
    }
}