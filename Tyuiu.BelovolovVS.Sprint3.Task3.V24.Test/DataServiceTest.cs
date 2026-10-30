using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BelovolovVS.Sprint3.Task3.V24.Lib;

namespace Tyuiu.BelovolovVS.Sprint3.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharInString()
        {
            DataService ds = new DataService();
            string str = "gft hggt ntg";
            char replaceable = 'g';
            char replacement = '*';
            string expected = "*ft h**t nt*";

            string res = ds.ReplaceCharInString(str, replaceable, replacement);

            Assert.AreEqual(expected, res);
        }
    }
}