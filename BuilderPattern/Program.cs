using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TicketView> ticketViews = new List<TicketView>();
            List<Ticket> dbTickets = DBTicket.Instance.GetDBTickets();

            foreach (Ticket dbTicket in dbTickets)
            {
                ticketViews.Add(TicketViewFactory.Build(dbTicket));
            }

            Console.ReadKey();
            /*
            Ticket concertTicket = new Ticket();
            concertTicket.Price = 20;
            concertTicket.IsLiveEvent = true;
            concertTicket.Language = "English";
            concertTicket.EventName = "Guns and Roses";
            concertTicket.Public = "ALL";

            Ticket cinemaTicket = new Ticket();
            concertTicket.Price = 20;
            concertTicket.IsLiveEvent = false;
            concertTicket.Language = "English";
            concertTicket.EventName = "DeadPool 2";
            concertTicket.Public = "+14";*/
        }
    }
}
