namespace Mutiples3sAnd5s
{
    public class Challenge1_Multiple3sAnd5s
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Multiples3sAnd5s");

            int sum = 0;

            for (int num = 1; num < 1000; num++)
            {
                if (num % 3 == 0 || num % 5 == 0)
                {
                    sum += num;

                }
            }

            Console.WriteLine(sum);
        }
    }
}