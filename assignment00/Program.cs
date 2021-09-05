using System;

namespace assignment00
{
    public class Program
    {
        public static void Main(string[] args)
        {
         
        }

        public static bool IsLeapYear(int year) {
           return year%4==0 && year%100!=0 ? true : year%400==0;
        }
    }
}
