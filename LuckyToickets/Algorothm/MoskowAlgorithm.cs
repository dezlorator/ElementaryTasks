using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    public class MoskowAlgorithm : ILuckyTicketAlgorithm
    {
        public int Algorithm(List<Ticket> ticketList)
        {
            int numberOfLuckyTickets = 0;
            for(int i = 0; i < ticketList.Count; i++)
            {
                if(IsLuckyTicket(ticketList[i]))
                {
                    numberOfLuckyTickets++;
                }
            }

            return numberOfLuckyTickets;
        }

        private bool IsLuckyTicket(Ticket ticketToCheck)
        {
            int getResult = 0;
            for(int i = 0; i < ticketToCheck.GetLength() / 2; i++)
            {
                getResult -= ticketToCheck[i];
            }
            for (int i = ticketToCheck.GetLength() / 2; i < ticketToCheck.GetLength(); i++)
            {
                getResult += ticketToCheck[i];
            }

            return getResult == 0;
        }
    }
}
