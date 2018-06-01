using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class TicketView
    {
        public string EventName { get; set; } //DB
        public int Price { get; set; } //DB        
        public string Public { get; set; } // All/+14/PG
        public string Language { get; set; } //DB
        public bool IsLiveEvent { get; set; } //DB
        public bool HasSubtitles { get; set; }
        public string Venue { get; set; } 
        public string Room { get; set; } 
        public string Hour { get; set; } 

        public TicketView() { }

        public override String ToString()
        {
            return EventName + " " + Language + " " + Venue + " " + Room + " " + Hour + " " + HasSubtitles + " " + Price;
        }
    }
}
