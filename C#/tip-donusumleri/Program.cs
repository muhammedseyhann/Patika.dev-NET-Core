namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("********************** Implicit Conversion **********************");
            
            byte a=3;
            sbyte b=35;
            short c = 10;

            int d= a+b+c;
            Console.WriteLine(d);

            long h = d;
            Console.WriteLine(d);
            
            float i = h;
            Console.WriteLine(i);

            string e = "Muhammed";
            char f = 'k';
            object g = e+f+d;
            Console.WriteLine(g);
            
            //Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("********************** Explicit Conversion **********************");
            
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: {0}",y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: {0}",t);

            float w = 10.6f;
            byte v = (byte)w;
            Console.WriteLine("v: {0}",v);

            // ******************* To String *******************
            Console.WriteLine("******************* To String *******************");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: {0}",yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: {0}",zz);

            // ******************* System.Convert sınıfı *******************
            Console.WriteLine("******************* System.Convert sınıfı *******************");
            string s1 = "10", s2="20";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: "+ Toplam);
            
            // ******************* Parse *******************
            Console.WriteLine("******************* Parse *******************");
            ParseMethod();

        }
        public static void ParseMethod() 
        {
            string metin1 = "10";
            string metin2 = "10.25";

            int rakam1 = 10;
            double double1 = 10.25;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("rakam1 :", rakam1);
            Console.WriteLine("double1 :", double1);
        }
    }
}