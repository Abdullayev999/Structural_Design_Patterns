using System;
using System.Collections.Generic;

namespace BridgeTask
{
    class DetailedLogger : Logger
    {
        public DetailedLogger(IWriter writer) : base(writer)
        {
            logger = new List<string>();
        }

        private List<string> logger;
        public override void LogEror(string message)
        {
            logger.Add($"Time : {DateTime.Now}  Eror :  {message}");
        }

        public override void LogInfo(string message)
        {
            logger.Add($"Time : {DateTime.Now}  Info :  {message}");
        }

        public override void LogWarning(string message)
        {
            logger.Add($"Time : {DateTime.Now}  Warning :  {message}");
        }

        public override void LogPrint()
        {
            writer.Write(logger);
        }
    }
}
