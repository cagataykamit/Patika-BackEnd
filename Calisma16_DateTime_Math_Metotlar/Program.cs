using System;

namespace Calisma16_DateTime_Math_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); // günün tarihini getirir.
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            Console.WriteLine(DateTime.Now.ToString("dd"));   //07
            Console.WriteLine(DateTime.Now.ToString("ddd"));  //pzt
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Pazartesi

            Console.WriteLine(DateTime.Now.ToString("MM"));   //02
            Console.WriteLine(DateTime.Now.ToString("MMM"));  //Şub
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //Şubat

            Console.WriteLine(DateTime.Now.ToString("yy"));   //22
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2022

            //Math Kütüphanesi

            Console.WriteLine(Math.Abs(-25)); //Mutlak Değer
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));


            Console.WriteLine(Math.Ceiling(22.3)); //Her zaman yukarıya yuvarlar
            Console.WriteLine(Math.Round(22.5));   //0.5 ve altı bir aşağıdaki sayıya - 0.5 üzeri bir yukarı yuvarlar
            Console.WriteLine(Math.Floor(22.7));   // her zaman aşağıya yuvarlar

            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));

            Console.WriteLine(Math.Pow(3,4));   // 3^4 ü verir
            Console.WriteLine(Math.Sqrt(9));    // karekökü alır
            Console.WriteLine(Math.Log(9));     // 9 un e tabanındaki logaritmk karşılığını verir
            Console.WriteLine(Math.Exp(3));     // e üzeri 3 ü verir
            Console.WriteLine(Math.Log10(10));  // 10 sayısının logaritma 10 tabanındaki karşılığı

            



            


        }
    }
}
