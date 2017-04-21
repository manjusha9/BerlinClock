using System;

/// <summary>
/// Using Factory Design Pattern
/// http://www.dotnettricks.com/learn/designpatterns/factory-method-design-pattern-dotnet
/// </summary>

namespace BerlinClockProgram
{
    public interface ITimeFormatFactory
    {
        Time setTime(String time);

        String getTime(Time time);
    }
}
