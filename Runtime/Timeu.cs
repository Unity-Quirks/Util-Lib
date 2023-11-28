using System;

namespace Quirks
{
    public static class Timeu
    {
        public static string PrettySeconds(float seconds)
        {
            TimeSpan t = TimeSpan.FromSeconds(seconds);
            string res = "";
            if (t.Days > 0) res += t.Days + "d";
            if (t.Hours > 0) res += " " + t.Hours + "h";
            if (t.Minutes > 0) res += " " + t.Minutes + "m";

            if (t.Milliseconds > 0) res += " " + t.Seconds + "." + (t.Milliseconds / 100) + "s";
            else if (t.Seconds > 0) res += " " + t.Seconds + "s";

            return res != "" ? res : "0s";
        }

        public static string FormatTimespan(float _remaining)
        {
            return FormatTimespan(TimeSpan.FromSeconds(_remaining));
        }

        public static string FormatTimespan(TimeSpan _timespan)
        {
            if (_timespan.TotalHours >= 1)
            {
                return Mathq.Truncate(_timespan.TotalHours) + "h " + _timespan.Minutes.ToString("00m ") + _timespan.Seconds.ToString("00s");
            }
            else if (_timespan.TotalMinutes >= 1)
            {
                return _timespan.Minutes + "m " + _timespan.Seconds.ToString("00s");
            }
            return _timespan.Seconds + "s";
        }
    }

}
