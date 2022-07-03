namespace hazır_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz Csharp, Hoşgeldiniz!";
            string degisken2 = "dersimiz Csharp";


            // Length
            Console.WriteLine(degisken.Length);

            //toUpper, toLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(String.Concat(degisken, " Merhaba!"));

            //Compare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2));//Eşit ise 0, 1.string 2.stringden daha fazla karaktere sahip ise 1, değilse -1 döndürür.
            Console.WriteLine(String.Compare(degisken, degisken2, true));
            Console.WriteLine(String.Compare(degisken, degisken2, false));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CSharp"));//Bulamazsa -1 döndürür.
            Console.WriteLine(degisken.IndexOf("."));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba! "));

            //PadLeft, Padright
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));

            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(10));//10. karakterden sonrasını siler.
            Console.WriteLine(degisken.Remove(5, 3));//5.karakterden sonra 3 karakter siler.
            Console.WriteLine(degisken.Remove(0, 1));//Sadece ilk karakteri sildi.

            //Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));//4.indexten başlayarak geri kalan tüm karakterleri getirir.
            Console.WriteLine(degisken.Substring(4, 6));//4.indexten sonraki 6 karakteri getirir.

        }
    }
}