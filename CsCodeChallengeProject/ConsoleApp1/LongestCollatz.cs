using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutiples3sAnd5s
{
    public class LongestCollatz
    {
        static void Main(string[] args)
        {
            int longestChain = 1;
            int longestStart = 1;
            int currentChain = 1;
            int currentNumber = 0;
            for (int i = 1; i < 1000; i++)
            {
                currentChain = 1;
                currentNumber = i;
                while (currentNumber != 1)
                {
                    currentChain++;
                    if (currentNumber%2 == 0)
                    {
                        currentNumber /= 2;
                    }
                    else
                    {
                        currentNumber = (3 * currentNumber + 1);
                    }
                }

                if (currentChain > longestChain)
                {
                    longestChain = currentChain;
                    longestStart = i;
                }
            }

            Console.WriteLine($"The Longest Chain with a starting number under 1000 is {longestChain} which occurs when starting with {longestStart}");
        }
    }
}
