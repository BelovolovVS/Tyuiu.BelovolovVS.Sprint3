
using Tyuiu.BelovolovVS.Sprint3.Task2.V24.Lib;

namespace Tyuiu.BelovolovVS.Sprint3.Task2.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Беловолов В. С. | Группа: ПИНб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Беловолов В.С.                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить произведение ряда при a = 0.25                                *");
            Console.WriteLine("* P = произведение от k = 1 до 8: (a^k + 4) * cos(a)                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double value = 0.25;
            int startValue = 1;
            int stopValue = 8;

            Console.WriteLine($"Переменная a = {value}");
            Console.WriteLine($"Старт шага   = {startValue}");
            Console.WriteLine($"Конец шага   = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            Console.WriteLine($"Произведение P = {res}");

            Console.ReadKey();
        }
    }
}
