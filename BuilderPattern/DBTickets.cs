using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class DBProduct
    {
        private static DBProduct _instance;
        public static DBProduct Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DBProduct();
                }
                return _instance;
            }
        }
        private DBProduct() { }

        public List<Product> GetDBTickets()
        {
            List<Product> dbTickets = new List<Product>();
            Product ticket1 = new Ticket() { Name = "Product 1", IsLiveEvent = true, Language = "English", Price = 20, Public = "All" };
            Product ticket2 = new Ticket() { Name = "Product 2", IsLiveEvent = false, Language = "English", Price = 30, Public = "All" };
            Product ticket3 = new Ticket() { Name = "Product 3", IsLiveEvent = true, Language = "English", Price = 40, Public = "+14" };
            Product ticket4 = new Ticket() { Name = "Product 4", IsLiveEvent = false, Language = "Spanish", Price = 50, Public = "PG" };
            Product ticket5 = new Ticket() { Name = "Prodcut 5", IsLiveEvent = true, Language = "English", Price = 60, Public = "+18" };
            dbTickets.Add(ticket1);
            dbTickets.Add(ticket2);
            dbTickets.Add(ticket3);
            dbTickets.Add(ticket4);
            dbTickets.Add(ticket5);
            return dbTickets;
        }
    }
}
