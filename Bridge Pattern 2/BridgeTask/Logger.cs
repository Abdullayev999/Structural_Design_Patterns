namespace BridgeTask
{
    abstract class Logger
    {
        public Logger(IWriter writer)
        {
            this.writer = writer;
        }
        protected IWriter writer;
        public abstract void LogInfo(string message);
        public abstract void LogWarning(string message);
        public abstract void LogEror(string message);
        public abstract void LogPrint();

    }
}
