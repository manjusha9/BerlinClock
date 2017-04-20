using System;

namespace BerlinClock
{
    public abstract class TimeFormatCreator
    {
        public abstract ITimeFormatFactory setTimeFormat(String format);

        public abstract ITimeFormatFactory getTimeFormat(String format);
    }
}
