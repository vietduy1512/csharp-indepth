using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Common.components
{
    public class DateTimeExample
    {
        public void Main()
        {
            DateTime dt1 = new DateTime(); // == 01/01/0001 00:00:00
            DateTime dt2 = new DateTime(2015, 12, 31); // year, month, day

            // Ticks        (100-nanosecond intervals that have elapsed since January 1, 0001, at 00:00:00.000)
            _ = dt1.Ticks;

            // TimeSpan     (represent time in days, hour, minutes, seconds, and milliseconds.)
            TimeSpan result = dt2 - dt1;

            // Format Date
            dt1.ToString("MM/dd/yyyy");
        }
    }
}
