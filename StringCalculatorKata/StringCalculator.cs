using System.Linq;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            if (numbers.Contains(","))
            {
                return numbers.Split(',').Select(n => int.Parse(n)).Sum();
            }

            return int.Parse(numbers);
        }
    }
}
