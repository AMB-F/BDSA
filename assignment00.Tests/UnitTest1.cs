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

        [Theory]
        [InlineData("1888")]
        [InlineData("2016")]
        [InlineData("4000")]
        [InlineData("1600")]
        [InlineData("2000")]
        public void Main_when_given_leapyear_prints_yay(string year)
        {
            string prompt = "Please enter a year and hit [enter]\r\n";
            var stringReader = new StringReader(year);
            var writer = new StringWriter();
            Console.SetOut(writer);
            Console.SetIn(stringReader);

            Program.IsLeapYearUI();
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("yay", output);
        }

        [Theory]
        [InlineData("1800")]
        [InlineData("2100")]
        [InlineData("2900")]
        public void Main_when_given_non_leapyear_prints_nay(string year)
        {
            string prompt = "Please enter a year and hit [enter]\r\n";
            var stringReader = new StringReader(year + Environment.NewLine);
            var writer = new StringWriter();
            Console.SetOut(writer);
            Console.SetIn(stringReader);

            Program.IsLeapYearUI();
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("nay", output);
        }

        [Theory]
        [InlineData("1581")]
        [InlineData("1500")]
        [InlineData("1444")]
        public void Main_when_given_year_before_1582_throws_ArgumentOutOfRangeException(string year){
            var stringReader = new StringReader(year + Environment.NewLine);
            Console.SetIn(stringReader);

            Assert.Throws<ArgumentOutOfRangeException>(() => Program.IsLeapYearUI());
        }

   [Theory]
        [InlineData("hat")]
        [InlineData("1a5b0c0")]
        [InlineData(":)")]
        public void Main_when_given_non_year_throws_FormatException(string year){
            var stringReader = new StringReader(year + Environment.NewLine);
            Console.SetIn(stringReader);
            
            Assert.Throws<FormatException>(() => Program.IsLeapYearUI());
        }


    }
}
