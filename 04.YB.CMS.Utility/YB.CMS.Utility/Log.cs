[assembly: log4net.Config.XmlConfigurator(ConfigFile = "Config/log4net.config", Watch = true)]
namespace YB.CMS.Utility
{
    using log4net;
    using System;
    using System.Diagnostics;
    /// <summary>
    /// log4net 日志处理
    /// </summary>
    public class Log
    {
        /// <summary>
        /// Error 信息记录
        /// </summary>
        /// <param name="strMessage">记录内容</param>
        public static void Error(string strMessage)
        {
            log4net.ILog log = log4net.LogManager.GetLogger("Error");
            if (log.IsErrorEnabled)
            {
                log.Error(strMessage);
            }
            log = null;
        }

        /// <summary>
        /// Debug 信息记录
        /// </summary>
        /// <param name="strMessage">记录内容</param>
        public static void Debug(string strMessage)
        {
            log4net.ILog log = log4net.LogManager.GetLogger("Debug");
            if (log.IsErrorEnabled)
            {
                log.Error(strMessage);
            }
            log = null;
        }

        /// <summary>
        /// Info 信息记录
        /// </summary>
        /// <param name="message">记录内容</param>
        public static void Info(string message)
        {
            log4net.ILog log = log4net.LogManager.GetLogger("Info");
            if (log.IsInfoEnabled)
            {
                log.Info(message);
            }
            log = null;
        }
        public static void Error(object message)
        {
            LogManager.GetLogger(GetCurrentMethodFullName()).Error(message);
        }

        public static void Error(object message, Exception exception)
        {
            LogManager.GetLogger(GetCurrentMethodFullName()).Error(message, exception);
        }
        private static string GetCurrentMethodFullName()
        {
            try
            {
                StackFrame frame;
                string str2;
                int num = 2;
                StackTrace trace = new StackTrace();
                int length = trace.GetFrames().Length;
                do
                {
                    frame = trace.GetFrame(num++);
                    str2 = frame.GetMethod().DeclaringType.ToString();
                }
                while (str2.EndsWith("Excption") && (num < length));
                string name = frame.GetMethod().Name;
                return (str2 + "." + name);
            }
            catch
            {
                return null;
            }
        }
    }
}
