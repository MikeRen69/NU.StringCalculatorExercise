using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        //public int Add(string numbers)
        //{
        //    string delimiter = ",";
        //    if (numbers.StartsWith(@"//"))
        //    {
        //        delimiter = numbers.Substring(2, numbers.IndexOf(@"\n") - 2);
        //        numbers = numbers.Substring(numbers.IndexOf(@"\n")+2);
        //    }
        //    if (numbers.Contains(delimiter + "\n")) { throw new ArgumentException("New Line found in wrong location"); }

        //    List<string> result = numbers.Replace("\n", delimiter).Split(delimiter).ToList();

        //    return result.Sum(e => String.IsNullOrEmpty(e) ? 0 : Convert.ToInt32(e));
        //}

        // Step 5
        //public int Add(string numbers)
        //{
        //    string delimiter = ",";
        //    if (numbers.StartsWith(@"//"))
        //    {
        //        delimiter = numbers.Substring(2, numbers.IndexOf(@"\n") - 2);
        //        numbers = numbers.Substring(numbers.IndexOf(@"\n") + 2);
        //    }
        //    if (numbers.Contains(delimiter + "\n")) { throw new ArgumentException("New Line found in wrong location"); }

        //    List<string> result = numbers.Replace("\n", delimiter).Split(delimiter).ToList();

        //    // Check for negatives
        //    StringBuilder negatives = new StringBuilder();
        //    foreach (string item in result.Where(n=> !String.IsNullOrEmpty(n) && Convert.ToInt32(n) < 0))
        //        negatives.AppendLine(item);

        //    if(negatives.Length > 0)
        //        throw new ArgumentException("negatives not allowed\r\n" + negatives.ToString());


        //    return result.Sum(e => String.IsNullOrEmpty(e) ? 0 : Convert.ToInt32(e));
        //}

        // Step 6
        //public int Add(string numbers)
        //{
        //    string delimiter = ",";
        //    if (numbers.StartsWith(@"//"))
        //    {
        //        delimiter = numbers.Substring(2, numbers.IndexOf(@"\n") - 2);
        //        numbers = numbers.Substring(numbers.IndexOf(@"\n") + 2);
        //    }
        //    if (numbers.Contains(delimiter + "\n")) { throw new ArgumentException("New Line found in wrong location"); }

        //    List<string> result = numbers.Replace("\n", delimiter).Split(delimiter).ToList();

        //    // Check for negatives
        //    StringBuilder negatives = new StringBuilder();
        //    foreach (string item in result.Where(n => !String.IsNullOrEmpty(n) && Convert.ToInt32(n) < 0))
        //        negatives.AppendLine(item);

        //    if (negatives.Length > 0)
        //        throw new ArgumentException("negatives not allowed\r\n" + negatives.ToString());

        //    return result.Where(t => !String.IsNullOrEmpty(t) && Convert.ToInt32(t) < 1001).Sum(e => Convert.ToInt32(e));
        //}

        // Step 7-9
        public int Add(string numbers)
        {
            string delimiter = ",";
            if (numbers.StartsWith(@"//["))
            {
                var cleanDelimiter = numbers.Substring(3, numbers.IndexOf(@"\n") - 4).Replace("]", "");
                numbers = numbers.Substring(numbers.IndexOf(@"\n") + 2);
                List<string> lstDelimiter = cleanDelimiter.Split("[").ToList();

                delimiter = lstDelimiter.FirstOrDefault();

                // For simplicity replace all delimiters with the first delimiter
                foreach (string item in lstDelimiter)
                    numbers = numbers.Replace(item, delimiter);
            }
            else
            {
                if (numbers.StartsWith(@"//"))
                {
                    delimiter = numbers.Substring(2, numbers.IndexOf(@"\n") - 2);
                    numbers = numbers.Substring(numbers.IndexOf(@"\n") + 2);
                }
            }

            if (numbers.Contains(delimiter + "\n")) { throw new ArgumentException("New Line found in wrong location"); }

            List<string> result = numbers.Replace("\n", delimiter).Split(delimiter).ToList();

            // Check for negatives
            StringBuilder negatives = new StringBuilder();
            foreach (string item in result.Where(n => !String.IsNullOrEmpty(n) && Convert.ToInt32(n) < 0))
                negatives.AppendLine(item);

            if (negatives.Length > 0)
                throw new ArgumentException("negatives not allowed\r\n" + negatives.ToString());

            return result.Where(t => !String.IsNullOrEmpty(t) && Convert.ToInt32(t) < 1001).Sum(e => Convert.ToInt32(e));
        }
    }
}
