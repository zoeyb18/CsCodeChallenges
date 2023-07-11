namespace Mutiples3sAnd5s
{
    internal class Challenge1_Multiple3sAnd5s
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int sum = FindSum();
            Console.WriteLine("Sum of all multiples of 3 or 5 below 1000: " + sum);
        }
        static int FindSum()
        {
            int total = 0;
            for (int num = 1; num < 1000; num++)
            {
                if (num %3 == 0 || num %5 == 0)
                {
                    total =+num;
                }
            }
            return total;
        }
    }
}