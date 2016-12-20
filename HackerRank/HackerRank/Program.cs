using System;

namespace HackerRank
{
    internal class Program
    {
        private static void Main()
        {
            var actualReturn = Console.ReadLine()?.Split(' ');
            var expectedReturn = Console.ReadLine()?.Split(' ');

            var actualReturnDate = new BookReturnDate(Convert.ToInt32(actualReturn?[0]), Convert.ToInt32(actualReturn?[1]), Convert.ToInt32(actualReturn?[2]));
            var expectReturnDate = new BookReturnDate(Convert.ToInt32(expectedReturn?[0]), Convert.ToInt32(expectedReturn?[1]), Convert.ToInt32(expectedReturn?[2]));

            var fine = 0;

            if (actualReturnDate.Year == expectReturnDate.Year)
            {
                if (actualReturnDate.Month > expectReturnDate.Month)
                {
                    fine = (actualReturnDate.Month - expectReturnDate.Month)*500;
                }
                else if ((actualReturnDate.Month == expectReturnDate.Month)
                         && actualReturnDate.Day > expectReturnDate.Day)
                {
                    fine = (actualReturnDate.Day - expectReturnDate.Day)*15;
                }
            }
            if (actualReturnDate.Year > expectReturnDate.Year)
            {
                fine = 10000;
            }
            Console.WriteLine(fine);
        }

        class BookReturnDate
        {
            public readonly int Day;
            public readonly int Month;
            public readonly int Year;

            public BookReturnDate(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }
        }
    }
}
