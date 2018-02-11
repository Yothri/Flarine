using System;
using System.Collections.Generic;

namespace Flarine.Core.Logging
{
    public enum LogLevel
    {
        Info,
        Warning,
        Error,
        Exception,
        Fatal
    }

    public static class Logger
    {

        private static bool initialized;
        private static readonly Dictionary<LogLevel, ConsoleColor> LogLevelColors = new Dictionary<LogLevel, ConsoleColor>()
        {
            { LogLevel.Info, ConsoleColor.White },
            { LogLevel.Warning,  ConsoleColor.Yellow },
            { LogLevel.Error, ConsoleColor.Red },
            { LogLevel.Exception, ConsoleColor.Magenta },
            { LogLevel.Fatal, ConsoleColor.DarkRed }
        };

        public static string GlobalTag { get; private set; }

        public static void Initialize(string globalTag)
        {
            if (!initialized)
                initialized = true;

            GlobalTag = globalTag;
        }

        public static void Log(string message, LogLevel level = LogLevel.Info)
        {
            if (!initialized)
                throw new InvalidOperationException("Logger has not been initialized yet.");

            Console.ForegroundColor = LogLevelColors[level];
            if (message.StartsWith("["))
                Console.WriteLine(message);
            else
                Console.WriteLine(string.Format("[{0}] {1}", GlobalTag, message));

            Console.ResetColor();
        }

        public static void Log(string tag, string message, LogLevel level = LogLevel.Info)
        {
            Log(string.Format("[{0}] {1}", tag, message), level);
        }

    }
}