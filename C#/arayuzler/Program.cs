namespace arayuzler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interface => Sinıfların içermesi gereken metotların imzalarının yer aldığı özelliklerin tanımlandığı bir taslaktır.
            // I ile başlar.
            // Interface'den kalıtım alan sınıfın sorumluluğunun, çerçevesinin çizilmesini yardımcı olur.

            FileLogger fileLogger = new FileLogger();
            fileLogger.writeLog();

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.writeLog();

            SmsLogger smsLogger = new SmsLogger();
            smsLogger.writeLog();

            LogManager logManager = new LogManager(new FileLogger());
            logManager.writeLog();
        }
    }
}