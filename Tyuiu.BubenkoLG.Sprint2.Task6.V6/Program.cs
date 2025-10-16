using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint2.Task6.V6.Lib;


namespace Tyuiu.BubenkoLG.Sprint2.Task6.V6
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();



            Console.Title = "Спринт #2 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                                ");
            Console.WriteLine("* Тема: Получение результата из switch.                                    ");
            Console.WriteLine("* Задание #1                                                               ");
            Console.WriteLine("* Вариант #6                                                               ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Мастям игральных карт условно присвоены следующие порядковые номера:     ");
            Console.WriteLine("* масти «пики» — 1, масти «трефы» — 2, масти «бубны» — 3,                  ");
            Console.WriteLine("* масти «червы» — 4, а достоинству карт: «валету» — 11, «даме» — 12,       ");
            Console.WriteLine("* «королю» — 13, «тузу» — 14 (порядковые номера карт остальных достоинств  ");
            Console.WriteLine("* соответствуют их названиям: «шестерка», «девятка» и т. п.). По заданным  ");
            Console.WriteLine("* номеру масти m (1 <= m <= 4) и номеру достоинства карты k (6 <= k <= 14) ");
            Console.WriteLine("* определить полное название (масть и достоинство) соответствующей карты   ");
            Console.WriteLine("* в виде «Дама пик», Шестерка бубен» и т. п.                               ");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("Введите значение m:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение k:");
            int k = Convert.ToInt32(Console.ReadLine());

            string res;

            if (m < 1 | m > 4 | k < 6 | k > 14)
            {
                res = "Введено неверное значение.";
            }
            else
            {
                res = ds.FindCardNameAndValue(m, k);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}