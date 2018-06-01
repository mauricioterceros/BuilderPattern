using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class ConcertTicketBuilder : ITicketBuilder
    {
        TicketView newTicket;

        public void SetEventName(Ticket ticket)
        {
            newTicket.EventName = ticket.Name;
        }

        public void SetIsLive(Ticket ticket)
        {
            newTicket.IsLiveEvent = ticket.IsLiveEvent;
        }

        public void SetLanguage(Ticket ticket)
        {
            newTicket.Language = ticket.Language.ToUpper();
        }

        public void SetPrice(Ticket ticket)
        {
            newTicket.Price = ticket.Price / 2;
        }

        public void SetPublic(Ticket ticket)
        {
            newTicket.Public = ticket.Public;
        }

        public void Init()
        {
            newTicket = new TicketView();
        }

        public TicketView GetTicket()
        {
            newTicket.Venue = "Stadium";
            newTicket.Hour = "22:00";
            return newTicket;
        }
    }
}
