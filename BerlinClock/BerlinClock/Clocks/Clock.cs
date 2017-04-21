using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClockProgram
{
    abstract public class Clock
    {
        public ITimeFormatFactory timeFormat;
        abstract public String showTime();
    }
}