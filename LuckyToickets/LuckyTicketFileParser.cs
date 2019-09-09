using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LuckyTickets
{
    class LuckyTicketParser : ILuckyTicketParser
    {

        public List<Ticket> CheckTicketsInLine(string ticketsString)
        {
            List<string> ticketsList = (ticketsString.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)).ToList();
            for (int i = 0; i < ticketsList.Count; i++)
            {
                if ((ticketsList[i].Length % 2 != 0) || (!int.TryParse(ticketsList[i], out _)))
                {
                    ticketsList.RemoveAt(i);
                    i--;
                }
            }

            return ConvertStringListToTicketList(ticketsList);
        }

        private List<Ticket> ConvertStringListToTicketList(List<string> list)
        {
            List<Ticket> ticketList = new List<Ticket>();
            for(int i = 0; i < list.Count; i++)
            {
                ticketList.Add(new Ticket(list[i]));
            }

            return ticketList;
        }
    }
}
