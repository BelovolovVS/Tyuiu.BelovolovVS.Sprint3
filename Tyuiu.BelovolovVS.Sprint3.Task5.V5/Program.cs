using System;
using Tyuiu.BelovolovVS.Sprint3.Task5.V5.Lib;

namespace Tyuiu.BelovolovVS.Sprint3.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Беловолов В. С. | Вариант 5";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* СПРИНТ #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Беловолов Вячеслав Сергеевич | АСОиУб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение двойной суммы ряда при X = 5                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            Console.WriteLine("Переменная X = " + x);
            Console.WriteLine("Старт шага первого цикла (i) = " + startValue1);
            Console.WriteLine("Конец шага первого цикла (i) = " + stopValue1);
            Console.WriteLine("Старт шага второго цикла (k) = " + startValue2);
            Console.WriteLine("Конец шага второго цикла (k) = " + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2);

            Console.WriteLine("Сумма двойного ряда = " + res);
            Console.ReadKey();
        }
    }
}
