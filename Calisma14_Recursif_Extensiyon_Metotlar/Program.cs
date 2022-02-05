using System;
using System.Linq;

namespace Calisma14_Recursif_Extensiyon_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif-Özyinelemeli
            //3^4 =3*3*3*3 

            int result =1;
            for(int i=1;i<5;i++)
            {
                result =result*3;
            }
            Console.WriteLine(result);
            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));

            //Extension Metotlar
            string ifade = "Çağatay Kamit";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if(sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
                Console.WriteLine(ifade.MakeUpperCase());
                Console.WriteLine(ifade.MakeLowerCase());
            }

                int[] dizi = {1,9,3,4,5,7,2,0,6,8};
                dizi.SortArray();
                dizi.EkranaYazdir();
            
            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber());

            string kelime = "Cagatay";
            Console.WriteLine(kelime.GetFirstCharacter());

        }
    }
    public class Islemler
    {
       public int Expo(int sayi,int üs)
       {
           if(üs<2)
           return sayi;
           return Expo(sayi,üs-1)*sayi;
       }  
    }

    public static class Extension {

        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi =param.Split(" ");
            return string.Join("",dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param ){
        foreach (var item in param)
        {
        Console.WriteLine(item);
        }
        } 
        public static bool IsEvenNumber(this int param)
        {
            return param%2==0;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }

    
}
