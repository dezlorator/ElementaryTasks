﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    public interface ILuckyTicketParser
    {
        List<Ticket> CheckTicketsInLine(string ticketsString);
    }
}
