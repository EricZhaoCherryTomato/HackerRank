using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    internal class Program
    {
        public static List<int> base2 = new List<int>();

        private static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());

            var r = DecimalToBase2(n);

            var index = 1;
            var counter = new List<int>();
            for (var i = 1; i < r.Count; i++)
            {
                if (r[i] - r[i - 1] == 0)
                {
                    index++;
                    counter.Add(index);
                }
                else
                {
                    counter.Add(index);
                    index = 1;
                }
            }
            Console.WriteLine(counter.Max());
        }

        public static List<int> DecimalToBase2(int n)
        {
            if (n != 0)
            {
                base2.Add(n%2 != 0 ? 1 : 0);
                return DecimalToBase2(n/2);
            }
            return base2;
        }
    }
}