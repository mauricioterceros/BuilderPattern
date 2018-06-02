using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class TicketViewFactory : IProductFactory
    {
        public ProductView getDesktopView(Product product)
        {
            ConcertTicketBuilder concertBuilder = new ConcertTicketBuilder();
            LiveEventDirector director2 = new LiveEventDirector(concertBuilder);
            director2.Construct(product);
            ProductView view = concertBuilder.GetTicket();
            Console.Out.WriteLine(view.ToString());
            return view;
        }

        public ProductView getMobileView(Product product)
        {
            return new ProductView();
        }

        public ProductView getTabletView(Product product)
        {
            return new ProductView();
        }
    }
}
