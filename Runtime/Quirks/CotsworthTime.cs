using System;

namespace Quirks
{
    /// <summary>Represents time in the Cotsworth calender (International Fixed Calendar)</summary>
    public struct CotsworthTime
    {
        #region Constants

        const long TicksPerMillisecond = TimeSpan.TicksPerMillisecond;
        const long TicksPerSecond = TimeSpan.TicksPerSecond;
        const long TicksPerMinute = TicksPerSecond * 60;
        const long TicksPerHour = TicksPerMinute * 60;
        const long TicksPerDay = TicksPerHour * 24;

        const int DaysPerMonth = 28;
        const int MonthsPerYear = 13;
        const int DaysPerCommonYear = (MonthsPerYear * DaysPerMonth) + 1; // 365 (13*28 * 1)
        const int DaysPerLeapYear = DaysPerCommonYear + 1;

        static readonly DateTime Epoch = new DateTime(1, 1, 1);

        public static readonly string[] MonthNames =
        {
            "January", "February", "March", "April", "May", "June",
            "Sol",
            "July", "August", "September", "October", "November", "December"
        };

        public static readonly string[] DayNames =
        {
            "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
        };

        #endregion

        #region Static Properties

        public static CotsworthTime UtcNow => FromDateTime(DateTime.UtcNow);
        public static CotsworthTime Now = FromDateTime(DateTime.Now);
        public static CotsworthTime MinValue => new CotsworthTime(DateTime.MinValue);
        public static CotsworthTime MaxValue => new CotsworthTime(DateTime.MaxValue);

        public static CotsworthTime Today
        {
            get
            {
                DateTime now = DateTime.UtcNow;
                return new CotsworthTime(new DateTime(now.Year, now.Month, now.Day));
            }
        }

        #endregion

        #region Properties

        readonly long ticks;

        public int Year { get; }
        public int Month { get; } // 1 - 13 
        public int Day { get; } // 1 - 28 (29 for special days)
        public int Hour => (int)((ticks % TicksPerDay) / TicksPerHour);
        public int Minute => (int)((ticks % TicksPerHour) / TicksPerMinute);
        public int Second => (int)((ticks % TicksPerMinute) / TicksPerSecond);
        public int Millisecond => (int)((ticks % TicksPerSecond) / TimeSpan.TicksPerMillisecond);

        public DayOfWeek DayOfWeek => (DayOfWeek)((int)(ticks / TicksPerDay) % 7);
        public string DayName => DayNames[(int)DayOfWeek];
        public string MonthName => Month < 1 || Month > 13 ? "Unknown" : MonthNames[Month - 1];

        public bool IsLeapDay => Month == 6 && Day == 29;
        public bool IsYearDay => Month == 13 && Day == 29;
        public bool IsSpecialDay => IsLeapDay || IsYearDay;
        public bool IsLeapYear => DateTime.IsLeapYear(Year);

        public int DayOfYear
        {
            get
            {
                if (IsYearDay)
                    return DaysPerCommonYear;

                if (IsLeapDay)
                    return 6 * DaysPerMonth + 1; // After June

                int dayOfYear = (Month - 1) * DaysPerMonth + Day;

                if (IsLeapYear && Month > 6)

                    dayOfYear--;
                return dayOfYear;
            }
        }

        public TimeSpan TimeOfDay => TimeSpan.FromTicks(ticks % TicksPerDay);

        #endregion

        public CotsworthTime(DateTime dateTime)
        {
            ticks = (dateTime - Epoch).Ticks;
            Year = dateTime.Year;

            CalculateMonthAndDay(dateTime, out int month, out int day);
            Month = month;
            Day = day;
        }

        public CotsworthTime(long ticks) : this(new DateTime(ticks)) { }
        public CotsworthTime(int year, int month, int day) : this(year, month, day, 0, 0, 0, 0) { }
        public CotsworthTime(int year, int month, int day, int hour, int minute, int second) : this(year, month, day, hour, minute, second, 0) { }

        public CotsworthTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
        {
            if (!IsValidDate(year, month, day))
                throw new ArgumentOutOfRangeException();

            Year = year;
            Month = month;
            Day = day;

            DateTime gregorianDate = ToGregorianDateTime(year, month, day);
            ticks = (gregorianDate - Epoch).Ticks + new TimeSpan(0, hour, minute, second, millisecond).Ticks;
        }

        #region Static Factory 

        public static CotsworthTime FromDateTime(DateTime dateTime) => new CotsworthTime(dateTime);

