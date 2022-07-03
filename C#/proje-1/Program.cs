namespace proje_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Rehber> kisiler = new List<Rehber>();
            Rehber kisi1 = new Rehber("Muhammed", "Seyhan", 123);
            kisiler.Add(kisi1);
            Rehber kisi2 = new Rehber("Ayşe", "Deniz", 456);
            kisiler.Add(kisi2);
            Rehber kisi3 = new Rehber("Zikriye", "Ürkmez", 789);
            kisiler.Add(kisi3);
            Rehber kisi4 = new Rehber("Mustafa", "Parlak", 112);
            kisiler.Add(kisi4);
            Rehber kisi5 = new Rehber("Ali", "Ural", 175);
            kisiler.Add(kisi5);

            while (true)
            {
                Console.WriteLine(@"Lütfen yapmak istediğiniz işlemi seçiniz :) 
*******************************************
(1) Yeni Numara Kaydetmek
(2) Varolan Numarayı Silmek
(3) Varolan Numarayı Güncelleme
(4) Rehberi Listelemek
(5) Rehberde Arama Yapmak
(6) Çıkış");

                string islemNumarasi = Console.ReadLine();
                if (islemNumarasi == "1")
                    kisiler = YeniNumaraKaydet(kisiler);
                else if (islemNumarasi == "2")
                    NumaraSil(kisiler);
                else if (islemNumarasi == "3")
                    NumaraGuncelleme(kisiler);
                else if (islemNumarasi == "4")
                    NumaraListeleme(kisiler);
                else if (islemNumarasi == "5")
                    Arama(kisiler);
                else if (islemNumarasi == "6")
                    break;
            }

        }

        public static List<Rehber> YeniNumaraKaydet(List<Rehber> liste)
        {
            Console.WriteLine("Lütfen isim giriniz             :");
            string isim = Console.ReadLine();

            Console.WriteLine("Lütfen soyisim giriniz          :");
            string soyisim = Console.ReadLine();

            Console.WriteLine("Lütfen telefon numarası giriniz :");
            int numara = Convert.ToInt32(Console.ReadLine());

            liste.Add(new Rehber(isim, soyisim, numara));
            return liste;
        }

        public static List<Rehber> NumaraSil(List<Rehber> liste)
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string aranilacakIsim = Console.ReadLine();

            int oldCount = liste.Count;
            for (int i = 0; i < oldCount; i++)
            {
                if (liste[i].Ad.Contains(aranilacakIsim, StringComparison.OrdinalIgnoreCase) || liste[i].Soyad.Contains(aranilacakIsim, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(liste[i].Ad + " " + liste[i].Soyad + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                    string confirm = Console.ReadLine().ToLower();
                    if (confirm == "y")
                    {
                        liste.RemoveAt(i);
                        break;
                    }
                }
            }

            if (oldCount == liste.Count)
            {
                Console.WriteLine(@"Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.
* Silmeyi sonlandırmak için : (1)
* Yeniden denemek için      : (2)");
                int islem = Convert.ToInt32(Console.ReadLine());
                if (islem == 2)
                    NumaraSil(liste);
            }
            return liste;
        }

        public static List<Rehber> NumaraGuncelleme(List<Rehber> liste)
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string aranilacakIsim = Console.ReadLine();

            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i].Ad.Contains(aranilacakIsim, StringComparison.OrdinalIgnoreCase) || liste[i].Soyad.Contains(aranilacakIsim, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(liste[i].Ad + " " + liste[i].Soyad + " isimli kişinin yeni numarasını yazınız:");
                    int numara = Convert.ToInt32(Console.ReadLine());
                    liste[i].No = numara;
                    return liste;
                }
            }

            Console.WriteLine(@"Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.
* Güncellemeyi sonlandırmak için : (1)
* Yeniden denemek için      : (2)");
            int islem = Convert.ToInt32(Console.ReadLine());
            if (islem == 2)
                NumaraGuncelleme(liste);
            return liste;
        }

        public static void NumaraListeleme(List<Rehber> liste)
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");

            foreach (var kisi in liste)
            {
                Console.WriteLine("isim: " + kisi.Ad);
                Console.WriteLine("Soyisim: " + kisi.Soyad);
                Console.WriteLine("Telefon Numarası: " + kisi.No);
                Console.WriteLine("-------");
            }
        }

        public static void Arama(List<Rehber> liste)
        {
            Console.WriteLine(@"Arama yapmak istediğiniz tipi seçiniz.
**********************************************
 
İsim veya soyisime göre arama yapmak için: (1)
Telefon numarasına göre arama yapmak için: (2)");

            int islem = Convert.ToInt32(Console.ReadLine());
            if (islem == 1)
            {
                Console.WriteLine("Lütfen numarasını aramak istediğiniz kişinin adını ya da soyadını giriniz:");
                string aranilacakIsim = Console.ReadLine();

                for (int i = 0; i < liste.Count; i++)
                {
                    if (liste[i].Ad.Contains(aranilacakIsim, StringComparison.OrdinalIgnoreCase) || liste[i].Soyad.Contains(aranilacakIsim, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("isim: " + liste[i].Ad);
                        Console.WriteLine("Soyisim: " + liste[i].Soyad);
                        Console.WriteLine("Telefon Numarası: " + liste[i].No);
                        Console.WriteLine("-------");
                    }
                }
            }
            else
            {
                Console.WriteLine("Lütfen numarasını aramak istediğiniz kişinin numarasını giriniz:");
                string aranilacakNumara = Console.ReadLine();
                for (int i = 0; i < liste.Count; i++)
                {
                    if (liste[i].No.ToString().Contains(aranilacakNumara))
                    {
                        Console.WriteLine("isim: " + liste[i].Ad);
                        Console.WriteLine("Soyisim: " + liste[i].Soyad);
                        Console.WriteLine("Telefon Numarası: " + liste[i].No);
                        Console.WriteLine("-------");
                    }
                }
            }
        }
    }

    class Rehber
    {
        private string ad;
        private string soyad;
        private int no;

        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public int No { get => no; set => no = value; }

        public Rehber(string ad, string soyad, int no)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.no = no;
        }

        public Rehber() { }
    }
}