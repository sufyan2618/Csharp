﻿using System;
using System.Security;
class Tickets
{
    public static void Main()
    {
        int? TicketsOnSale = null;
        //int availabletickets = ticketsonsale == null ? 0 : (int)ticketsonsale;
        int AvailableTickets = TicketsOnSale?? 0;
        Console.WriteLine("Available Tickets: {0}", AvailableTickets);
    }
}