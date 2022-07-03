namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar olan tek sayılarını ekrana yazdır.
            Console.WriteLine("Lütfen bir sayı giriniz. ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayac; i++)
            {
                if (i%2 == 1)
                    Console.WriteLine(i);
            }

            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerindeki toplamlarını ekrana yazdır.
            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i = 0; i <= 1000; i++)
            {
                if (i%2 == 1) 
                    tekToplam += i; 
                else 
                    ciftToplam += i;
            }

            Console.WriteLine("Tek toplam: "+ tekToplam);
            Console.WriteLine("Çift Toplam: " + ciftToplam);

            // break, continue

            for (int i = 0; i < 10; i++)
            {
                if (i==4) 
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}