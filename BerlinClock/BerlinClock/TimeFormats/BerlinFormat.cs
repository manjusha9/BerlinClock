using System;

namespace BerlinClock
{
    class BerlinFormat : ITimeFormatFactory
    {
        private Time time;
        private int on = 1;
        private int off = 0;
        private String berlinFormatResult = "";

        public String getTime()
        {
            return getSeconds(time.getSeconds) + getHours(time.getHours) + getMinutes(time.getMinutes);
        }

        public void setTime(String time)
        {
            
        }

        private String getSeconds(int seconds)
        {
            if ((seconds) % 2 == 0)
            {
                return on;
            }
            else return off;
        }

        private String getHours(int hours)
        {
            int fiveHourLamps = hours / 5;
            int oneHourLamps = hours % 5;
            String hours = "00000000";
            if(fiveHourLamps>0)
            {
                hours.Remove(0, fiveHourLamps).Insert(0, "1");
            }
            if (oneHourLamps > 0)
            {
                hours.Remove(4, oneHourLamps).Insert(4, "1");
            }
            return hours;

        }

        private String getMinutes(int minutes)
        {
            int fiveMinsLamps = minutes / 5;
            int oneMinLamps = minutes % 5;
            String minutes = "000000000000000";
            if (fiveMinsLamps > 0)
            {
                minutes.Remove(0, fiveMinsLamps).Insert(0, "1");
            }
            if (oneMinLamps > 0)
            {
                minutes.Remove(11, oneMinLamps).Insert(11, "1");
            }
            return minutes;
        }
    }
}
