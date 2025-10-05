using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BubenkoLG.Sprint2.Task1.V17.Lib
{
    public class DataService : ISprint2Task1V17
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c == d); // true
            res[1] = (a < b) & (c != d); // false
            res[2] = (d <= c) || (a == b); // true
            res[3] = (c >= b) && ((a - 12) == b); // true
            res[4] = !((d + 100) < b); // true
            res[5] = (d < c) ^ ((c - 332) == b); // false

            return res;
        }
    }
}
