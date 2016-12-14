using System;

namespace HackerRank
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var r = Factorial(n);
            Console.WriteLine(r);
        }

        public static long Factorial(int n)
        {
            if (n != 1)
            {
                return n*Factorial(n - 1);
            }
            return n;
        }
    }
}