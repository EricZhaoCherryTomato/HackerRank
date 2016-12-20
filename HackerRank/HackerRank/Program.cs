using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HackerRank
{
    internal class Program
    {
        private static void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);

                int finalResult = 0;
                for (int i = 1; i < n; i++)
                {
                    for (int j = i + 1; j <= n; j++)
                    {
                        int amp = i & j;
                        if (amp < k && amp > finalResult)
                            finalResult = amp;
                    }
                }
                Console.WriteLine(finalResult);
            }

        }
    }
}