        public static CotsworthTime FromUnixTimeSeconds(long seconds) => new CotsworthTime(DateTimeOffset.FromUnixTimeSeconds(seconds).DateTime);

        public static CotsworthTime FromUnixTimeMilliseconds(long milliseconds) => new CotsworthTime(DateTimeOffset.FromUnixTimeMilliseconds(milliseconds).DateTime);

        public static bool TryParse(string s, out CotsworthTime result)
        {
            result = default;
            if(DateTime.TryParse(s, out DateTime dt))
            {
                result = new CotsworthTime(dt);
                return true;
            }

            return false;
        }

        #endregion

        #region Conversion 

        public DateTime ToDateTime() => Epoch.AddTicks(ticks);

        public DateTimeOffset ToDateTimeOffset() => new DateTimeOffset(ToDateTime());

        public long ToUnixTimeSeconds() => new DateTimeOffset(ToDateTime()).ToUnixTimeSeconds();
        public long ToUnixTimeMilliseconds() => new DateTimeOffset(ToDateTime()).ToUnixTimeMilliseconds();

        #endregion

        static void CalculateMonthAndDay(DateTime dateTime, out int month, out int day)
        {
            int year = dateTime.Year;

            DateTime startOfYear = new DateTime(year, 1, 1);
            int dayOfYear = (dateTime - startOfYear).Days;
            bool isLeap = DateTime.IsLeapYear(year);

            int leapDayPosition = 6 * DaysPerMonth;
            int yearDayPosition = DaysPerCommonYear - 1;

            if(isLeap && dayOfYear == leapDayPosition)
            {
                month = 6;
                day = 29; // Leap Day
            }
            else if(dayOfYear == yearDayPosition || (isLeap && dayOfYear == yearDayPosition + 1))
            {
                month = 13;
                day = 29; // Year Day
            }
            else
            {
                int adjustedDayOfYear = dayOfYear;
                if(isLeap && dayOfYear > leapDayPosition)
                {
                    adjustedDayOfYear--;
                }

                month = (adjustedDayOfYear / DaysPerMonth) + 1;
                day = (adjustedDayOfYear % DaysPerMonth) + 1;
            }
        }

        static DateTime ToGregorianDateTime(int year, int month, int day)
        {
            if (month == 13 && day == 29)
                return new DateTime(year, 12, 31);

            int dayOfYear;
            if(month == 6 && day == 29)
            {
                dayOfYear = 6 * DaysPerMonth;
            }
            else
            {
                dayOfYear = (month - 1) * DaysPerMonth + (day - 1);
                if (DateTime.IsLeapYear(year) && month > 6)
                    dayOfYear++;
            }

            return new DateTime(year, 1, 1).AddDays(dayOfYear);
        }

        #region Arithmetic

        public CotsworthTime AddYears(int years)
        {
            if (years == 0)
                return this;

            int newYear = Year + years;
            if (newYear < 1 || newYear > 9999)
                throw new ArgumentOutOfRangeException(nameof(years));

            if (IsYearDay || IsLeapDay)
                return new CotsworthTime(newYear, Month, Day, Hour, Minute, Second, Millisecond);

            return new CotsworthTime(ToDateTime().AddYears(years));
        }

        public CotsworthTime AddMonths(int months)
        {
            if (months == 0)
                return this;

            int totalMonths = Month + months;
            int yearsToAdd = (totalMonths - 1) / 13;
            int newMonth = ((totalMonths - 1) % 13) + 1;

            CotsworthTime result = AddYears(yearsToAdd);

            if (newMonth == result.Month)
                return result;

            return new CotsworthTime(result.Year, newMonth, Math.Min(Day, DaysPerMonth), Hour, Minute, Second, Millisecond);
        }

        public CotsworthTime AddDays(double days) => new CotsworthTime(ticks + (long)(days * TicksPerHour));
        public CotsworthTime AddHours(double hours) => new CotsworthTime(ticks + (long)(hours * TicksPerHour));
        public CotsworthTime AddMinutes(double minutes) => new CotsworthTime(ticks + (long)(minutes * TicksPerMinute));
        public CotsworthTime AddSeconds(double seconds) => new CotsworthTime(ticks + (long)(seconds * TicksPerSecond));
        public CotsworthTime AddMilliseconds(double milliseconds) => new CotsworthTime(ticks + (long)(milliseconds * TicksPerMillisecond));
        public CotsworthTime AddTicks(long ticksToAdd) => new CotsworthTime(ticks + ticksToAdd);

        public TimeSpan Add(CotsworthTime value) => TimeSpan.FromTicks(ticks + value.ticks);
        public CotsworthTime Add(TimeSpan value) => new CotsworthTime(ticks + value.Ticks);

