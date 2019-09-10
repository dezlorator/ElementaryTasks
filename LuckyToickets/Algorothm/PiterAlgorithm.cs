using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    public class PiterAlgorithm : ILuckyTicketAlgorithm
    {
        public int Algorithm(List<Ticket> ticketList)
        {
            int numberOfLuckyTickets = 0;
            for (int i = 0; i < ticketList.Count; i++)
            {
                if (IsLuckyTicket(ticketList[i]))
                {
                    numberOfLuckyTickets++;
                }
            }

            return numberOfLuckyTickets;
        }

        private bool IsLuckyTicket(Ticket ticketToCheck)
        {
            int getResult = 0;
            for (int i = 0; i < ticketToCheck.GetLength(); i++)
            {
                if (i % 2 == 0)
                {
                    getResult -= ticketToCheck[i];
                }
                else
                {
                    getResult += ticketToCheck[i];
                }
            }

            return getResult == 0;

        }
    }
}
