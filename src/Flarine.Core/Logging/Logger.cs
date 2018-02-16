using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Flarine.Core.Logging
{
    public class Logger
    {
        static Logger()
        {
            _loggerDict = new Dictionary<Type, ILogger>();
            _loggerFactory = new LoggerFactory(new[] { new FlarineLogProvider() });
        }

        public static ILogger Get<T>()
        {
            if (!Loggers.ContainsKey(typeof(T)))
                Loggers.Add(typeof(T), LoggerFactory.CreateLogger<T>());

            return Loggers[typeof(T)];
        }

        public static void CleanUp()
        {
            Loggers?.Clear();
            LoggerFactory?.Dispose();
        }

        public static IDictionary<Type, ILogger> Loggers => _loggerDict;
        private static readonly Dictionary<Type, ILogger> _loggerDict;

        public static ILoggerFactory LoggerFactory => _loggerFactory;
        private readonly static ILoggerFactory _loggerFactory;
    }
}