using System;
using StringCalculatorKata;
using Xunit;

namespace StringCalculatorKataTest
{
    public class StringCalculatorTest
    {
        [Fact]
        public void Given_An_Empty_String_The_Add_Method_Must_Return_Zero()
        {
            string.Empty.ShouldCalculateTo(0);
        }

        [Fact]
        public void Given_An_Single_Number_The_Add_Method_Must_Return_The_Same_Number()
        {
            "1".ShouldCalculateTo(1);
        }

        [Fact]
        public void Given_Two_Numbers_The_Add_Method_Must_Return_The_Sum_Of_Both_Numbers()
        {
            "1,2".ShouldCalculateTo(3);
        }

        [Fact]
        public void Given_Multiple_Numbers_The_Add_Method_Must_Return_The_Sum_Of_All_Numbers()
        {
            "1,2,3,4".ShouldCalculateTo(10);
        }

        [Fact]
        public void Given_New_Line_As_A_Delimiter_Should_Return_The_Sum_Of_All_Numbers()
        {
            "1\n2\n3".ShouldCalculateTo(6);
        }

        [Fact]
        public void Given_Consecutive_Delimiters_Should_Throw_Exception()
        {
            Assert.Throws(typeof(ArgumentException), () =>
             ",,".ShouldCalculateTo(-1));
        }
    }
    internal static class TestHelper
    {
        public static void ShouldCalculateTo(this string input, int expected)
        {
        var item = new StringCalculator();
        Assert.Equal(expected, item.Add(input));
        }
    }
}
