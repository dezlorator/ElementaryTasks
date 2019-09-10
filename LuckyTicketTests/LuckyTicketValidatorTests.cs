using System;
using System.Collections.Generic;
using LuckyTickets;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LuckyTicketTests
{
    public class LuckyTicketValidatorTests
    {
        [Theory]
        [InlineData("pjdbpodf",  false)]
        [InlineData("PiTeR", true)]
        [InlineData("mOSKoW", true)]
        [InlineData("mOSKoWPiTeR", false)]
        public void LuckyTicketValidatorTest(string algorithmName, bool expected)
        {
            ILuckyTicketValidator validator = new LuckyTicketValidator();
            Assert.Equal(validator.IsRightAlgorithm(algorithmName), expected);
        }
    }
}
