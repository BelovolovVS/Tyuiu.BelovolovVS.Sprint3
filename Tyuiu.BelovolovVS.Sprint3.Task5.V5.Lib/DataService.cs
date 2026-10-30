using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BelovolovVS.Sprint3.Task5.V5.Lib
{
    public class DataService : ISprint3Task5V5
    {
        public double GetSumSumSeries(int x, int startValue1, int stopValue1, int startValue2, int stopValue2)
        {
            double sumSeries = 0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    sumSeries += x / Math.Sin(k);
                }
            }

            return Math.Round(sumSeries, 3);
        }
    }
}