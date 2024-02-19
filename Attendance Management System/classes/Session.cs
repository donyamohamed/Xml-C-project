using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management_System.classes
{
    public class Session
    {
        public DateTime Date { get; set; }
        public int Status { get; set; }

        public Session(DateTime date, int status)
        {
            Date = date;
            Status = status;
        }
    }
    
}
