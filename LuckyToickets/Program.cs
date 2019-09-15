﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            Controler controler = new Controler(new LuckyTicketValidator(), new LuckyTicketParser());
            controler.Run(args);
            Console.ReadLine();
        }
    }
}
