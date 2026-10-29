using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BelovolovVS.Sprint3.Task0.V21.Lib;

namespace Tyuiu.BelovolovVS.Sprint3.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            
            double value = 1.5;
            int startValue = 1;
            int stopValue = 13;
            
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double expected = -63.727; 

            Assert.AreEqual(expected, res);
        }
    }
}