using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctonalPrograms
{
    internal class QuotientNdRemainder
    {
        public void Divide(int dividend, int divisor)
        {
            int quotient, remainder;
            quotient = dividend % divisor;
            remainder = dividend / divisor;

            Console.WriteLine("Quotient : " + quotient);
            Console.WriteLine("Reminder : " + remainder);
        }
    }
}
