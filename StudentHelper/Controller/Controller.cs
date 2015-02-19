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
            List<string> weekList = new List<string>();
            foreach (Model.Event e in _DBF.GetWeeks())
            {
                weekList.Add(e.WeekNr.ToString());
            }
            return weekList;
        }
    }
}
