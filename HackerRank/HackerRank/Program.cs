using System;

namespace HackerRank
{
    internal class Program
    {
        private static void Main()
        {
            var n = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                var flag = true;
                var inputs = Convert.ToInt32(Console.ReadLine());
                for (var j = 2; j*j <= inputs; j++)
                {
                    if (inputs%j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (inputs == 1)
                {
                    flag = false;
                }
                if (n == 2)
                {
                    flag = true;
                }
                Console.WriteLine(flag ? "Prime" : "Not prime");
            }
        }
    }
}