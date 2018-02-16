using Microsoft.Extensions.Logging;

namespace Flarine.Core.Logging
{
    internal sealed class FlarineLogProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            return new FlarineLogger(categoryName);
        }

        public void Dispose()
        {
        }
    }
}