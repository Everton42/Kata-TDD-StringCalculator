using System;
using System.Linq;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;
            var item = numbers.Split(',', '\n');
            
            if (item.Any(x => string.IsNullOrEmpty(x)))
                throw new ArgumentException();
            
                return item
                    .Select(nmbr => 
                    int.Parse(nmbr)).Sum();
        }
    }
}
