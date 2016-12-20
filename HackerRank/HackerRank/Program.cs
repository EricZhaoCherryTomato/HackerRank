using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HackerRank
{
    internal class Program
    {
        private static void Main()
        {
            //print all the odd number using bitwise operation
            for (int i = 0; i < 100; ++i)
            {
                if ((i & 1) == 1)
                {
                     Console.WriteLine(i);
                }
            }
        }
    }
}