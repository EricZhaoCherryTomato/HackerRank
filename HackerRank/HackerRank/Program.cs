using System;
using System.Collections.Generic;

namespace HackerRank
{
    internal class Program
    {
        public static List<int> base2 = new List<int>();

        private static void Main()
        {
            var inputs = Console.ReadLine().Split();
            var firstName = inputs[0];
            var lastName = inputs[1];
            var id = Convert.ToInt32(inputs[2]);
            var numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            var scores = new int[numScores];
            for (var i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            var s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }

        private class Student : Person
        {
            private readonly int[] _testScores;

            public Student(string firstName, string lastName, int identification, int[] scores) : base(firstName, lastName, identification)
            {
                _testScores = scores;
            }

            public string Calculate()
            {
                var r = new int();
                foreach (int t in _testScores)
                {
                    r += t;
                }
                var average = r/_testScores.Length;
                if (average <= 100 && average >= 90)
                {
                    return "O";
                }
                if (average < 90 && average >= 80)
                {
                    return "E";
                }
                if (average < 80 && average >= 70)
                {
                    return "A";
                }
                if (average < 70 && average >= 55)
                {
                    return "P";
                }
                if (average < 55 && average >= 40)
                {
                    return "D";
                }

                return "T";
            }
        }

        private class Person
        {
            protected readonly string firstName;
            protected readonly string lastName;
            protected readonly int id;

            public Person()
            {
            }

            public Person(string firstName, string lastName, int identification)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                id = identification;
            }

            public void printPerson()
            {
                Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
            }
        }
    }
}