namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static olmayanlara o sınıfın bir nesnesi oluşturularak erişilebilir.
            // ***Static olanlara ise SınıfAdi.static_method şeklinde erişilir. Static sınıflarda kalıtım işlemi uygulanamaz.
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.Calisansayisi);

            Calisan calisan = new Calisan("Ayşe", "Yılmaz", "IK");
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.Calisansayisi);

            Console.WriteLine("Toplama işlemi sonucu : {0}", Islemler.Topla(100, 200));
            Console.WriteLine("Çıkarma işlemi sonucu : {0}", Islemler.Cikar(400, 50));
        }
    }

    class Calisan
    {
        private static int calisansayisi; //Her zaman sınıf içerisnde erişilebilir.

        public static int Calisansayisi { get => calisansayisi; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan() //Static kurucuların erişim belirteçleri olmaz. Static kurucular için ilk çalıştırıldığında girilir daha girilmez.
        {
            calisansayisi = 0;
        }
        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisansayisi++;
        }
    }

    static class Islemler //****Bir sınıf static olursa tüm üyeler static olmak zorundadır.
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}