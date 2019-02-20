using System;
using System.Collections.Generic;
using System.Linq;

namespace NU.StringCalculatorExercise
{
    public class StringCalculator
    {
        // Steps 1 & 2
        //public int Add(string numbers)
        //{
        //    List<string> result = numbers.Split(",").ToList();

        //    return result.Sum(e => String.IsNullOrEmpty(e) ? 0 : Convert.ToInt32(e));
        //}

        // Step 3
        //public int Add(string numbers)
        //{
        //    if(numbers.Contains(",\n")) { return 0; }

        //    List<string> result = numbers.Replace("\n",",").Split(",").ToList();

        //    return result.Sum(e => String.IsNullOrEmpty(e) ? 0 : Convert.ToInt32(e));
        //}

        // Step 4
        public int Add(string numbers)
        {
            string delimiter = ",";
            if (numbers.StartsWith(@"//"))
            {
                delimiter = numbers.Substring(2, numbers.IndexOf(@"\n") - 2);
                numbers = numbers.Substring(numbers.IndexOf(@"\n")+2);
            }
            if (numbers.Contains(delimiter + "\n")) { throw new ArgumentException("New Line found in wrong location"); }

            List<string> result = numbers.Replace("\n", delimiter).Split(delimiter).ToList();

            return result.Sum(e => String.IsNullOrEmpty(e) ? 0 : Convert.ToInt32(e));
        }

    }
}
