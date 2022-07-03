namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Structlar sınıflara benzerler. Sınıflar referans türündedir.Referans türler belleğin hype kısmında tutulur.
            Structlar ise değer türündedir. Değer türler belleğin stack kısmında tutulur.
            */
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KısaKenar = 3;
            dikdortgen.UzunKenar = 4;

            Console.WriteLine("Class Alan Hesabı    :{0}", dikdortgen.AlanHesapla());

            Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct();
            //Dikdortgen_Struct dikdortgen_Struct; => bu şekilde de çalıştırabilir.
            dikdortgen_Struct.KısaKenar = 3;
            dikdortgen_Struct.UzunKenar = 4;

            Console.WriteLine("Struct Alan Hesabı    :{0}", dikdortgen_Struct.AlanHesapla());

            Dikdortgen_Struct dikdortgen_Struct1 = new Dikdortgen_Struct(3, 4);
            Console.WriteLine("Struct Alan Hesabı    :{0}", dikdortgen_Struct1.AlanHesapla());
        }
    }

    class Dikdortgen
    {
        public int KısaKenar;
        public int UzunKenar;

        public Dikdortgen() // Constructor overload edilebiliyor classlarda
        {
            KısaKenar = 3;
            UzunKenar = 4;
        }

        public long AlanHesapla()
        {
            return this.KısaKenar * this.UzunKenar;
        }
    }

    struct Dikdortgen_Struct //Structlar initial değerleri atayamaz. O yüzden field'leri atanmadan kullanılamaz.
    {
        public int KısaKenar;
        public int UzunKenar;

        public Dikdortgen_Struct(int kısaKenar, int uzunKenar) // Structlarda constructor bu şekilde tanımlanabilir
        {
            KısaKenar = kısaKenar;
            UzunKenar = uzunKenar;
        }
        public long AlanHesapla()
        {
            return this.KısaKenar * this.UzunKenar;
        }
    }
}
