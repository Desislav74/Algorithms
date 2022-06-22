using System;

namespace Recursive_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(CalFactoriel(n));
        }

        private static int CalFactoriel(int n)
        {
            if (n ==0)
            {
                return 1;
            }

            return n * CalFactoriel(n - 1);
        }
    }
}
