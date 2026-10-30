using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BelovolovVS.Sprint3.Task4.V30.Lib
{
    public class DataService : ISprint3Task4V30
    {
        public double Calculate(int startValue, int stopValue)
        {
            if (startValue > stopValue)
            {
                int temp = startValue;
                startValue = stopValue;
                stopValue = temp;
            }

            long sum = 0;
            int count = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                sum += i;
                count++;
            }

            return count == 0 ? 0 : (double)sum / count;
        }
    }
}