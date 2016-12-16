using System;

namespace HackerRank
{
    internal class Program
    {
        private static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                
                for (int j = 0; j < a.Length-1; j++)
                {
                    if (a[j] > a[j+1])
                    {
                        Swap(ref a[j], ref a[j+1]);
                        sum++;
                    }
                }
                if (sum ==0)
                {
                    break;
                }
            }

            
            Console.WriteLine("Array is sorted in " + sum + " swaps.");
            Console.WriteLine("First Element: " + a[0]);
            Console.WriteLine("Last Element: " + a[a.Length-1]);

        }
        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }



    }
}