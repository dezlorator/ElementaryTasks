using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWord
{
    public static class ConvertNumberToWord
    {
        public static string NumberToWords(this int number)
        {
            // в дикшионари
            // стринг билдер
            string[] ZeroToNineteen = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven",
                                "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] Dozen = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + StringConstants.MILLION;
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + StringConstants.THOUSAND;
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + StringConstants.HUNDRED;
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                {
                    words += "and ";
                }

                if (number < 20)
                {
                    words += ZeroToNineteen[number];
                }

                else
                {
                    words += Dozen[number / 10];
                    if ((number % 10) > 0)
                    {
                        words += "-" + ZeroToNineteen[number % 10];
                    }
                }
            }

            return words;
        }


    }
}
