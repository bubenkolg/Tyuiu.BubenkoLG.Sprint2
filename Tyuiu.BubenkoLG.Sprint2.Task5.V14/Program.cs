using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint2.Task5.V14.Lib;


namespace Tyuiu.BubenkoLG.Sprint2.Task5.V14
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();



            Console.Title = "Спринт #2 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                                ");
            Console.WriteLine("* Тема: Оператор switch.                                                   ");
            Console.WriteLine("* Задание #1                                                               ");
            Console.WriteLine("* Вариант #14                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Дано целое число k (1 <= k <= 365). Определить, каким днем недели        "); 
            Console.WriteLine("* (понедельником, вторником, …, субботой или воскресеньем) является        ");             
            Console.WriteLine("* k-й день не високосного года, в котором 1 января d-й день недели         ");
            Console.WriteLine("* (если 1 января — понедельник, то d = 1 , если вторник — d = 2 , …,       ");
            Console.WriteLine("* если воскресенье — d = 7).                                               ");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("Введите значение k:");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение d:");
            int d = Convert.ToInt32(Console.ReadLine());

            string res;

            if (k < 1 | k > 365 | d < 1 | d > 7)
            {
                res = "Введено неверное значение.";
            }
            else
            {
                res = "Это день недели: " + ds.FindDayName(k, d);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}