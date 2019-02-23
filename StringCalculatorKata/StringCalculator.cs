

using System;
using System.Linq;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            var delemiters = "\n,";

            if (string.IsNullOrEmpty(numbers))
                return 0;
            
            if (numbers.Contains("//"))
            {
                delemiters += numbers[2];
                numbers = numbers.Substring(4, numbers.Length - 4);
            }
            var items = numbers.Split(delemiters.ToCharArray());

            if (items.Any(x => string.IsNullOrEmpty(x)))
                throw new ArgumentException();
            
            var integers = items.Select(x => int.Parse(x));
            var negatives = integers.Where(x => x < 0);
            
            if (negatives.Count() > 0)
            {
                var message = $"Negatives not allowed: {negatives.First(x => x < 0).ToString()}";
                throw new ArgumentOutOfRangeException(message);
            }
                
            return items
            .Select(x => int.Parse(x)).Sum();
        }
    }
}
