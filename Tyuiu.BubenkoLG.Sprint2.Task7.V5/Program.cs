using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint2.Task7.V5.Lib;


namespace Tyuiu.BubenkoLG.Sprint2.Task7.V5
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();



            Console.Title = "Спринт #2 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                                ");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту.                 ");
            Console.WriteLine("* Задание #7                                                               ");
            Console.WriteLine("* Вариант #5                                                               ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные            ");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами   ");
            Console.WriteLine("* X,Y в заштрихованной области.                                            ");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("Введите значение x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");


            bool res = ds.CheckDotInShadedArea(x,y);

            if (res == true)
            {
                Console.WriteLine($"Точка с координатами ({x};{y}) находится в заштрихованной области.");
            }
            else
            {
                Console.WriteLine($"Точка с координатами ({x};{y}) не находится в заштрихованной области.");
            }

            
            Console.ReadKey();
        }
    }
}