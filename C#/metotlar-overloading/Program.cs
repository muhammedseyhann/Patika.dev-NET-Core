namespace metot_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";
            int outSayi;

            bool sonuc = int.TryParse(sayi, out outSayi);

            if (sonuc) {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else {
                Console.WriteLine("Başarısız");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4,5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //Metot Aşırı Yükleme - Overloading

            int ifade = 999;
            instance.EkranaYazdır(Convert.ToString(ifade));
            instance.EkranaYazdır(ifade);
            instance.EkranaYazdır("Hello","World");

            // Metot Imzası
            // metotAdı + parametre sayisi + parametre


        }
        class Metotlar
        {
            public void Topla(int a, int b, out int Toplam) 
            {
                Toplam = a+b;
            }

            public void EkranaYazdır(string veri)
            {
                Console.WriteLine(veri);
            }

            public void EkranaYazdır(int veri)
            {
                Console.WriteLine(veri);
            }

            public void EkranaYazdır(string veri1, string veri2)
            {
                Console.WriteLine(veri1 + veri2);
            }
        }
    }
}