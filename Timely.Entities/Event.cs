using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timely.Entities
{
    public class Event
    {
        public int ID { get; set; }
        public int TaskID { get; set; }
        public DateTime StartTime { get; set; }
        public Nullable<DateTime> EndTime { get; set; }
        public int Ticks { get; set; }
        public EventStatus Status { get; set; }
    }
}
