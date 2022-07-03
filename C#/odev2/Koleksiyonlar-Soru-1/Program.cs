using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sayilar = new ArrayList();

            int length = 0;

            while (length < 20)
            {
                Console.WriteLine("{0}. pozitif sayıyı giriniz.     :", length + 1);
                try
                {
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi < 0)
                    {
                        Console.WriteLine("Sayı pozitif olmalıdır.");
                        continue;
                    }
                    sayilar.Add(sayi);
                    length++;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Bir sayı girmelisiniz.");
                }
            }

            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();

            foreach (var sayi in sayilar)
            {
                if (isPrime((int)sayi))
                    asalSayilar.Add(sayi);
                else
                    asalOlmayanSayilar.Add(sayi);
            }

            Console.WriteLine("***** Asal Sayıların Büyükten Küçüğe Sıralanışı *******");
            getSorted(asalSayilar);

            Console.WriteLine("***** Asal Olmayan Sayıların Büyükten Küçüğe Sıralanışı *******");
            getSorted(asalOlmayanSayilar);

            Console.WriteLine("***** Asal Sayıların : *******");
            getMean(asalSayilar);

            Console.WriteLine("***** Asal Olmayan Sayıların : *******");
            getMean(asalOlmayanSayilar);

        }

        public static bool isPrime(int sayi)
        {
            if (sayi == 2)
                return true;
            else if (sayi == 1)
                return false;

            int sqrt = (int)Math.Ceiling(Math.Sqrt(sayi));

            for (int i = 2; i <= sqrt; i++)
            {
                if (sayi % i == 0)
                    return false;
            }
            return true;
        }

        public static void getSorted(ArrayList liste)
        {
            liste.Sort();
            liste.Reverse();
            foreach (var sayi in liste)
            {
                Console.WriteLine(sayi);
            }
        }
        public static void getMean(ArrayList liste)
        {
            int count = liste.Count;
            int sum = 0;

            foreach (var sayi in liste)
            {
                sum += (int)sayi;
            }

            double mean = sum / count;
            Console.WriteLine("Eleman sayısı:   {0}, ortalaması:     {1}", count, mean);
        }
    }
}