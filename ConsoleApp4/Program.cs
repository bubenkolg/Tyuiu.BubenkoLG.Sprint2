using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;

            int y = 0;

            switch (x)

            {

                case -3:

                    case -2:

                        case -1: 
                            y = -x; 
                            break;

                case 0: 
                    y = 5; 
                    break;

                case 3:

                    case 2:

                        case 1: 
                            y = 2 * x; 
                            break;

            }
            Console.WriteLine(y);


        }

        


    }
}


