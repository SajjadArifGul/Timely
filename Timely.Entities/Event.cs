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

                if(Status == EventStatus.Stopped && EndTime.HasValue)
                {
                    var timeSpan = EndTime.Value - StartTime;
                    str = string.Format("{0} - {1}", StartTime.ToString(), timeSpan.ToTimelyStandard());
                }
                else str = string.Format("{0} - {1}", StartTime.ToString(), Status.ToString());

                return str;
            }
        }
    }

    public static class Extensions
    {
        public static string ToTimelyStandard(this TimeSpan ts)
        {
            var str = string.Empty;

            if (ts != null && ts.Ticks > 0)
            {
                if (ts.Days > 0)
                {
                    str += string.Format("{0}{1} Days", !string.IsNullOrEmpty(str) ? " " : string.Empty, (int)ts.TotalDays);
                }

                if (ts.Hours > 0)
                {
                    str += string.Format("{0}{1} Hours", !string.IsNullOrEmpty(str) ? " " : string.Empty, ts.ToString("hh"));
                }

                str += string.Format("{0}{1} Minutes", !string.IsNullOrEmpty(str) ? " " : string.Empty, ts.ToString("mm"));
                str += string.Format("{0}{1} Seconds", !string.IsNullOrEmpty(str) ? " " : string.Empty, ts.ToString("ss"));
                str += string.Format("{0}{1} Miliseconds", !string.IsNullOrEmpty(str) ? " " : string.Empty, ts.ToString("ff"));
            }

            return str;
        }
    }
}
