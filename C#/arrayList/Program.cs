using System.Collections;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace

            ArrayList liste = new ArrayList();
            // liste.Add("Ayşe");
            // liste.Add(2);
            // liste.Add(true);
            // liste.Add('A');

            //İçerisindeki verilere erişme
            // Console.WriteLine(liste[1]);
            // foreach (var item in liste)
            //     Console.WriteLine(item);

            //AddRange
            Console.WriteLine("****** AddRange ********");
            // string[] renkler = { "kırmızı", "sarı", "yesil" };
            // liste.AddRange(renkler);

            List<int> sayilar = new List<int>() { 1, 3, 7, 9, 92, 5 };
            liste.AddRange(sayilar);
            foreach (var item in liste)
                Console.WriteLine(item);

            //Sort -> Sıralamak için int arar.
            Console.WriteLine("****** Sort ********");
            liste.Sort();

            foreach (var item in liste)
                Console.WriteLine(item);

            //Binary Search
            Console.WriteLine("****** Binary Search ********");
            Console.WriteLine(liste.BinarySearch(9));//9'un indeksini getirir.

            //Reverse
            Console.WriteLine("****** Reverse ********");
            liste.Reverse();
            foreach (var item in liste)
                Console.WriteLine(item);

            //Clear
            Console.WriteLine("****** Clear ********");
            liste.Clear();
            foreach (var item in liste)
                Console.WriteLine(item);


        }
    }
}