using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    internal class Program
    {
        private static void Main()
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }

        public interface AdvancedArithmetic
        {
            int divisorSum(int n);
        }

        private class Calculator : AdvancedArithmetic
        {
            public int divisorSum(int n)
            {
                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n%i == 0)
                    {
                        sum += i;
                    }
                }
                return sum;
            }
        }
    }

    
}