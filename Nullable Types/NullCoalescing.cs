using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Nullable_Types
{
    internal class NullCoalescing
    {

        static void Operators()
        {
            int AvailableTickets;
            int? TicketsOnSale = null;

            //Using null coalesce operator ??
            AvailableTickets = TicketsOnSale ?? 0;

            Console.WriteLine("Available Tickets={0}", AvailableTickets);
        }

    }
}
