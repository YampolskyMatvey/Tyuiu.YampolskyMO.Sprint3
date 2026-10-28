using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YampolskyMO.Sprint3.Task7.V2.Lib
{
    public class DataService : ISprint3Task7V2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Abs(x - 0.7) < 0.0001)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double y = (Math.Cos(x) / (x - 0.7)) - (Math.Sin(x) * 12 * x) + 2;
                    valueArray[count] = Math.Round(y, 2);
                }
                count++;
            }
            return valueArray;
        }
    }
}