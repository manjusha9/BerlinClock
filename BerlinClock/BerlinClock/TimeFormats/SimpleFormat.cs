using System;

namespace BerlinClockProgram
{
    public class SimpleFormat : ITimeFormatFactory
    {
        public Time setTime(String time)
        {
            char[] delimiterChars = {':'};
            String[] splitTime = time.Split(delimiterChars);
            Time simpleTime = new Time(Int32.Parse(splitTime[2]), Int32.Parse(splitTime[1]), Int32.Parse(splitTime[0]));
            return simpleTime;
        }
        
        public String getTime(Time time)
        {
            return time.getHours() + ":" + time.getMinutes() + ":" + time.getSeconds();
        }
    }
}
