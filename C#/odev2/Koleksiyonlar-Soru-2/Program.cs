using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;

            int[] sayilar = new int[20];

            while (index < 20)
            {
                try
                {
                    Console.WriteLine("{0}. sayıyı giriniz.", index + 1);
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    sayilar[index] = sayi;
                    index++;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Bir sayı giriniz.");
                }

            }
            int[] minValues = getMin3Values(sayilar);
            int[] maxValues = getMax3Values(sayilar);

            double meanMinValues = minValues.Average();
            int minSum = minValues.Sum();

            double meanMaxValues = maxValues.Average();
            int maxSum = maxValues.Sum();

            Console.WriteLine("En küçük üç sayının toplamları: {0}, ortalamaları: {1}", minSum, meanMinValues);
            Console.WriteLine("En büyük üç sayının toplamları: {0}, ortalamaları: {1}", maxSum, meanMaxValues);

        }

        static int[] getMin3Values(int[] dizi)
        {
            int count = 0;
            int[] minValues = new int[3];

            while (count < 3)
            {
                int minValue = dizi.Min();
                minValues[count] = minValue;
                int[] newArray = dizi.Where(item => item != minValue).ToArray();
                dizi = newArray;
                count++;
            }

            return minValues;
        }

        static int[] getMax3Values(int[] dizi)
        {
            int count = 0;
            int[] maxValues = new int[3];

            while (count < 3)
            {
                int maxValue = dizi.Max();
                maxValues[count] = maxValue;
                int[] newArray = dizi.Where(item => item != maxValue).ToArray();
                dizi = newArray;
                count++;
            }

            return maxValues;
        }
    }
}