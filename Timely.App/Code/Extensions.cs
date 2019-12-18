using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timely.App.Code
{
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
        public static string ToDigitalTimelyStandard(this TimeSpan ts)
        {
            var str = string.Empty;

            if (ts != null && ts.Ticks > 0)
            {
                if (ts.Hours > 0)
                {
                    str += string.Format("{0}{1}", !string.IsNullOrEmpty(str) ? " : " : string.Empty, (int)ts.TotalHours);
                }

                str += string.Format("{0}{1}", !string.IsNullOrEmpty(str) ? " : " : string.Empty, ts.ToString("mm"));
                str += string.Format("{0}{1}", !string.IsNullOrEmpty(str) ? " : " : string.Empty, ts.ToString("ss"));
                str += string.Format("{0}{1}", !string.IsNullOrEmpty(str) ? " : " : string.Empty, ts.ToString("ff"));
            }

            return str;
        }

        public static string IfNullOrEmptyShowAlternative(this string str, string alternativeStr)
        {
            str = str.Trim();
            if (string.IsNullOrWhiteSpace(str) || string.IsNullOrEmpty(str))
            {
                return alternativeStr;
            }
            else
            {
                return str;
            }
        }
    }
}
