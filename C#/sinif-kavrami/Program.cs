namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            //class SinifAdi
            //[Erişim Belirleyici] [Veri Tipi] özellikAdi; -> Property Tanımı

            //[Erişim Belirleyici] [Geri Dönüş Tipi] Method Adı([Parametre Listesi]); -> Property Tanım
            // {
            // Method Komutları
            // }

            //Erişim Belirleyicler
            //public -> Her yerden erişilebilen
            //private -> Tanımlandığı sınıf içerisinden erişilebilen, property'ler private'dir.
            //internal -> Sadece o proje içerisinde erişilebilir
            //protected -> Sadece tanımlandığı sınıfta veya katılım ile aktarılan sınıflarda kullanılabilir.

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 23425634;
            calisan1.Departman = "İnsan Kaynaklari";

            calisan1.CalisanBilgileri();
            Console.WriteLine("********************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 25646789;
            calisan2.Departman = "Satın Alma";

            calisan2.CalisanBilgileri();
        }

    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}", No);
            Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
        }
    }
}

