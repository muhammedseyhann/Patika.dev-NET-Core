namespace console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi Girin: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soy İsminizi Girin: ");
            string surname = Console.ReadLine();
            
            Console.WriteLine("Merhaba " + name + " " + surname);
        }

    }
}