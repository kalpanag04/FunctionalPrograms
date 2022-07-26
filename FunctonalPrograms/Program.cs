using System;

namespace FunctonalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("              Welcome to Basic Core Programs        ");

            while (true)
            {
                Console.WriteLine("|--------------------------------------------------|");
                Console.WriteLine("| Press 1. for Flip coin.                          |");
                Console.WriteLine("| Press 2. for Leap year.                          |");
                Console.WriteLine("| Press 3. for Power of 2.                         |");
                Console.WriteLine("| Press 4. for Harmonic Number.                    |");
                Console.WriteLine("| Press 5. for Prime factorization of N.           |");
                Console.WriteLine("| Press 6. to Compute Qoutient & Remainder.        |");
                Console.WriteLine("| Press 7. Swap two numbers.                       |");
                Console.WriteLine("| Press 8. to check Number odd or even.            |");
                Console.WriteLine("| Press 9. Whether alphabet is vowel or Consonant. |");
                Console.WriteLine("| Press 10. to check Largest amont three numbers.  |");
                Console.WriteLine("| Press 11. To Exit.                               |");
                Console.WriteLine("|--------------------------------------------------|");
                Console.WriteLine(" Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.PercentageFlips(10);
                        break;
                    case 2:
                        LeapYear leap = new LeapYear();
                        leap.CheckLeapYear(2004);
                        break;
                    case 3:
                        PowerOf2 pow = new PowerOf2();
                        pow.CheckPower(12);
                        break;
                    case 4:
                        GenerateHarmonicNumber harmonic = new GenerateHarmonicNumber();
                        harmonic.HarmonicNumber(8);
                        break;
                    case 5:
                        GeneratePrimeFactorization prime = new GeneratePrimeFactorization();
                        prime.PrimeFactor(23);
                        break;
                    case 6:
                        QuotientNdRemainder qnr = new QuotientNdRemainder();
                        qnr.Divide(315, 3);
                        break;
                    case 7:
                        Swap num = new Swap();
                        num.SwapNumbersByTemp(5, 10);
                        num.SwapNumbersbyAddSub(2, 7);
                        num.SwapNumbersbyMulDiv(5, 10);
                        break;
                    case 8:
                        EvenOdd evenOdd = new EvenOdd();
                        Console.WriteLine("Enter a number : ");
                        int i = Convert.ToInt32(Console.ReadLine());
                        evenOdd.CheckOddEven(i);
                        break;
                    case 9:
                        CheckAlphabet checkAlphabet = new CheckAlphabet();
                        Console.WriteLine("Enter an Alphabet : ");
                        char j = Convert.ToChar(Console.ReadLine());
                        checkAlphabet.CheckVowel(j);
                        break;
                    case 10:
                        CheckLargest checkLargest = new CheckLargest();
                        checkLargest.Largest(10, 20, 30);
                        checkLargest.LargestOfThree(100, 200, 300);
                        break;
                    case 11:
                        Console.WriteLine("Exit");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("invalid selection made.");
                        break;
                }
            }

        }
    }
}

