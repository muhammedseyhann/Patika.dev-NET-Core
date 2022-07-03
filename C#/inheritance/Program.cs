namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kalıtım => Bir üst sınıfın alt sınıfa miras vermesi anlamına geliyor. Alt sınıf, üst sınıftaki bazı özellikleri kullanabilmesidir.
            // SınıfAdi: Public olan üst sınıfın adı şeklinde yazılıyor => class Bitkiler: Canlılar
            // Polymorphism için değiştirlecek metoda virtual yazılır, alt sınıflara override yazılır. =>
            // Kalıtımın yapılması engellenecek ise class'ın önüne sealed yazılır.
            //                          Canlılar
            //                            |
            //          Bitkiler                    Hayvanlar
            //       |           |               |                |
            //   Tohumlu    Tohumsuz        Sürüngenler        Kuşlar

            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("*********************");

            Kuslar martı = new Kuslar();
            martı.Ucmak();
        }
    }
}