using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Ticket : Product
    {
        public string Name { get; set; } //DB
        public int Price { get; set; } //DB        
        public string Public { get; set; } // All/+14/PG
        public string Language { get; set; } //DB
        public bool IsLiveEvent { get; set; } //DB
    }
}
