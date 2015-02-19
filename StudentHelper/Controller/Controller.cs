using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHelper.Controller
{
    class Controller
    {
        DatabaseFacade _DBF = new DatabaseFacade();
        public List<string> GetWeeks()
        {
            List<string> weekListStrings = new List<string>();
            foreach (Model.Week e in _DBF.GetWeeks())
            {
                weekListStrings.Add(e.WeekNr.ToString());
            }
            return weekListStrings;
        }
    }
}
