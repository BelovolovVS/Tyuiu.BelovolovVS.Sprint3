using System;

namespace Tyuiu.BelovolovVS.Sprint3.Task5.V5.Lib
{
    public class DataService
    {
        public double GetSumSumSeries(int x, int startValue1, int stopValue1, int startValue2, int stopValue2)
        {
            double sumSeries = 0;

            for (int i = startValue1; i <= stopValue2; i++)
            {
                for (int k = startValue2; k <= stopValue1; k++)
                {
                    sumSeries += (double)x / Math.Sin(k);
                }
            }

            return Math.Round(sumSeries, 3);
        }
    }
}