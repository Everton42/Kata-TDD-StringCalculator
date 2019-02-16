using StringCalculatorKata;
using Xunit;

namespace StringCalculatorKataTest
{
    public class StringCalculatorTest
    {
        [Fact]
        public void Given_An_Empty_String_The_Add_Method_Must_Return_Zero()
        {
            var stringCalculator = new StringCalculator();
            var expected = 0;

            Assert.Equal(expected, stringCalculator.Add(""));
        }

        [Fact]
        public void Given_An_Single_Number_The_Add_Method_Must_Return_The_Same_Number()
        {
            var stringCalculator = new StringCalculator();
            var expected = 1;

            Assert.Equal(expected, stringCalculator.Add("1"));
        }

        [Fact]
        public void Given_Two_Numbers_The_Add_Method_Must_Return_The_Sum_Of_Both_Numbers()
        {
            var stringCalculator = new StringCalculator();
            var expected = 3;

            Assert.Equal(expected, stringCalculator.Add("1,2"));
        }

        [Fact]
        public void Given_Multiple_Numbers_The_Add_Method_Must_Return_The_Sum_Of_All_Numbers()
        {
            var stringCalculator = new StringCalculator();
            var expected = 10;

            Assert.Equal(expected, stringCalculator.Add("1,2,3,4"));
        }
    }
}
