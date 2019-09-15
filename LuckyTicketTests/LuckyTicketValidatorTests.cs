using System;
using System.Collections.Generic;
using LuckyTickets;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LuckyTicketTests
{
    public class LuckyTicketValidatorTests : IClassFixture<LuckyTicketValidator>
    {
        private ILuckyTicketValidator validator;

        public LuckyTicketValidatorTests(LuckyTicketValidator validator)
        {
            this.validator = validator;
        }

        [Theory]
        [InlineData("PiTeR")]
        [InlineData("mOSKoW")]
        [InlineData("moskow")]
        [InlineData("piter")]
        public void LuckyTicketValidator_WithsAlgorithmName_ShouldReturnsTrue(string algorithmName)
        {
            Assert.True(validator.IsRightAlgorithm(algorithmName));
        }

        [Theory]
        [InlineData("PiTe")]
        [InlineData("mOS")]
        [InlineData("sdgvsd")]
        [InlineData("iter")]
        public void LuckyTicketValidator_WithAlgorithmName_ShouldReturnsFalse(string algorithmName)
        {
            Assert.False(validator.IsRightAlgorithm(algorithmName));
        }
    }
}
