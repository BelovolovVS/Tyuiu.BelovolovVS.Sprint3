using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BelovolovVS.Sprint3.Task5.V5.Lib
{
    public class DataService : ISprint3Task5V5
    {
        public double GetSumSumSeries(int x, int startValue1, int stopValue1, int startValue2, int stopValue2)
        {
            double sumSeries = 0;

            int iStart = Math.Min(startValue1, stopValue1);
            int iStop = Math.Max(startValue1, stopValue1);
            int kStart = Math.Min(startValue2, stopValue2);
            int kStop = Math.Max(startValue2, stopValue2);

            for (int i = iStart; i <= iStop; i++)
            {
                for (int k = kStart; k <= kStop; k++)
                {
                    sumSeries += (double)x / Math.Sin(k);
                }
            }

            return Math.Round(sumSeries, 3);
        }
    }
}