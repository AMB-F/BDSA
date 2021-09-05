using System;
using System.IO;
using Xunit;

namespace assignment00.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(4)]
        [InlineData(40)]
        [InlineData(396)]
        [InlineData(2016)]
        public void IsLeapYear_when_given_number_divisible_by_4_returns_true(int year)
        {
            bool result = Program.IsLeapYear(year);
            Assert.Equal(true, result);
        }

        [Theory]
        [InlineData(200)]
        [InlineData(1800)]
        [InlineData(2100)]
        [InlineData(2900)]
        public void IsLeapYear_when_given_number_divisible_by_4_and_100_returns_false(int year)
        {
            bool result = Program.IsLeapYear(year);
          
            Assert.Equal(false, result);
        }


        [Theory]
        [InlineData(400)]
        [InlineData(4000)]
        [InlineData(1600)]
        [InlineData(2000)]
        public void IsLeapYear_when_given_number_divisible_by_400_returns_true(int year)
        {
            bool result = Program.IsLeapYear(year);
          
            Assert.Equal(true, result);
        }
    }
}
