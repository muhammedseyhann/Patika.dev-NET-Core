namespace proje_2
{
    class Card
    {
        private string line;
        private string baslik;
        private string icerik;
        private int kisi;
        private int buyukluk;

        public string Line { get => line; set => line = value; }
        public string Baslik { get => baslik; set => baslik = value; }
        public string Icerik { get => icerik; set => icerik = value; }
        public int Kisi { get => kisi; set => kisi = value; }
        public int Buyukluk { get => buyukluk; set => buyukluk = value; }

        public Card(string line, string baslik, string icerik, int kisi, int buyukluk)
        {
            this.line = line;
            this.baslik = baslik;
            this.icerik = icerik;
            this.kisi = kisi;
            this.buyukluk = buyukluk;
        }

        public Card() { }
    }

    enum Buyuklukler
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
}