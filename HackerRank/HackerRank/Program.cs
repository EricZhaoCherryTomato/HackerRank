using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HackerRank
{
    internal class Program
    {
        private static void Main()
        {
            var N = Convert.ToInt32(Console.ReadLine());
            var pattern = ".+@gmail\\.com$";
            var rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            var r = new List<string>();
            for (var a0 = 0; a0 < N; a0++)
            {
                var tokens_firstName = Console.ReadLine().Split(' ');
                var firstName = tokens_firstName[0];
                var emailID = tokens_firstName[1];

                var matcher = rgx.Match(emailID);
                if (matcher.Success)
                {
                    r.Add(firstName);
                }
            }
            r.Sort();
            foreach (var email in r)
            {
                Console.WriteLine(email);
            }
           
        }
    }
}