using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BelovolovVS.Sprint3.Task4.V30.Lib
{
    public class DataService : ISprint3Task4V30
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }
                
                sum += Math.Sin(x) + 0.25;
            }

            return Math.Round(sum, 3);
        }
    }
}