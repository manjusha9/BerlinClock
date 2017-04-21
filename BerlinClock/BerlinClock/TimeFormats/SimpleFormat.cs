using System;

namespace BerlinClock
{
    class SimpleFormat : ITimeFormatFactory
    {
        public Time setTime(String time)
        {
            char[] delimiterChars = {':'};
            String[] splitTime = text.Split(delimiterChars);
            Time time = new time(Int32.Parse(timeValues[2]), Int32.Parse(timeValues[1]), Int32.Parse(timeValues[0]));
            return time;
        }
        
        public String getTime(Time time)
        {
            return time.getHours() + ":" + time.getMinutes() + ":" + time.getSeconds();
        }
    }
}
