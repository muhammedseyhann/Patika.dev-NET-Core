namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Soru
            FirstQuestion();

            //2. Soru
            SecondQuestion();

            //3.Soru
            ThirdQuestion();

            //4.Soru
            FourthQuestion();
            
        }
        static void FirstQuestion()
        {
            Console.WriteLine("Pozitif bir sayı girin (n) : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] sayiDizisi = new int[n];

            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                Console.WriteLine("{0}. sayıyı girin (n) :", i+1);
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayiDizisi[i] = sayi;
            }

            foreach (var sayi in sayiDizisi)
            {
                if(sayi%2 == 0)
                    Console.WriteLine(sayi);
            }
        }
        static void SecondQuestion()
        {
            Console.WriteLine("Pozitif iki sayıdan 1. girin (n) : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pozitif iki sayıdan 2. girin (m) : ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[] sayiDizisi = new int[n];

            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                Console.WriteLine("{0}. sayıyı girin (n) :", i+1);
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayiDizisi[i] = sayi;
            }

            foreach (var sayi in sayiDizisi)
            {
                if(sayi%m == 0)
                    Console.WriteLine(sayi);
            }
            
        }

        static void ThirdQuestion()
        {
            Console.WriteLine("Pozitif iki sayıdan 1. girin (n) : ");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] kelimeDizisi = new string[n];

            for (int i = 0; i < kelimeDizisi.Length; i++)
            {
                Console.WriteLine("{0}. kelimeyi girin (n) :", i+1);
                string kelime = Console.ReadLine();
                kelimeDizisi[i] = kelime;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(kelimeDizisi[(n -1)-i]);
            }
        }

        static void FourthQuestion()
        {
            Console.WriteLine("Bir cümle Yazın : ");
            string cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(" ");
            
            int harfSayisi = 0;

            foreach (var kelime in kelimeler)
            {
                harfSayisi += kelime.Length;
            }
            Console.WriteLine("Toplam kelime sayısı: {0}, Toplam harf sayısı {1}", kelimeler.Length, harfSayisi);
        }
    }
}