using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctonalPrograms
{
    internal class FlipCoin
    {
        public double PercentageCalculation(int coins, int numberofTurns)
        {
            double percentage;
            percentage = (coins * 100 / numberofTurns);
            return percentage;
        }
        public int PercentageFlips(int number)
        {
            int numberofTurns = number;
            //checking for positive number
            if (numberofTurns <= 0)
            {
                return 0;
            }
            //variables
            int flips;
            double coinFace;
            int tails = 0, heads = 0;
            const double DECISION = 0.5;
            double percentageTails, percentageHeads;
            //using random class to generate heads and tails
            Random random = new Random();

            for (flips = 1; flips <= numberofTurns; flips++)
            {
                coinFace = random.NextDouble();

                if (coinFace <= DECISION)
                {
                    tails++;
                }
                else
                {
                    heads++;
                }
            }
            percentageTails = PercentageCalculation(tails, numberofTurns);
            percentageHeads = PercentageCalculation(heads, numberofTurns);
            Console.WriteLine($"Percentage of heads: {percentageHeads}%");
            Console.WriteLine($"Percentage of tails: {percentageTails}%");

            return 0;
        }
    }
}

