using System;

namespace assignment00
{
    public class Program
    {
        public static Boolean validYearEntered = false;
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a year and hit [enter]");
            while (!validYearEntered)
            {
                try
                {
                    IsLeapYearUI();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a valid year after 1582");
                }
            }
        }

        public static void IsLeapYearUI()
        {
            string input = Console.ReadLine();
            int yearInput;

            bool isInteger = int.TryParse(input, out yearInput);
            if (!isInteger)
            {
                throw new FormatException();
            }
            else if (yearInput < 1582)
            {
                throw new ArgumentOutOfRangeException();
            }
            Console.WriteLine(IsLeapYear(yearInput) ? "yay" : "nay");
            validYearEntered = true;
        }

        public static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && year % 100 != 0 ? true : year % 400 == 0;
        }
    }
}
