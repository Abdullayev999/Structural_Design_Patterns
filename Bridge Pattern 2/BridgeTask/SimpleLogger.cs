using System.Collections.Generic;

namespace BridgeTask
{
    class SimpleLogger : Logger
    {
        public SimpleLogger(IWriter writer) : base(writer)
        {
            logger = new List<string>();
        }

        private List<string> logger;
        public override void LogEror(string message)
        {
            logger.Add($"Eror : {message}");
        }

        public override void LogInfo(string message)
        {
            logger.Add($"Info : {message}");
        }

        public override void LogWarning(string message)
        {
            logger.Add($"Warning : {message}");
        }

        public override void LogPrint()
        {
            writer.Write(logger);
        }
    }
}
