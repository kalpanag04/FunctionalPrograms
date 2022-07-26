using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctonalPrograms
{
    internal class Swap
    {
        public void SwapNumbersByTemp(int a, int b)
        {
            Console.WriteLine("Before Swaping : a=" + a + " b=" + b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swaping : a=" + a + " b=" + b);
            Console.WriteLine("                   ");
        }


        public void SwapNumbersbyAddSub(int x, int y)
        {
            Console.WriteLine("Before swaping : x=" + x + " y=" + y);
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("After swaping : x=" + x + " y=" + y);
            Console.WriteLine("                    ");
        }


        public void SwapNumbersbyMulDiv(int m, int n)
        {
            Console.WriteLine("Before swaping : m=" + m + " n=" + n);
            m = m * n;
            n = m / n;
            m = m / n;
            Console.WriteLine("After swaping : m=" + m + " n=" + n);
        }
    }
}
