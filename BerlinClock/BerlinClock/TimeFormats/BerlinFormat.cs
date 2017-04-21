using System;

namespace BerlinClockProgram
{
     public class BerlinFormat : ITimeFormatFactory
    {
        private Time time;
        private int on = 1;
        private int off = 0;
        public String berlinFormatResult = "";

        public String getTime(Time time)
        {
            return getSeconds(time.getSeconds()) + getHours(time.getHours()) + getMinutes(time.getMinutes());
        }

        public Time setTime(String time)
        {
            return null;
        }

        private String getSeconds(int seconds)
        {
            if ((seconds) % 2 == 0)
            {
                return on.ToString();
            }
            else return off.ToString();
        }

        private String getHours(int hours)
        {
            int fiveHourLamps = hours / 5;
            int oneHourLamps = hours % 5;
            String hourString = "00000000";
            if(fiveHourLamps>0)
            {
                hourString.Remove(0, fiveHourLamps).Insert(0, "1");
            }
            if (oneHourLamps > 0)
            {
                hourString.Remove(4, oneHourLamps).Insert(4, "1");
            }
            return hourString;

        }

        private String getMinutes(int minutes)
        {
            int fiveMinsLamps = minutes / 5;
            int oneMinLamps = minutes % 5;
            String minuteString = "000000000000000";
            if (fiveMinsLamps > 0)
            {
                minuteString.Remove(0, fiveMinsLamps).Insert(0, "1");
            }
            if (oneMinLamps > 0)
            {
                minuteString.Remove(11, oneMinLamps).Insert(11, "1");
            }
            return minuteString;
        }
    }
}
