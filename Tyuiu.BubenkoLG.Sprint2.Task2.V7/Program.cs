using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint2.Task2.V7.Lib;


namespace Tyuiu.BubenkoLG.Sprint2.Task2.V7
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            

            Console.Title = "Спринт #2 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                                ");
            Console.WriteLine("* Тема: Оператор if - полная и короткая форма записи.                      ");
            Console.WriteLine("* Задание #1                                                               ");
            Console.WriteLine("* Вариант #7                                                               ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры   ");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y                        ");
            Console.WriteLine("* в заштрихованной области.                                                ");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("Введите значение X:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* X = " + x);
            Console.WriteLine("* Y = " + y);
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            bool res = ds.CheckDotInShadedArea(x, y);

            if (res == true)
            {
                Console.WriteLine($"Точка с координатами x = {x} и y = {y} находится в заштрихованной области.");
            }
            else Console.WriteLine($"Точка с координатами x = {x} и y = {y} не находится в заштрихованной области.");

            Console.ReadKey();
        }
    }
}