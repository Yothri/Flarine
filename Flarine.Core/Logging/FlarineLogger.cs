using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace Flarine.Core.Logging
{
    internal sealed class FlarineLogger : ILogger
    {
        public FlarineLogger(string categoryName)
        {
            CategoryName = categoryName;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if(IsEnabled(logLevel))
            {
                lock(_lockObj)
                {
                    Console.ForegroundColor = LogLevelColors[logLevel];
                    Console.Write($"[{CategoryName.Split('.').Last()}]");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(formatter(state, exception));
                }
            }
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public readonly string CategoryName;
        private static object _lockObj = new object();
        private static Dictionary<LogLevel, ConsoleColor> LogLevelColors = new Dictionary<LogLevel, ConsoleColor>
        {
            { LogLevel.Trace, ConsoleColor.Magenta },
            { LogLevel.Debug, ConsoleColor.DarkYellow },
            { LogLevel.Information, ConsoleColor.Green },
            { LogLevel.Warning, ConsoleColor.Yellow },
            { LogLevel.Error, ConsoleColor.Red },
            { LogLevel.Critical, ConsoleColor.DarkRed }
        };
    }
}