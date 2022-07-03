namespace proje_2
{
    class Todo
    {
        public static void BoardListeleme(List<Card> cards, Dictionary<int, string> uyeler)
        {
            List<Card> todoLine = cards.Where(item => item.Line == "TODO").ToList();
            List<Card> inProgressLine = cards.Where(item => item.Line == "IN_PROGRESS").ToList();
            List<Card> doneLine = cards.Where(item => item.Line == "DONE").ToList();

            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");
            if (todoLine.Count > 0)
            {
                foreach (var card in todoLine)
                {
                    Console.WriteLine("Başlık      : " + card.Baslik);
                    Console.WriteLine("İçerik      : " + card.Icerik);
                    Console.WriteLine("Atanan Kişi : " + uyeler[card.Kisi]);
                    Console.WriteLine("Büyüklük    : " + (Buyuklukler)card.Buyukluk);
                    Console.WriteLine("------------");
                }
            }
            else
                Console.WriteLine("~ BOŞ ~");

            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");
            if (inProgressLine.Count > 0)
            {
                foreach (var card in inProgressLine)
                {
                    Console.WriteLine("Başlık      : " + card.Baslik);
                    Console.WriteLine("İçerik      : " + card.Icerik);
                    Console.WriteLine("Atanan Kişi : " + uyeler[card.Kisi]);
                    Console.WriteLine("Büyüklük    : " + (Buyuklukler)card.Buyukluk);
                    Console.WriteLine("------------");
                }
            }
            else
                Console.WriteLine("~ BOŞ ~");

            Console.WriteLine("DONE Line");
            Console.WriteLine("************************");
            if (doneLine.Count > 0)
            {
                foreach (var card in doneLine)
                {
                    Console.WriteLine("Başlık      : " + card.Baslik);
                    Console.WriteLine("İçerik      : " + card.Icerik);
                    Console.WriteLine("Atanan Kişi : " + uyeler[card.Kisi]);
                    Console.WriteLine("Büyüklük    : " + (Buyuklukler)card.Buyukluk);
                    Console.WriteLine("------------");
                }
            }
            else
                Console.WriteLine("~ BOŞ ~");
        }

        public static List<Card> BoardaKartEkleme(List<Card> cards, Dictionary<int, string> uyeler)
        {

            Console.WriteLine("Başlık Giriniz                                  :");
            string yeniBaslik = Console.ReadLine();

            Console.WriteLine("İçerik Giriniz                                  :");
            string yeniIcerik = Console.ReadLine();

            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            int yeniBuyukluk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kişi Seçiniz (ID)                               :");
            int yeniKisi = Convert.ToInt32(Console.ReadLine());
            bool atanmisKisi = uyeler.ContainsKey(yeniKisi);
            if (!atanmisKisi)
                BoardaKartEkleme(cards, uyeler);

            Console.WriteLine("Line (TODO, IN_PROGRESS, DONE) Giriniz          :");
            string yeniLine = Console.ReadLine();

            if ((yeniKisi <= 0 || yeniKisi > uyeler.Count))
            {
                Console.WriteLine("Hatalı ID girildi veya bu ID'ye sahip kişiye bir görev atanmış.");
                return cards;
            }


            Card yeniCard = new Card(yeniLine, yeniBaslik, yeniIcerik, yeniKisi, yeniBuyukluk);
            cards.Add(yeniCard);
            return cards;
        }

        public static List<Card> BoardKartSilme(List<Card> cards)
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız: ");

            string baslik = Console.ReadLine();

            int oldCount = cards.Count;
            foreach (var card in cards)
            {
                if (card.Baslik.Contains(baslik, StringComparison.OrdinalIgnoreCase))
                {
                    cards.Remove(card);
                }
            }

            if (oldCount == cards.Count)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");

                string islem = Console.ReadLine();
                if (islem == "1")
                    return cards;
                else
                    BoardKartSilme(cards);
            }

            return cards;
        }

        public static void KartTasimak(List<Card> cards, Dictionary<int, string> uyeler)
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");

            string baslik = Console.ReadLine();

            int oldCount = cards.Count;
            foreach (var card in cards)
            {
                if (card.Baslik.Contains(baslik, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Bulunan Kart Bilgileri: ");
                    Console.WriteLine("************************");
                    Console.WriteLine("Başlık      : " + card.Baslik);
                    Console.WriteLine("İçerik      : " + card.Icerik);
                    Console.WriteLine("Atanan Kişi : " + uyeler[card.Kisi]);
                    Console.WriteLine("Büyüklük    : " + (Buyuklukler)card.Buyukluk);
                    Console.WriteLine("Line        :" + card.Buyukluk);
                    Console.WriteLine("\nLütfen taşımak istediğiniz Line'ı seçiniz:");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) IN PROGRESS");
                    Console.WriteLine("(3) DONE");

                    string islem = Console.ReadLine();

                    switch (islem)
                    {
                        case "1":
                            card.Line = "TODO";
                            BoardListeleme(cards, uyeler);
                            break;
                        case "2":
                            card.Line = "IN_PROGRESS";
                            BoardListeleme(cards, uyeler);
                            break;
                        case "3":
                            card.Line = "DONE";
                            BoardListeleme(cards, uyeler);
                            break;
                        default:
                            Console.WriteLine("Hatalı bir seçim yaptınız");
                            break;
                    }
                }
            }
        }
    }
}
