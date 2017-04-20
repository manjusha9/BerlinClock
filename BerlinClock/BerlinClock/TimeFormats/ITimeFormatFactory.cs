using System;

/// <summary>
/// Using Factory Design Pattern
/// http://www.dotnettricks.com/learn/designpatterns/factory-method-design-pattern-dotnet
/// </summary>

namespace BerlinClock
{
    interface ITimeFormatFactory
    {
        void setTime(String time);

        String getTime(DateTime time);
    }
}
