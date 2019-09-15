using ArgumentsValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ArgumentsValidatorTests
{
    public class ArgumentsValidatorTest : IClassFixture<ArgsValidator>
    {
        private IArgumentsValidator validatorFicture;

        public ArgumentsValidatorTest(ArgsValidator ficture)
        {
            validatorFicture = ficture;
        }

        [Theory]
        [InlineData(new string[] { "get", "set", "value"}, 3)]
        [InlineData(new string[] { }, 0)]
        [InlineData(new string[] { "1"}, 1)]
        [InlineData(new string[] { "get", "afa", "value", "sdgv", "dgdfw" }, 5)]
        public void CheckArgsArrayLength_WithArray_ShouldReturnTrue(string[] argsArray, int supposedLength)
        {
            Assert.True(validatorFicture.CheckArgsArrayLength(argsArray, supposedLength));
        }

        [Theory]
        [InlineData(16, -3, 23)]
        [InlineData(16, 16, 48)]
        [InlineData(34, -9, 34)]
        [InlineData(57, -12, 93)]
        public void CheckNumberRange_WithNumberMaxAndMinValue_ShouldReturnTrue(int number, int min, int max)
        {
            Assert.True(validatorFicture.CheckNumberRange(number, min, max));
        }

        [Theory]
        [InlineData(16.0, -3.2, 23.6)]
        [InlineData(16.0, 16.0, 48.4)]
        [InlineData(34.0, -9.3, 34.0)]
        [InlineData(73.1, 0.0, 92.7)]
        public void CheckDoubleNumberRange_WithNumberMaxAndMinValue_ShouldReturnTrue(double number, double min, double max)
        {
            Assert.True(validatorFicture.CheckDoubleNumberRange(number, min, max));
        }

        [Theory]
        [InlineData("")]
        public void IsEmpty_WithString_ShouldReturnTrue(string stringToCheck)
        {
            Assert.True(validatorFicture.IsEmpty(stringToCheck));
        }

        [Theory]
        [InlineData("sdgs")]
        [InlineData("xcwef")]
        [InlineData("32sd")]
        [InlineData("95363lcspdvs")]
        public void IsEmpty_WithString_ShouldReturnFalse(string stringToCheck)
        {
            Assert.False(validatorFicture.IsEmpty(stringToCheck));
        }

        [Theory]
        [InlineData("34")]
        [InlineData("-12")]
        [InlineData("30")]
        [InlineData("1000")]
        public void TryParseInteger_WithStringToParseAndIntergerValue_ShouldReturnTrue(string stringToParse)
        {
            int d = 0;
            Assert.True(validatorFicture.TryParseInteger(stringToParse, ref d));
        }

        [Theory]
        [InlineData("34,4")]
        [InlineData("-12sdf")]
        [InlineData("adsfg")]
        [InlineData("23.1")]
        public void TryParseInteger_WithStringToParseAndIntergerValue_ShouldReturnFalse(string stringToParse)
        {
            int d = 0;
            Assert.False(validatorFicture.TryParseInteger(stringToParse, ref d));
        }

        [Theory]
        [InlineData("34")]
        [InlineData("34,1")]
        [InlineData("-312,1423")]
        public void TryParseDouble_WithString_ShouldReturnTrue(string stringToParse)
        {
            double d = 0;
            Assert.True(validatorFicture.TryParseDouble(stringToParse, ref d));
        }

        [Theory]
        [InlineData("34asf")]
        [InlineData("34.1")]
        [InlineData("-312,14sa23")]
        [InlineData("dfpoaspd")]
        public void TryParseDouble_WithString_ShouldReturnFalse(string stringToParse)
        {
            double d = 0;
            Assert.False(validatorFicture.TryParseDouble(stringToParse, ref d));
        }
    }
}
