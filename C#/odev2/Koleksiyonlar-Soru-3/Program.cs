using System.Text.RegularExpressions;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz!");
            string cumle = Console.ReadLine();

            Regex rgx = new Regex(@"[aeouiöüAEOUİÖÜ]");
            MatchCollection sesliHarfler = rgx.Matches(cumle);

            foreach (var harf in sesliHarfler)
            {
                Console.WriteLine(harf);
            }
        }
    }
}