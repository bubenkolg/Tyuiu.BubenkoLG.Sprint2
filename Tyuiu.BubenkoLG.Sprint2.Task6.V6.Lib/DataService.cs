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
                6 => "шестёрка ",
                7 => "семёрка ",
                8 => "восьмёрка ",
                9 => "девятка ",
                10 => "десятка ",
                11 => "валет ",
                12 => "дама ",
                13 => "король ",
                14 => "туз ",
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
