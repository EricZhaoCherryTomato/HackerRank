using System;

namespace HackerRank
{
    internal class Program
    {
        private static void Main()
        {
            var actualReturn = Console.ReadLine()?.Split(' ');
            var expectedReturn = Console.ReadLine()?.Split(' ');

            var diffYear = Convert.ToInt32(actualReturn?[2]) - Convert.ToInt32(expectedReturn?[2]);

            if (Convert.ToInt32(actualReturn?[2]) > Convert.ToInt32(expectedReturn?[2]))
            {
                Console.WriteLine("10000");
            }
            else if ((Convert.ToInt32(actualReturn?[1]) > Convert.ToInt32(expectedReturn?[1])) && diffYear == 0)
            {
                var r =(Convert.ToInt32(actualReturn?[1]) - Convert.ToInt32(expectedReturn?[1])) * 500;
                Console.WriteLine(r);
            }
            else if ((Convert.ToInt32(actualReturn?[0]) > Convert.ToInt32(expectedReturn?[0])) && diffYear == 0)
            {
                var r = (Convert.ToInt32(actualReturn?[0]) - Convert.ToInt32(expectedReturn?[0])) * 15;
                Console.WriteLine(r);
            }
            else
            {
                Console.WriteLine(0);
            }
            
            }
        }
    }
