using System;

namespace HackerRank
{
    internal class Program
    {
        private static void Main()
        {
            int[] vInt = {1, 2, 3};
            string[] vString = {"Hello", "World"};

            printArray<int>(vInt);
            printArray<string>(vString);
        }

        private static void printArray<T>(T[] vArray)
        {
            foreach (var t in vArray)
            {
                Console.WriteLine(t);
            }
        }
    }
}