using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BelovolovVS.Sprint3.Task6.V27.Lib;

namespace Tyuiu.BelovolovVS.Sprint3.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 14;
            int stopValue = 20;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int expected = 129;

            Assert.AreEqual(expected, res);
        }
    }
}