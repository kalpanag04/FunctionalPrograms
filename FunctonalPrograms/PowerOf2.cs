using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctonalPrograms
{
    internal class PowerOf2
    {
        public int CheckPower(int power)
        {
            if (power < 0 || power > 31)
            {
                Console.WriteLine("invalid power N");
                return 0;
            }
            int number, num = 1;
            for (number = 0; number <= power; number++)
            {
                if (number == 0)
                {
                    Console.WriteLine($"2^{number}={1}");
                    continue;
                }
                num *= 2;
                Console.WriteLine($"2^{number}={num}");
            }
            return 0;
        }
    }

}
