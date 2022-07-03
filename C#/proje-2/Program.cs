namespace proje_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> uyeler = new Dictionary<int, string>();
            uyeler.Add(1, "A");
            uyeler.Add(2, "B");
            uyeler.Add(3, "C");
            uyeler.Add(4, "D");
            uyeler.Add(5, "E");
            uyeler.Add(6, "F");
            uyeler.Add(7, "G");

            List<Card> cards = new List<Card>();
            Card card1 = new Card("IN_PROGRESS", "C#", "C# öğrenmek", 2, 2);
            Card card2 = new Card("TODO", "Kitap", "Kitap okumak", 3, 2);
            Card card3 = new Card("DONE", "Odev", "Odev yapmak", 4, 2);

            cards.Add(card1);
            cards.Add(card2);
            cards.Add(card3);

            while (true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");
                Console.WriteLine("(5) Çıkış");

                string islemNumarasi = Console.ReadLine();

                if (islemNumarasi == "5")
                    break;

                switch (islemNumarasi)
                {
                    case "1":
                        Todo.BoardListeleme(cards, uyeler);
                        break;
                    case "2":
                        Todo.BoardaKartEkleme(cards, uyeler);
                        break;
                    case "3":
                        Todo.BoardKartSilme(cards);
                        break;
                    case "4":
                        Todo.KartTasimak(cards, uyeler);
                        break;
                    default:
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        break;
                }
            }

        }
    }

}