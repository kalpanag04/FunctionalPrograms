using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctonalPrograms
{
    internal class CheckAlphabet
    {
        public void CheckVowel(char j)
        {
            if (j == 'a' || j == 'e' || j == 'i' || j == 'o' || j == 'u')
            {
                Console.WriteLine(j + " is Vowel ");
            }
            else
            {
                Console.WriteLine(j + " is Consonent");
            }
        }
    }
}
