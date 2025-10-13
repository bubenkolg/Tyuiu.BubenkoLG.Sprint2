using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BubenkoLG.Sprint2.Task3.V11.Lib
{
    public class DataService : ISprint2Task3V11
    {
        public double Calculate(double x)
        {
            if (x > 0)
            {
                return Math.Round(x + Math.Pow((x - 15) / (x - 19), x),3);
            }
            else if (x == 0)
            {
                return Math.Round((x*x - Math.Cos(x*x) + 10)/(x*x - Math.Sin(x*x) + 12),3);
            }
            else if (x > -15 & x < 0)
            {
                return Math.Round(Math.Pow(1 + (1 / (x * x)), x),3);
            }
            else
            {
                return Math.Round(x + 10 * x - (1 / x),3);
            }
        }
    }
}
