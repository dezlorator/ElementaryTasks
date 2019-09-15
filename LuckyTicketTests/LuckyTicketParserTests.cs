using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using LuckyTickets;

namespace LuckyTicketTests
{
    public class LuckyTicketParserTests : IClassFixture<LuckyTicketParser>
    {
        private ILuckyTicketParser parser;

        public LuckyTicketParserTests(LuckyTicketParser parser)
        {
            this.parser = parser;
        }

        [Theory]
        [InlineData("3425, 86954k, hello, 986752", new string[] { "3425", "986752"})]
        [InlineData("35, 34562, 9573, 97845031", new string[] { "35", "9573", "97845031" })]
        [InlineData("938,  , 3, 436, G", new string[] {  })]
        [InlineData("6923,  , , 241, FSDE ", new string[] { "6923" })]
        public void CheckTicketsInLine_WithTicketsString_ShouldReturnsTrue(string ticketsString, string[] expected)
        {
            List<Ticket> ticketList = parser.CheckTicketsInLine(ticketsString);
            string[] ticketArray = new string[ticketList.Count];
            for(int i = 0; i < ticketArray.Length; i++)
            {
                ticketArray[i] = ticketList[i].ToString();
            }

            Assert.Equal(expected, ticketArray);
        }
    }
}
