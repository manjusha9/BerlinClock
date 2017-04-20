using System;

namespace BerlinClock
{
    public class ConcreteTimeFormatCreator : TimeFormatCreator
    {
        public override ITimeFormatFactory setTimeFormat(String format)
        {
            switch (format)
            {
                case "Simple": return new SimpleFormat();
                default: return new SimpleFormat();
            }
        }

        public override ITimeFormatFactory getTimeFormat(String format)
        {
            switch (format)
            {
                case "Simple": return new SimpleFormat();
                case "Berlin": return new BerlinFormat();
                default: return new BerlinFormat();
            }
        }
    }
}