using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class DBTicket
    {
        private static DBTicket _instance;
        public static DBTicket Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DBTicket();
                }
                return _instance;
            }
        }
        private DBTicket() { }

        public List<Ticket> GetDBTickets()
        {
            List<Ticket> dbTickets = new List<Ticket>();
            Ticket ticket1 = new Ticket() { Name = "Evento 1", IsLiveEvent = true, Language = "English", Price = 20, Public = "All" };
            Ticket ticket2 = new Ticket() { Name = "Evento 2", IsLiveEvent = false, Language = "English", Price = 30, Public = "All" };
            Ticket ticket3 = new Ticket() { Name = "Evento 3", IsLiveEvent = true, Language = "English", Price = 40, Public = "+14" };
            Ticket ticket4 = new Ticket() { Name = "Evento 4", IsLiveEvent = false, Language = "Spanish", Price = 50, Public = "PG" };
            Ticket ticket5 = new Ticket() { Name = "Evento 5", IsLiveEvent = true, Language = "English", Price = 60, Public = "+18" };
            dbTickets.Add(ticket1);
            dbTickets.Add(ticket2);
            dbTickets.Add(ticket3);
            dbTickets.Add(ticket4);
            dbTickets.Add(ticket5);
            return dbTickets;
        }
    }
}
