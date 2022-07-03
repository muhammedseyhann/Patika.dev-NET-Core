namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Kapsülleme => Bir nesnein bazı özelliklerini veya işlevlerini,metotlarının diğer classlardan ve diğer nesnelerden 
            korumak anlamına geliyor. Bu koruma işlemi erişim belirteçleri ile oluyor.*/
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Yılmaz";
            ogrenci.OgrenciNo = 293;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Deniz", "Arda", 256, 1);
            ogrenci1.OgrenciBilgileriniGetir();
            ogrenci1.SinifDusur();

        }
    }
    class Ogrenci
    {
        private string isim; //Private değişkenleri küçük harfle başlar.
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif
        {
            get => sinif;
            set
            {
                if (value <= 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir");
                    sinif = 1;
                }
                else
                    sinif = value;
            }
        }

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci() { }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("******************** Öğrenci Bilgileri **************");
            Console.WriteLine("Öğrenci Adı         :{0}", this.Isim);
            Console.WriteLine("Öğrenci Soyadı      :{0}", this.Soyisim);
            Console.WriteLine("Öğrenci No          :{0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı      :{0}", this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}