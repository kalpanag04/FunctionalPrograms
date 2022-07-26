using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctonalPrograms
{
    internal class CheckLargest
    {
        public void Largest(int a, int b, int c)
        {
            Console.WriteLine("a=" + a + " b=" + b + " c=" + c);

            if (a > b && a > c)
            {
                Console.WriteLine("a is greater ");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("b is Greater ");
            }
            else //else if(c>a && c>b)
            {
                Console.WriteLine("c is greater ");
            }
        }

        public void LargestOfThree(int x, int y, int z)
        {
            Console.WriteLine("x= " + x + " y=" + y + " z=" + z);
            if (x > y)
            {
                if (x > z)
                {
                    Console.WriteLine("x is greater ");
                }
                else
                {
                    Console.WriteLine("y is greater");
                }
            }
            else if (y > z)
            {
                Console.WriteLine("y is greater ");
            }
            else
            {
                Console.WriteLine("z is greater ");
            }
        }
    }
}
