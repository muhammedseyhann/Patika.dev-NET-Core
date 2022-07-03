namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            // 1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplama
            // Console.Write("Bir sayı giriniz: ");
            // int sayi = int.Parse(Console.ReadLine());
            // int sayac = 1;
            // int toplam = 0;
            // while (sayac <= sayi)
            // {
            //     toplam += sayac;
            //     sayac++;
            // }

            // Console.WriteLine(toplam/sayi);

            // char character = 'a';
            // while (character <= 'z') {
            //     Console.Write(character);
            //     character ++;
            // }

            Console.Write("***** Foreach *****");

            string[] arabalar = {"BMW", "Ford", "Toyota", "Nissan"};

            foreach (var araba in arabalar) 
            {
                Console.WriteLine(araba);
            }
        }
    }
}