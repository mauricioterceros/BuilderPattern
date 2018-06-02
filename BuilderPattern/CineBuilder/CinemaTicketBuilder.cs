using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class CinemaTicketBuilder : ITicketBuilder
    {
        ProductView newTicket = new ProductView();

        public void SetEventName(Product product)
        {
            newTicket.EventName = "DeadPool 2";
        }

        public void SetIsLive(Product product)
        {
            //newTicket.IsLiveEvent = false;
        }

        public void SetLanguage(Product product)
        {
            newTicket.Language = "English";
        }

        public void SetPrice(Product product)
        {
            newTicket.Price = 20;
        }

        public void SetPublic(Product product)
        {
            newTicket.Public = "+14";
        }

        public ProductView GetTicket()
        {
            newTicket.HasSubtitles = newTicket.IsLiveEvent && newTicket.Language == "English";
            newTicket.Room = "2";
            newTicket.Hour = "20:00";
            return newTicket;
        }

        
        public void Init()
        {
            
        }
    }
}
