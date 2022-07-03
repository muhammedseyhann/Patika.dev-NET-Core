namespace hazir_metotlar_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);//Günün tarihini getirir.
            Console.WriteLine(DateTime.Now.Date);//Gün ay ve yıl şeklinde getiriyor
            Console.WriteLine(DateTime.Now.Day);//Günü getirir.
            Console.WriteLine(DateTime.Now.Month);//Ayı getirir
            Console.WriteLine(DateTime.Now.Year);//Yılı getirir.
            Console.WriteLine(DateTime.Now.Hour);//Saati getirir.
            Console.WriteLine(DateTime.Now.Minute);//Dakikayı getirir.
            Console.WriteLine(DateTime.Now.Second);//Saniyeyi getirir.

            Console.WriteLine(DateTime.Now.DayOfWeek);//Haftanın gününü string şeklinde getirir.
            Console.WriteLine(DateTime.Now.DayOfYear);//Yılın kaçıncı gününde olduğunu getiriyor.

            Console.WriteLine(DateTime.Now.ToLongDateString());// Gün - Ay ismi - Yıl - Haftanın Günü 
            Console.WriteLine(DateTime.Now.ToShortDateString());// dd.mm.yyyy

            Console.WriteLine(DateTime.Now.ToLongTimeString());// hh:mm:ss
            Console.WriteLine(DateTime.Now.ToShortTimeString());// hh:mm

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            // Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));//24
            Console.WriteLine(DateTime.Now.ToString("ddd"));//Sat
            Console.WriteLine(DateTime.Now.ToString("dddd"));//Saturday

            Console.WriteLine(DateTime.Now.ToString("MM"));//04
            Console.WriteLine(DateTime.Now.ToString("MMM"));//Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//April

            Console.WriteLine(DateTime.Now.ToString("yy"));//21
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//2021

            //Math Kütüphanesi
            Console.WriteLine("******** Math Kütüphanesi ********");
            Console.WriteLine(Math.Abs(-25));
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(22.3));// 23 Yukarı yuvarlama
            Console.WriteLine(Math.Round(22.3));//Yuvarlama
            Console.WriteLine(Math.Floor(22.7));//22 Aşağı Yuvarlama

            Console.WriteLine(Math.Max(2, 6));
            Console.WriteLine(Math.Min(2, 6));

            Console.WriteLine(Math.Pow(3, 4)); // 3^4 = 81
            Console.WriteLine(Math.Sqrt(9)); // Karekök alır.
            Console.WriteLine(Math.Log(9)); // 9'un e tabanındaki logaritmik karşılığını getirir.
            Console.WriteLine(Math.Exp(3)); //e^3 'ü verir.
            Console.WriteLine(Math.Log10(10));// 10 sayısının logaritmA 10 tabanındaki karşılığı


        }
    }
}