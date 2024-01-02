using System;

namespace Singleton;

/// <summary>
/// Singleton
/// </summary>
public class Logger
{
    private static readonly Lazy<Logger> _lazyLogger
        = new Lazy<Logger>(() =>new Logger());
    
     public static Logger Instance {
        get
        {
            return _lazyLogger.Value;
        }
    }

    /// <summary>
    /// Singleton Operation
    /// </summary>
    /// <param name="message">Message to log</param>
    public void Log(string message)
    {
        Console.WriteLine($"Logged message {message}");
    }
}