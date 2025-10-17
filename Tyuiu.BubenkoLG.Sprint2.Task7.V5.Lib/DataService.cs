using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BubenkoLG.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((y <= Math.Exp(x) && y >= Math.Exp(-x) && x >= 0) || (y <= x * x && y >= 1 && x <= 0) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
