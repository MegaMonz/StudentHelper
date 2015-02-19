using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHelper.Model
{
    class Event
    {
        public Event(int weeknr)
        {
            WeekNr = weeknr;
        }
        public int WeekNr { get; set; }

    }
}
