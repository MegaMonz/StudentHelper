using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHelper.Model
{
    class Event
    {
        public string Day { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int SubjectID { get; set; }
        public string Description { get; set; }
        public Event(string day, DateTime startdate, DateTime enddate, int subjectid, string description )
        {
            Day = day;
            StartDate = startdate;
            EndDate = enddate;
            SubjectID = subjectid;
            Description = description;
        }
    }
}
