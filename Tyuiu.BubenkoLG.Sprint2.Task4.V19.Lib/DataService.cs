using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BubenkoLG.Sprint2.Task4.V19.Lib
{
    public class DataService : ISprint2Task4V19
    {
        public double Calculate(double x, double y)
        {
            //double z = (x / 2) < (y - 6) ? Math.Pow(6 + (4 / (y * y)), x) : (x * x - Math.Pow(Math.Cos(y), 2) + 10) / (y * y - Math.Pow(Math.Cos(y), 2) + 12);
            double z = (x / 2) < (y - 6) ? Math.Pow(6 + (4 / (y * y)), x) : (x * x - Math.Cos(y*y) + 10) / (y * y - Math.Cos(y*y) + 12);
            return Math.Round(z,3);
        }
    }
}
