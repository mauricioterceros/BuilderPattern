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
            List<Product> dbTickets = DBProduct.Instance.GetDBTickets(); //any product: ebooks, tickets

            List<ProductView> ticketViewsDesktop = new List<ProductView>();
            List<ProductView> ticketViewsTablet = new List<ProductView>();
            List<ProductView> ticketViewsMobile = new List<ProductView>();
            

            IProductFactory ticketFactoryView = new TicketViewFactory();

            foreach (Ticket dbTicket in dbTickets)
            {
                ticketViewsDesktop.Add(ticketFactoryView.getDesktopView(dbTicket));
                ticketViewsTablet.Add(ticketFactoryView.getTabletView(dbTicket));
                ticketViewsMobile.Add(ticketFactoryView.getMobileView(dbTicket));
            }

            Console.ReadKey();
        }
    }
}
