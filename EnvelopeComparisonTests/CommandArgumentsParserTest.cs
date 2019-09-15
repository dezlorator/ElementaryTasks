using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using EnvelopeComparison;

namespace EnvelopeComparisonTests
{
    public class CommandArgumentsParserTest : IClassFixture<CommandArgumentsParser>
    {
        private ICommandArgumentsParser parser;

        public CommandArgumentsParserTest(CommandArgumentsParser parser)
        {
            this.parser = parser;
        }

        [Theory]
        [InlineData ("34 hi, rfgs, 81", new string[] {"34", "hi", "rfgs", "81" })]
        [InlineData("hello, there", new string[] { "hello", "there" })]
        [InlineData("PE, RE MOGA", new string[] { "PE", "RE", "MOGA"})]
        [InlineData("Xiaomi, top", new string[] { "Xiaomi", "top" })]
        public void SplitStringIntoArray_WithStringToParse_ShouldReturnTrue(string stringToValidate, string[] expected)
        {
            Assert.Equal(expected, parser.SplitStringIntoArray(stringToValidate));
        }
    }
}
