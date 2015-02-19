using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHelper.Model
{
    class Week
    {
        public List<Event> Monday { get; set; }
        public List<Event> Tuesday { get; set; }
        public List<Event> Wednesday { get; set; }
        public List<Event> Thursday { get; set; }
        public List<Event> Friday { get; set; }
        public List<Event> Saturday { get; set; }
        public List<Event> Sunday { get; set; }
        public int WeekNr { get; set; }

        public Week(int weeknr)
        {
            WeekNr = weeknr;
        }
    }
}
