using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    interface IProductFactory
    {
        ProductView getMobileView(Product product);
        //name => lowercase, e.g.: product 1

        ProductView getTabletView(Product product);
        //name => As it is, e.g.: Product 1

        ProductView getDesktopView(Product product);
        //name => Uppercase, e.g.: PRODUCT 1
    }
}
