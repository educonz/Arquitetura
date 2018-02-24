using Core.Logger;
using log4net;
using System;
using System.Reflection;

namespace Core.Provider.Log4net
{
    public class LoggerProvider : ILogger
    {
        private ILog _logger;
        private ILog Logger => _logger ?? (_logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType));

        public void SetMethodType(Type type) => _logger = LogManager.GetLogger(type);

        public void Debug(string message) => Logger.Debug(message);

        public void DebugFormat(string message, params object[] args) => Logger.DebugFormat(message, args);

        public void Error(string message) => Logger.Error(message);

        public void Error(string message, Exception exception) => Logger.Error(message, exception);

        public void ErrorFormat(string format, params object[] args) => Logger.ErrorFormat(format, args);

        public void Fatal(string message) => Logger.Fatal(message);

        public void Fatal(string message, Exception exception) => Logger.Fatal(message, exception);

        public void FatalFormat(string format, params object[] args) => Logger.FatalFormat(format, args);

        public void Info(string message) => Logger.Info(message);

        public void InfoFormat(string message, params object[] args) => Logger.InfoFormat(message, args);

        public void Warn(string message) => Logger.Warn(message);

        public void WarnFormat(string message, params object[] args) => Logger.WarnFormat(message, args);
    }
}
