using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz");

            string cumle = Console.ReadLine();
            char[] yeniDizi = new char[cumle.Length];
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            
            int count = 0;
            foreach (char item in cumle)
            {
                foreach (char sh in sesliHarfler)
                {
                    if (item == sh)
                    {
                        yeniDizi[count] = item;
                        count++;
                    }
                }
            }
            //Yeni dizinin size'ı count ile güncellendi
            
            //String class'ının Replace metodunu kullanabilmek için yeniDizi(char array) string'e çevrildi.
            
            
            //yeniDizi'deki boşluklar Replace ile güncellenerek silindi
            // result.Replace(" ", "");
            

            
            Array.Sort(yeniDizi, CompareChars);
            Console.WriteLine("Sıralı: " + new String(yeniDizi));
        }
        //Türkçe karakterlerde örn. ı i'den büyük olduğu için sıralama sorun oluyordu. 
        //Bu sebeple Array class'ının Sort metodunu override ederek aşağıdaki sorted array'e göre sıralanması sağlandı.
        public static int CompareChars(char a, char b)
        {
            char[] sorted = "AaEeIıİiOoÖöUuÜü".ToCharArray();
            int aIndex = Array.FindIndex<char>(sorted, 0, sorted.Length, i => i == a);
            int bIndex = Array.FindIndex<char>(sorted, 0, sorted.Length, i => i == b);
            
            return aIndex - bIndex;
        }
    }
}