        public TimeSpan Subtract(CotsworthTime value) => TimeSpan.FromTicks(ticks - value.ticks);
        public CotsworthTime Subtract(TimeSpan value) => new CotsworthTime(ticks - value.Ticks);

        #endregion

        #region Comparison / Equals

        public bool Equals(CotsworthTime other) => ticks == other.ticks;
        public override bool Equals(object obj) => obj is CotsworthTime other && Equals(other);
        public override int GetHashCode() => ticks.GetHashCode();

        public int CompareTo(CotsworthTime other) => ticks.CompareTo(other.ticks);
        public int CompareTo(object obj) => obj is CotsworthTime other ? CompareTo(other) : throw new ArgumentException("Object is not a CotsworthTime");

        public static bool operator ==(CotsworthTime left, CotsworthTime right) => left.Equals(right);
        public static bool operator !=(CotsworthTime left, CotsworthTime right) => !left.Equals(right);

        public static bool operator <(CotsworthTime left, CotsworthTime right) => left.ticks < right.ticks;
        public static bool operator <=(CotsworthTime left, CotsworthTime right) => left.ticks <= right.ticks;

        public static bool operator >(CotsworthTime left, CotsworthTime right) => left.ticks > right.ticks;
        public static bool operator >=(CotsworthTime left, CotsworthTime right) => left.ticks >= right.ticks;

        public static TimeSpan operator +(CotsworthTime left, CotsworthTime right) => left.Add(right);
        public static CotsworthTime operator +(CotsworthTime time, TimeSpan span) => time.Add(span);

        public static TimeSpan operator -(CotsworthTime left, CotsworthTime right) => left.Subtract(right);
        public static CotsworthTime operator -(CotsworthTime time, TimeSpan span) => time.Subtract(span);

        #endregion

        #region String Formatting

        public string ToString(string format)
        {
            if (string.IsNullOrEmpty(format))
                return ToString();

            return format
                .Replace("YYYY", Year.ToString("D4"))
                .Replace("YY", (Year % 100).ToString("D2"))
                .Replace("MMMM", MonthName)
                .Replace("MMM", MonthName.Substring(0, Math.Min(3, MonthName.Length)))
                .Replace("MM", Month.ToString("D2"))
                .Replace("M", Month.ToString())
                .Replace("DDDD", DayName)
                .Replace("DDD", DayName.Substring(0, Math.Min(3, DayName.Length)))
                .Replace("DD", Day.ToString("D2"))
                .Replace("D", Day.ToString())
                .Replace("hh", (Hour % 12 == 0 ? 12 : Hour % 12).ToString("D2"))
                .Replace("h", (Hour % 12 == 0 ? 12 : Hour % 12).ToString())
                .Replace("HH", Hour.ToString("D2"))
                .Replace("H", Hour.ToString())
                .Replace("mm", Minute.ToString("D2"))
                .Replace("m", Minute.ToString())
                .Replace("ss", Second.ToString("D2"))
                .Replace("s", Second.ToString())
                .Replace("fff", Millisecond.ToString("D3"))
                .Replace("tt", Hour < 12 ? "AM" : "PM")
                .Replace("t", Hour < 12 ? "A" : "P");
        }

        public string ToShortDateString() => $"{Month:D2}/{Day:D2}/{Year}";
        public string ToLongDateString() => $"{DayName}, {MonthName} {Day}, {Year}";
        public string ToShortTimeString() => $"{Hour:D2}:{Minute:D2}";
        public string ToLongTimeString() => $"{Hour:D2}:{Minute:D2}:{Second:D2}";

        public override string ToString() => $"{ToShortDateString()} {ToShortTimeString()}";

        #endregion

        #region Static Helpers

        public static bool IsValidDate(int year, int month, int day)
        {
            if (year < 1 || year > 9999)
                return false;

            if (month < 1 || month > 13)
                return false;

            if (month == 13)
                return day == 29; // Year Day

            if (month == 6 && day == 29)
                return DateTime.IsLeapYear(year); // Leap Day on Leap Year

            return day >= 1 && day <= 28;
        }
        
        public static int DaysInMonth(int year, int month)
        {
            if (month == 13)
                return 1;

            if (month == 6 && DateTime.IsLeapYear(year))
                return 29;

            return 28;
        }

        public static CotsworthTime Parse(string s)
        {
            if (TryParse(s, out CotsworthTime result))
                return result;

            throw new FormatException($"String '{s}' was not recognized as a valid CotsworthTime.");
        }

        #endregion
    }
}
