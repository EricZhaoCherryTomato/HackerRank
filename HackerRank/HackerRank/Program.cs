﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HackerRank
{
    internal class Program
    {
        //Input Format
        //The first line contains two space-separated integers denoting the respective values of(the number of integers) and(the number of left rotations you must perform). 
        //The second line contains  space-separated integers describing the respective elements of the array's initial state.

        //Output Format
        //Print a single line of space-separated integers denoting the final state of the array after performing left rotations.
        private static void Main()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int[] r = new int[n];

            r = rotateArray(a, k);

            foreach (var i in r)
            {
                Console.Write(i + " ");
            }

        }

        public static int[] rotateArray(int[] arr, int d)
        {
            // Because the constraints state d < n, we need not concern ourselves with shifting > n units.
            int n = arr.Length;

            // Create new array for rotated elements:
            int[] rotated = new int[n];

            // Copy segments of shifted elements to rotated array:
            Array.Copy(arr, d, rotated, 0, n - d);
            Array.Copy(arr, 0, rotated, n - d, d);

            return rotated;
        }
    }
}