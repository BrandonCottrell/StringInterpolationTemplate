using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number02()
    {
        var today = _date.Now;
        return $"{today:yyyy.MM.dd}";
    }

    public string Number03()
    {
        var today = _date.Now;
        return $"Day {today:dd} of {today:MMMM, yyyy}";
    }

    public string Number04()
    {
        var today = _date.Now;
        return $"Year: {today:yyyy}, Month:{today: MM}, Day:{today: dd}";
    }

    public string Number05()
    {
        var today = _date.Now;
        return $"{today,10:dddd}";
    }

    public string Number06()
    {
        var today = _date.Now;
        return $"{today,10:t}{today,10:dddd}";
    }

    public string Number07()
    {
        var today = _date.Now;
        return $"h:{today:hh}, m:{today:mm}, s:{today:ss}";
    }

    public string Number08()
    {
        var today = _date.Now;
        return $"{today:yyyy.MM.dd}.{today:hh.mm.ss}";
    }

    public string Number09()
    {
        var pi = Math.PI;
        return $"{pi:C2}";
    }

    public string Number10()
    {
        var pi = Math.PI;
        return $"{pi,10:N3}";
    }

    public string Number11()
    {
        int intValue = 2023;
        string currentYear = intValue.ToString("X3");
        return $"{currentYear}";
    }

    //2.2019.01.22
}
