using System;
using System.Security;
class Tickets
{
    public static void Main()
    {
        int? TicketsOnSale = null;
        // int AvailableTickets = TicketsOnSale == null ? 0 : (int)TicketsOnSale;
        int AvailableTickets = TicketsOnSale?? 0;
        Console.WriteLine("Available Tickets: {0}", AvailableTickets);
    }
}