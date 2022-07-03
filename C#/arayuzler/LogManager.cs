namespace arayuzler
{
    public class LogManager : Ilogger
    {
        public Ilogger _logger;

        public LogManager(Ilogger logger)
        {
            _logger = logger;
        }

        public void writeLog()
        {
            _logger.writeLog();
        }
    }
}