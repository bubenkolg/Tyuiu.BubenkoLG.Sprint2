﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint2.Task3.V11.Lib;


namespace Tyuiu.BubenkoLG.Sprint2.Task3.V11
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();



            Console.Title = "Спринт #2 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                                ");
            Console.WriteLine("* Тема: вложенные операторы if - else.                                     ");
            Console.WriteLine("* Задание #1                                                               ");
            Console.WriteLine("* Вариант #11                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с     ");
            Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит       ");
            Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение        ");
            Console.WriteLine("* до трех знаков после запятой.                                            ");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            double res = ds.Calculate(x);

            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();
        }
    }
}