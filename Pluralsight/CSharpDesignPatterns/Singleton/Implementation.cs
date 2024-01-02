﻿using System;

namespace Singleton;

/// <summary>
/// Singleton
/// </summary>
public class Logger
{
    private static Logger? _instance;
    /// <summary>
    ///  Clients cannot instantiate this
    /// </summary>
    protected Logger()
    {

    }

    public static Logger Instance {
        get
        {
            if( _instance == null )
                _instance = new Logger();

            return _instance;
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