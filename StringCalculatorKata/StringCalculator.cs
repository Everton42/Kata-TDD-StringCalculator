using System.Linq;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

                return numbers.Split(',', '\n')
                    .Select(n => int.Parse(n)).Sum();
        }
    }
}
