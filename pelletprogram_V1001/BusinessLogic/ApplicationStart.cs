using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class ApplicationStart
    {
        public DayOfWeek Today;
        public string message;
        public string CheckDay()
        {
            Today = DayOfWeek.Thursday;
            if(Today == DayOfWeek.Thursday)
            {
                message = "You are late!";
            }
            return message;

        }

    }
}