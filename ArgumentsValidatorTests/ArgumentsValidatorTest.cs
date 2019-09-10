using ArgumentsValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ArgumentsValidatorTests
{
    public class ArgumentsValidatorTest
    {
        [Theory]
        [InlineData(new string[] { "get", "set", "value"}, 3, true)]
        [InlineData(new string[] { "1", "2", "3", "4" }, 2, false)]
        [InlineData(new string[] { }, 0, true)]
        [InlineData(new string[] { "1"}, 1, true)]
        public void CheckArgsArrayLength(string[] argsArray, int supposedLength, bool expected)
        {
            IArgumentsValidator validator = new ArgsValidator();
            Assert.Equal(validator.CheckArgsArrayLength(argsArray, supposedLength), expected);
        }

        [Theory]
        [InlineData(16, -3, 23, true)]
        [InlineData(-76, 12, 98, false)]
        [InlineData(16, 16, 48, true)]
        [InlineData(34, -9, 34, true)]
        public void CheckNumberRange(int number, int min, int max, bool expected)
        {
            IArgumentsValidator validator = new ArgsValidator();
            Assert.Equal(validator.CheckNumberRange(number, min, max), expected);
        }

        [Theory]
        [InlineData(16.0, -3.2, 23.6, true)]
        [InlineData(-76.3, 12.8, 98.1, false)]
        [InlineData(16.0, 16.0, 48.4, true)]
        [InlineData(34.0, -9.3, 34.0, true)]
        public void CheckDoubleNumberRange(double number, double min, double max, bool expected)
        {
            IArgumentsValidator validator = new ArgsValidator();
            Assert.Equal(validator.CheckDoubleNumberRange(number, min, max), expected);
        }

        [Theory]
        [InlineData("", true)]
        [InlineData("hoh", false)]
        public void IsEmpty(string stringToCheck, bool expected)
        {
            IArgumentsValidator validator = new ArgsValidator();
            Assert.Equal(validator.IsEmpty(stringToCheck), expected);
        }

        [Theory]
        [InlineData("5ht", 3, false)]
        [InlineData("34", 3, true)]
        [InlineData(".23", 3, false)]
        [InlineData("34.1", 3, false)]
        public void TryParseInteger(string stringToParse, ref int outputNumber, bool expected)
        {
            IArgumentsValidator validator = new ArgsValidator();
            Assert.Equal(validator.TryParseInteger(stringToParse, ref outputNumber), expected);
        }

        [Theory]
        [InlineData(".23", false)]
        [InlineData("5ht", false)]
        [InlineData("34", true)]
        [InlineData("34,1", true)]
        public void TryParseDouble(string stringToParse, bool expected)
        {
            IArgumentsValidator validator = new ArgsValidator();
            double d = 0;
            Assert.Equal(validator.TryParseDouble(stringToParse, ref d), expected);
        }
    }
}
