using System;
using Tyuiu.BelovolovVS.Sprint3.Task3.V24.Lib;

namespace Tyuiu.BelovolovVS.Sprint3.Task3.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Беловолов В. С. | Группа: ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Беловолов В.C.                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить буквы g на * в строке:                  *");
            Console.WriteLine("* gft hggt ntg                                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string str = "gft hggt ntg";
            char replaceable = 'g';
            char replacement = '*';

            Console.WriteLine($"Исходная строка: {str}");
            Console.WriteLine($"Заменяемый символ: {replaceable}");
            Console.WriteLine($"Символ замены: {replacement}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.ReplaceCharInString(str, replaceable, replacement);

            Console.WriteLine($"Результат: {res}");
            Console.ReadKey();
        }
    }
}