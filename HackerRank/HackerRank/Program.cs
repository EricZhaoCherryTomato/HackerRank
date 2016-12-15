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
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            var sum = new List<int>();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    var r = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                            + arr[i + 1][j + 1]
                            + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    sum.Add(r);
                }
            }
            sum.Sort();
            Console.WriteLine(sum[sum.Count-1]);
        }
    }
}