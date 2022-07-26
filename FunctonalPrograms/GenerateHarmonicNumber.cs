using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctonalPrograms
{
    internal class GenerateHarmonicNumber
    {
        public int HarmonicNumber(int N)
        {
            //variables
            float harmonic = 1;
            //check N != 0
            if (N <= 0)
            {
                Console.WriteLine("Harmonic Number for "+N+" is: 0");
                return 0;
            }
            // generate Harmonic number for N

            for (int i = 2; i <= N; i++)
            {
                harmonic += (float)1 / i;

            }
            Console.WriteLine($"= {harmonic}");
            return 0;
        }
    }
}
