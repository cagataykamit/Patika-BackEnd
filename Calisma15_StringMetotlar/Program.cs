using System;

namespace Calisma15_StringMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken ="Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "CSharp";

            //length
            Console.WriteLine(degisken.Length);

            //ToUpper , ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(String.Concat(degisken," Merhaba"));

            //Compare, CompareTo

            Console.WriteLine(degisken.CompareTo(degisken2)); //0,1,-1
            Console.WriteLine(String.Compare(degisken,degisken2,true));
            Console.WriteLine(String.Compare(degisken,degisken2,false));


            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Cagatay"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba! "));

            //PadLeft, PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2.PadLeft(30));

            //Remove
            Console.WriteLine(degisken.Remove(10)); //10. indexten baslayarak sonuna kadar siler
            Console.WriteLine(degisken.Remove(5,3));//5. indexten başlayarak 3 karakter sil
            Console.WriteLine(degisken.Remove(0,1));//İlk karakteri silmek için

            //Replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4)); //4.indexten başla sonuna kadar getir
            Console.WriteLine(degisken.Substring(4,6)); //4.indexten başla 6 karakter getir
        }
    }
}
