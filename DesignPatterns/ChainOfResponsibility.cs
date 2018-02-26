using System;

namespace DesignPatterns
{
    public interface ILogger
    {
        void Log();
    }

    public class Logger : ILogger
    {
        public void Log() => Console.Out.WriteLine("logging");
    }

    public abstract class LogHandler
    {
        private readonly LogHandler _nextLogHandler;
        private readonly ILogger _logger;

        protected LogHandler(ILogger logger, LogHandler nextLogHandler)
        {
            _nextLogHandler = nextLogHandler;
            _logger = logger;
        }

        public void DoSth(int logLevel)
        {
            if (IsCorrectLogLevel(logLevel))
            {
                _logger.Log();
            }

            _nextLogHandler?.DoSth(logLevel);
        }

        protected abstract bool IsCorrectLogLevel(int logLevel);
    }

    public class FirstConcreteLogHandler : LogHandler
    {
        public FirstConcreteLogHandler(ILogger logger, LogHandler nextLogHandler = null) : base(logger, nextLogHandler)
        {
        }

        protected override bool IsCorrectLogLevel(int logLevel) => logLevel > 0;
    }

    public class SecondConcreteLogHandler : LogHandler
    {
        public SecondConcreteLogHandler(ILogger logger, LogHandler nextLogHandler = null) : base(logger, nextLogHandler)
        {
        }

        protected override bool IsCorrectLogLevel(int logLevel) => logLevel > 5;
    }
}