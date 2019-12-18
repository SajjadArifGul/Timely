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
            return ts == null || ts.Ticks == 0 ? string.Empty : string.Format("{0} Days, {1} Hours, {2} Minutes, {3} Seconds", ts.ToString("dd"), ts.ToString("hh"), ts.ToString("mm"), ts.ToString("ss"));
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
