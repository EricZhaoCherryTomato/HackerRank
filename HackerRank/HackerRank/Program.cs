using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace HackerRank
{
    internal class Program
    {
        public static List<int> base2 = new List<int>();

        private static void Main()
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.ComputeDifference();

            Console.Write(d.maximumDifference);


        }

        private class Difference
        {
            private int[] _elements;
            public int maximumDifference;

            public Difference(int[] a)
            {
                _elements = a;
            }

            public void ComputeDifference()
            {
                var r = new List<int>();
                maximumDifference = Math.Abs(_elements.Max()-_elements.Min());
            }
        }
    }
}