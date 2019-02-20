using System;
using System.Collections.Generic;
using System.Linq;

namespace NU.StringCalculatorExercise
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            List<string> result = numbers.Split(",").ToList();

            return result.Sum(e => String.IsNullOrEmpty(e) ? 0 : Convert.ToInt32(e));
        }

    }
}
