using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint2.Task4.V19.Lib;


namespace Tyuiu.BubenkoLG.Sprint2.Task4.V19
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();



            Console.Title = "Спринт #2 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                                ");
            Console.WriteLine("* Тема: Тернарной оператор.                                                ");
            Console.WriteLine("* Задание #1                                                               ");
            Console.WriteLine("* Вариант #19                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с               ");
            Console.WriteLine("* использованием тернарного оператора, где пользователь вводит             ");
            Console.WriteLine("* значение переменной x, y с клавиатуры, если x / 2 < y - 6, то            ");            
            Console.WriteLine("*                     2         2                                          ");
            Console.WriteLine("*          4         x  - cos(y)  + 10                                     ");
            Console.WriteLine("* z = (6 + --) иначе ---------------------. Результат округлить до 3 знаков");
            Console.WriteLine("*           2         2         2           после запятой.                 ");
            Console.WriteLine("*          y         y  - sin(y)  + 12                                     ");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            double y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            double res = ds.Calculate(x,y);

            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();
        }
    }
}