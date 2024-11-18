using System;

public class Logger
{
    // Static field to hold the single instance
    private static Logger _instance;

    // Lock object for thread safety in multi-threaded environments
    private static readonly object _lock = new object();

    // Private constructor to prevent instantiation
    private Logger()
    {
        Console.WriteLine("Logger initialized.");
    }

    // Public static method to provide global access
    public static Logger GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
            }
        }
        return _instance;
    }

    // Example logging method
    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}
