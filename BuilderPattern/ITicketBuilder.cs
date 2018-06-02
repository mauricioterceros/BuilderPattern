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
        void SetPrice(Product ticket);
        void SetLanguage(Product ticket);
        void SetPublic(Product ticket);
        void SetIsLive(Product ticket);
        void SetEventName(Product ticket);
    }
}
