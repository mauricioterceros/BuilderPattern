using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class CinemaTicketBuilder : ITicketBuilder
    {
        TicketView newTicket = new TicketView();

        public void SetEventName()
        {
            newTicket.EventName = "DeadPool 2";
        }

        public void SetIsLive()
        {
            //newTicket.IsLiveEvent = false;
        }

        public void SetLanguage()
        {
            newTicket.Language = "English";
        }

        public void SetPrice()
        {
            newTicket.Price = 20;
        }

        public void SetPublic()
        {
            newTicket.Public = "+14";
        }

        public TicketView GetTicket()
        {
            newTicket.HasSubtitles = newTicket.IsLiveEvent && newTicket.Language == "English";
            newTicket.Room = "2";
            newTicket.Hour = "20:00";
            return newTicket;
        }

        public void SetPrice(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public void SetLanguage(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public void SetPublic(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public void SetIsLive(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public void SetEventName(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            
        }
    }
}
