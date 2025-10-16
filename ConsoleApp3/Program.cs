using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            int z = 1; switch (2 * x)

            {

                case 1:

                    z = 10;

                    break;

                case 2:

                    z *= x;

                    break;

                case 4:

                    z += x + 5;

                    break;

                case 6:

                case 8:

                    z = 3;

                    break;

                default:

                    z = 0;

                    break;

            }
            Console.WriteLine(z);
        }
    }
}
