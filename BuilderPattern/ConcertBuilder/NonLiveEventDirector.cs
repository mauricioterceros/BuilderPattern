using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class NonLiveEventDirector
    {
        ITicketBuilder nonLiveBuilder;

        public NonLiveEventDirector(ITicketBuilder builder)
        {
            nonLiveBuilder = builder;
        }

        public void Construct()
        {
            /*nonLiveBuilder.SetPrice();
            nonLiveBuilder.SetLanguage();
            nonLiveBuilder.SetPublic();
            nonLiveBuilder.SetEventName();*/
        }

    }
}
