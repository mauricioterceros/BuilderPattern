using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class ConcertTicketBuilder : ITicketBuilder
    {
        ProductView newTicket;

        public void SetEventName(Product ticket)
        {
            newTicket.EventName = ((Ticket)ticket).Name;
        }

        public void SetIsLive(Product ticket)
        {
            newTicket.IsLiveEvent = ((Ticket)ticket).IsLiveEvent;
        }

        public void SetLanguage(Product ticket)
        {
            newTicket.Language = ((Ticket)ticket).Language.ToUpper();
        }

        public void SetPrice(Product ticket)
        {
            newTicket.Price = ((Ticket)ticket).Price / 2;
        }

        public void SetPublic(Product ticket)
        {
            newTicket.Public = ((Ticket)ticket).Public;
        }

        public void Init()
        {
            newTicket = new ProductView();
        }

        public ProductView GetTicket()
        {
            newTicket.Venue = "Stadium";
            newTicket.Hour = "22:00";
            return newTicket;
        }
    }
}
