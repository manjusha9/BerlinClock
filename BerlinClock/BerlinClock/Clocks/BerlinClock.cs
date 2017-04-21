using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock
{
    class BerlinClock
    {
        private String defaultHourAndQuarterLamp = "R"; //Red
        private String defaultMinuteLamp = "Y"; //Yellow
        private String defaultOffLamp = "B"; //Black

        public BerlinClock(Time time)
        {
            BerlinClock(time, defaultHourAndQuarterLamp, defaultMinuteLamp, defaultOffLamp);
        }

        public BerlinClock(Time time, String hourAndQuarterLamp, String minuteLamp, String offLamp)
        {
            this.defaultHourAndQuarterLamp = hourAndQuarterLamp;
            this.defaultMinuteLamp = minuteLamp;
            this.defaultOffLamp = offLamp;
        }

        public String showTime()
        {

        }
    }
}