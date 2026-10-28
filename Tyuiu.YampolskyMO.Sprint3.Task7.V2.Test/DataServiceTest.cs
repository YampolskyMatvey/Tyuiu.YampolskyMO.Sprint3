using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.YampolskyMO.Sprint3.Task7.V2.Lib;

namespace Tyuiu.YampolskyMO.Sprint3.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = (stopValue - startValue) + 1;
            double[] wait = new double[len];

            
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Abs(x - 0.7) < 0.0001)
                {
                    wait[count] = 0;
                }
                else
                {
                    double y = (Math.Cos(x) / (x - 0.7)) - (Math.Sin(x) * 12 * x) + 2;
                    wait[count] = Math.Round(y, 2);
                }
                count++;
            }

            double[] res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}