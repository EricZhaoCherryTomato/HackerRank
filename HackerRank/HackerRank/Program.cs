using System;
using System.Collections.Generic;

namespace HackerRank
{
    internal class Program
    {
        public static List<int> base2 = new List<int>();

        private static void Main()
        {
            var myCalculator = new Calculator();
            var T = int.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                var num = Console.ReadLine().Split();
                var n = int.Parse(num[0]);
                var p = int.Parse(num[1]);
                try
                {
                    var ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }

    internal class Calculator
    {
        public int power(int i, int i1)
        {
            if (i < 0 || i1 < 0)
            {
                throw new Exception("n and p should be non-negative");
            }
            var r = Math.Pow(i, i1);
            return (int)r;
        }
    }
}