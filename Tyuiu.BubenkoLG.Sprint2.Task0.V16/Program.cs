using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint2.Task0.V16.Lib;


namespace Tyuiu.BubenkoLG.Sprint2.Task0.V16
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            int x = 1025, y = 275;

            bool[] res = new bool[6];

            res = ds.GetCompareOperations(x, y);

            Console.Title = "Спринт #2 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                                ");
            Console.WriteLine("* Тема: Операции сравнения.                                                ");
            Console.WriteLine("* Задание #1                                                               ");
            Console.WriteLine("* Вариант #16                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,          ");
            Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических       ");
            Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):         ");
            Console.WriteLine("* (True, False, True, False, True, False), при x = 1025, y = 275           ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("* X = " + x);
            Console.WriteLine("* Y = " + y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
