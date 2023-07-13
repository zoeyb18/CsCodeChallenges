using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Mutiples3sAnd5s
{
    public class TenDigitFibonacci
    {
        static void Main(string[] args)
        {

            int index = 0;
            int value1 = 1;
            int value2 = 1;
            int temp = 0;

            do
            {
                index++;

                temp = value2;
                value2 += value1;
                value1 = temp;
            } while (value2 < 100000000);

            Console.WriteLine($"The index of the first number with 10 digits is {index} ");
          
            
        }
    }
}
