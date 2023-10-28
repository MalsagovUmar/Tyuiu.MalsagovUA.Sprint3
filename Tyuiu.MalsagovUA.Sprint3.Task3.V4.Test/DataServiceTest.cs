using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalsagovUA.Sprint3.Task3.V4.Lib;
namespace Tyuiu.MalsagovUA.Sprint3.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            DataService ds = new DataService();
            string str = "plkjjdw cvjkl";
            char letter = 'j';
            string res = ds.DeleteCharInString(str, letter);
            string wait = "plkdw cvkl";
            Assert.AreEqual(wait, res);
        }
    }
}
