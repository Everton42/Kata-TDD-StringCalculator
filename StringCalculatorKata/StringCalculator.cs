namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            if (numbers.Contains(","))
                return int.Parse(numbers[0].ToString()) +
                    int.Parse(numbers[2].ToString());

            return int.Parse(numbers);
        }
    }
}
