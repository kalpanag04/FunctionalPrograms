using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctonalPrograms
{
    internal class GeneratePrimeFactorization
    {
        public void PrimeFactor(int number)
        {
            //number should be greater than 1.
            while (number % 2 == 0)
            {
                Console.Write(2 + " ");
                number /= 2;
            }

            for (int i = 3; i <= number; i++)
            {
                while (number % i == 0)
                {
                    Console.Write(i + " ");

                    number /= i;
                }
            }

            if (number > 2)
            {
                Console.Write(number);
            }

        }
    }
}
