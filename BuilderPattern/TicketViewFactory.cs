using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class TicketViewFactory
    {
        public static TicketView Build(Ticket ticket)
        {
            TicketView view = new TicketView();
            if (ticket.IsLiveEvent)
            {
                ConcertTicketBuilder concertBuilder = new ConcertTicketBuilder();
                LiveEventDirector director2 = new LiveEventDirector(concertBuilder);
                director2.Construct(ticket);
                view = concertBuilder.GetTicket();
                Console.Out.WriteLine(view.ToString());
            }
            else if (!ticket.IsLiveEvent)
            {
                /*CinemaTicketBuilder cineBuilder = new CinemaTicketBuilder(ticket);
                LiveEventDirector director1 = new LiveEventDirector(cineBuilder);
                director1.Construct();
                tickets.Add(cineBuilder.GetTicket());*/
            }
            return view;
        }
    }
}
