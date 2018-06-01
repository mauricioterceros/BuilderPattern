using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    interface ITicketBuilder
    {
        void Init();
        void SetPrice(Ticket ticket);
        void SetLanguage(Ticket ticket);
        void SetPublic(Ticket ticket);
        void SetIsLive(Ticket ticket);
        void SetEventName(Ticket ticket);
    }
}
