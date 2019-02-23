
using StringCalculatorKata;
using System;
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
            Assert.Throws<ArgumentException>(() =>
             new StringCalculator().Add(",,"));
        }

        [Fact]
        public void Given_A_Custom_Delemiter_Definition_Should_Return_The_Sum_Of_All_Numbers()
        {
            "//;\n1;3".ShouldCalculateTo(4);
        }

        [Fact]
        public void Given_A_Negative_Number_Should_Throw_Exception()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
             new StringCalculator().Add("-1,2"));
        }

        [Fact]
        public void Negative_Number_Error_Message_Should_Contain_Negative_Number()
        {
            var error = Assert.Throws<ArgumentOutOfRangeException>(() =>
             new StringCalculator().Add("-1,2"));

             Assert.Contains("-1", error.Message);
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
