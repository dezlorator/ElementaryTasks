using LuckyTickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LuckyTicketTests
{
    public class PiterAlgorithmTests
    {
        [Theory]
        [InlineData(new string[] { "1322", "655612", "0413", "23", "234531" }, 1)]
        [InlineData(new string[] { "12", "65561251", "123456", "987654", "0011" }, 1)]
        [InlineData(new string[] { "7667", "854395", "4590", "853924", "9675" }, 1)]
        [InlineData(new string[] { "9452", "759407", "194750", "869406", "0011" }, 2)]
        public void PiterAlgorithmTest(string[] ticketsArray, int expected)
        {
            List<Ticket> ticketList = new List<Ticket>();
            foreach (string ticket in ticketsArray)
            {
                ticketList.Add(new Ticket(ticket));
            }
            ILuckyTicketAlgorithm ticketAlgorithm = new PiterAlgorithm();
            Assert.Equal(ticketAlgorithm.Algorithm(ticketList), expected);
        }
    }
}
