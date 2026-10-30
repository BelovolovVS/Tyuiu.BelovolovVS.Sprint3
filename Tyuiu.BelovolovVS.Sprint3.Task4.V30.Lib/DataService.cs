using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BelovolovVS.Sprint3.Task2.V30.Lib
{
    public class DataService : ISprint3Task2V30
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double sum = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                    continue;

                sum = sum + Math.Sin(x) / x;
            }

            return Math.Round(sum, 3);
        }
    }
}