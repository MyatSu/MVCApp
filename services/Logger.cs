using System;
using System.Collections.Generic;

namespace MVCApp.services;

public sealed class Logger
{
    private static readonly Logger _instance = new Logger();
    private readonly List<string> _logs = new List<string>();
    private Logger()
    {

    }
    public static Logger Instance
    {
        get
        {
            return _instance;
        }
    }
    public void log(string message)
    {
        string logEntry = $"{DateTime.Now}:{message}";
        _logs.Add(logEntry);
        Console.WriteLine(logEntry);
    }

}
