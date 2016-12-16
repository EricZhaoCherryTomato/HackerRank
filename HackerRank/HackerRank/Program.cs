using System;
using System.Collections.Generic;

namespace HackerRank
{
    internal class Program
    {
        public static List<int> base2 = new List<int>();

        private static void Main()
        {
            string S = Console.ReadLine();
            try
            {
                var r = Convert.ToInt32(S);
                Console.WriteLine(r);
            }
            catch (Exception)
            {
                Console.WriteLine("Bad String");
               
            }
        }
       
    }
}