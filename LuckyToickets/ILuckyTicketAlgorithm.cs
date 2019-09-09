﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    interface ILuckyTicketAlgorithm
    {
        int Algorithm(List<Ticket> ticketList);
    }
}
