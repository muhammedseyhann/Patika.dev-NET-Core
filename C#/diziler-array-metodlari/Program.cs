﻿namespace diziler_array_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort
            int[] sayiDizisi = {23, 12, 4, 86, 72, 3, 11, 17};

            Console.WriteLine("***** Sırasız Dizi *****");
            foreach (var sayi in sayiDizisi) 
                Console.WriteLine(sayi);
            
            Console.WriteLine("**** Sıralı Dizi ******");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi) 
                Console.WriteLine(sayi);
            
            // Clear - Belirtilen index numarasından başlayıp girilen sayı kadar elemanın değerini 0'a çevirir
            Console.WriteLine("**** Array Clear ******");
            Array.Clear(sayiDizisi,2,2);
            foreach (var sayi in sayiDizisi) 
                Console.WriteLine(sayi);
            
            // Reverse
            Console.WriteLine("**** Array Reverse ******");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi) 
                Console.WriteLine(sayi);
            
            //IndexOf
            Console.WriteLine("**** Array Indexof ******");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            // Resize
            Console.WriteLine("**** Array Resize ******");
            Array.Resize<int>( ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi) 
                Console.WriteLine(sayi);
        }
    }
}