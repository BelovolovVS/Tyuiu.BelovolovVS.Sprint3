using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BelovolovVS.Sprint3.Task2.V24.Lib
{
    public class DataService : ISprint3Task2V24
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multiply = 1.0;
            int k = startValue;

            do
            {
                multiply *= (Math.Pow(value, k) + 4) * Math.Cos(value);
                k++;
            }
            while (k <= stopValue);

            return Math.Round(multiply, 3);
        }
    }
}