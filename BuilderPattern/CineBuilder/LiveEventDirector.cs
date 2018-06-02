using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class LiveEventDirector
    {
        ITicketBuilder liveBuilder;

        public LiveEventDirector(ITicketBuilder builder)
        {
            liveBuilder = builder;
        }

        public void Construct(Product ticket)
        {
            liveBuilder.Init();
            //liveBuilder.SetPrice(ticket);
            //liveBuilder.SetLanguage(ticket);
            liveBuilder.SetPublic(ticket);
            liveBuilder.SetIsLive(ticket);
            liveBuilder.SetEventName(ticket);
        }
    }
}
