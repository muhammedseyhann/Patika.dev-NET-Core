namespace WebApi.Services
{
    public class ConsoleLogger : IloggerService
    {
        public void Write(string message)
        {
            Console.WriteLine("[ConsoleLogger] - " + message);
        }
    }
}