namespace Degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b = 5; //0-255 | 1 Byte
            sbyte c = 5; //-128 - 127 | 1 Byte

            short s = 5; // 16 bit - 2 Byte yer kaplar
            ushort us = 5;// 2 Byte | 0'dan küçük değer alamıyor

            Int16 i16 = 2; // 2Byte
            int i = 2; // 4 Byte
            Int32 i32 = 2; // 4 Byte 
            Int64 i64= 2;// 8 byte

            uint ui = 2; //4 Byte
            long l = 4; //8 byte
            ulong ul = 4; //8 byte

            // Reel sayılar
            float f = 5; //4 Byte 
            double d = 5; //8 byte
            decimal de = 5; // 16 byte

            char ch = '2'; // 2 byte
            string str = "Hello"; //sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now; //Çalıştırıldığı anın zamanını döndürür
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;
            
            // string ifadeler

            string str1 = string.Empty;
            str1 = "Hello World";
            string ad = "Muhammed";
            string soyad = "Seyhan";
            string tamIsim = ad + " " + soyad;

            //integer tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            //boolean

            bool bool1 = 10 > 2;


            // Değişken Dönüşümleri
            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger); //Çıktısı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); //Çıktısı 40

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22); //çıktısı 40

            //dateTime

            string dateTime1 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime1);

            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}