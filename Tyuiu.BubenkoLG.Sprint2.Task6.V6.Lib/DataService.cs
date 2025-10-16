using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BubenkoLG.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int m, int k)
        {


            string res1 = k switch
            {
                6 => "Шестёрка ",
                7 => "Семёрка ",
                8 => "Восьмёрка ",
                9 => "Девятка ",
                10 => "Десятка ",
                11 => "Валет ",
                12 => "Дама ",
                13 => "Король ",
                14 => "Туз ",
                _ => " "

            };
            

            string res2 = m switch
            {
                1 => "пик",
                2 => "трефов",
                3 => "бубнов",
                4 => "червов",
                _ => " "
            };
            return res1 + res2;

        }
    }
}
