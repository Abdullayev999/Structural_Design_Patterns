namespace BridgeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new SimpleLogger(new FileWriter("logger"));
            logger.LogEror("Viklyucili svet");
            logger.LogInfo("xorwaya skorost");
            logger.LogPrint();

            logger = new DetailedLogger(new ConsoleWriter("pogger"));
            logger.LogEror("Viklyucili svet");
            logger.LogInfo("xorwaya skorost");
            logger.LogPrint();
        }
    }
}
