using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BelovolovVS.Sprint3.Task1.V10.Lib
{
    public class DataService : ISprint3Task1V10
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0;
            int i = startValue;

            while (i <= stopValue)
            {
                sum = sum + Math.Pow(1.0 / (i + Math.Pow(value, i)), i);
                i++;
            }

            return Math.Round(sum, 3);
        }
    }
}