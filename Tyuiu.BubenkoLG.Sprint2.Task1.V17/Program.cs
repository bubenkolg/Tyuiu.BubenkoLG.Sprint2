using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint2.Task1.V17.Lib;


namespace Tyuiu.BubenkoLG.Sprint2.Task1.V17
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            int a = 135, b = 123, c = 455, d = 321;

            Console.Title = "Спринт #2 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                                ");
            Console.WriteLine("* Тема: Логические операции.                                               ");
            Console.WriteLine("* Задание #1                                                               ");
            Console.WriteLine("* Вариант #17                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,          ");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в          ");
            Console.WriteLine("* выражении) и логических операций(|, &, ||, &&, !, ^, последовательность  ");
            Console.WriteLine("* операций не должна нарушаться), а также арифметических выражений,        ");
            Console.WriteLine("* которая вернет логическую последовательность(массив): (True, False, True,");
            Console.WriteLine("* True, True, False), при a = 135, b = 123, c = 455, d = 321.              ");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("* A = " + a);
            Console.WriteLine("* B = " + b);
            Console.WriteLine("* C = " + c);
            Console.WriteLine("* D = " + d);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            bool[] res = ds.GetLogicOperations(a, b, c, d);

            for (var i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
