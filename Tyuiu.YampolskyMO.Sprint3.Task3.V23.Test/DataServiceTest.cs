using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.YampolskyMO.Sprint3.Task3.V23.Lib;

namespace Tyuiu.YampolskyMO.Sprint3.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            DataService ds = new DataService();

            string str = "fdsst siu vsrs";
            char chr = 's';
            char rep = '8';

            string res = ds.ReplaceCharOnNum(str, chr, rep);
            string wait = "fd88t 8iu v8r8";

            Assert.AreEqual(wait, res);
        }
    }
}