using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        [NotMapped]
        public string Name {
            get {
                var str = string.Empty;

                str = string.Format("{0} - {1}", StartTime.ToString(), Status.ToString());

                return str;
            }
        }
    }
}
