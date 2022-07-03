namespace kurucu_metotlar
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

            Console.WriteLine("******* Çalışan 1 *********");
            Calisan calisan1 = new Calisan("Ayşe", "Kara", 23425634, "İnsan Kaynakları");
            calisan1.CalisanBilgileri();


            Console.WriteLine("******* Çalışan 2 *********");
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

        public Calisan(string ad, string soyad, int no, string departman) //Kurucu metod class ismi ile aynı olmak zorunda. Bu fonksiyonlar overload edilebilir.
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(string ad, string soyad) //Verilmeyen parametrelere default değerler atar
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan() { } // Bu şekilde parametre almadan da kurucu fonskiyon tanımlanabilir.

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}", No);
            Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
        }
    }
}

