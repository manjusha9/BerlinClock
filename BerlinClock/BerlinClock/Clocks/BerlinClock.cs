using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock
{
    class BerlinClock
    {
        private String hourAndQuarterLampColor = "R"; //Red
        private String minuteLampColor = "Y"; //Yellow
        private String secondLampColor = "Y"; //Yellow
        private String offLampColor = "O"; //Off

        private int secondsLampPos = 0;
        private int fiveHoursLampPos = 1;
        private int oneHourLampPos = 5;
        private int fiveMinutesLampPos = 9;
        private int oneMinuteLampPos = 20;

        private int numSecondLamps = 1;
        private int numHoursLamp = 4;
        private int numFiveMinutesLamp = 11;
        private int numOneMinuteLamps = 4;

        public BerlinClock(Time time)
        {
            BerlinClock(time, hourAndQuarterLampColor, minuteLampColor, secondLampColor, offLampColor);
        }

        public BerlinClock(Time time, String hourAndQuarterLampColor, String minuteLampColor, String secondLampColor, String offLampColor)
        {
            this.hourAndQuarterLampColor = hourAndQuarterLampColor;
            this.minuteLampColor = minuteLampColor;
            this.secondLampColor = secondLampColor;
            this.offLampColor = offLampColor;
        }

        public String showTime()
        {
            String berlinFormat = timeFormat.getTime();
            String berlinResult = setLampColor(berlinFormat.Substring(secondsLampPos, numSecondLamps), secondLampColor)
                 + " " + setLampColor(berlinFormat.Substring(fiveHoursLampPos, numHoursLamp), hourAndQuarterLampColor)
                 + " " + setLampColor(berlinFormat.Substring(oneHourLampPos, numHoursLamp), hourAndQuarterLampColor)
                 + " " + setLampColor(berlinFormat.Substring(fiveMinutesLampPos, numFiveMinutesLamp), minuteLampColor)
                 + " " + setLampColor(berlinFormat.Substring(oneMinuteLampPos, numOneMinuteLamps), minuteLampColor);

            return berlinResult;
        }

        private String setLampColor(String input, String onColor)
        {
            String colorOutput = "";
            int count = 0;
            foreach (char c in input)
            {
                if (c.Equals('1'))
                    colorOutput += onColor;
                else
                    colorOutput += offLampColor;
                count++;
            }

            if(input.Length==11 && count>2)
            {
                int pos = 2;
                for(int i =0; i < count / 3; i++)
                {
                    colorOutput.Remove(pos, 1).Insert(pos, hourAndQuarterLampColor);
                    pos = pos + 3;
                }
            }
            return colorOutput;
        }
    }
}