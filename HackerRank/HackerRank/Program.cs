using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var phoneBook = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                var inputs = Console.ReadLine()?.Split(' ');
                phoneBook.Add(inputs[0], inputs[1]);
            }
            while (n != 0)
            {
                var inputs = Console.ReadLine();
                string value;
                if (phoneBook.TryGetValue(inputs, out value))
                {
                    Console.WriteLine(inputs + "=" + value);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
                n--;
            }
        }
    }
}
