using System;

namespace Calisma2
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger = 2;
            string degisken = null;
            string Degisken = null;
            string degisken_veri=null;
            if(degisken == " ");
            byte b= 5;
            sbyte c= 5;
            short s = 5;
            ushort us= 2;
            Int16 i16 = 2;
            int i =2;
            Int32 i32= 2;
            Int64 i64 =2;
            uint ui=2;
            long l =4;
            ulong ul = 4;
            float f = 5;
            double d = 5;
            decimal de=5;
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
        

            object o1="x";
            object o2='y';
            object o3= 2;
            object o4= 2.5;


            string str1 = string.Empty;
            str1 = "Cagatay Kamit";
            string ad ="Cagatay";
            string soyad = "Kamit";
            string tamad = ad + " " + soyad ;

            int i1 = 5;
            int i2 = 3;
            int i3 = i1*i2;


            bool bool1 = 10>2;


            string str20 = "20";
            int i20 = 20 ;
            string yenideger  = str20 + i20.ToString();

            Console.WriteLine(yenideger);
            
            int int21 = i20 + Convert.ToInt32(str20);
            System.Console.WriteLine(int21);

            int int22 = i20 + int.Parse(str20);

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);


            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);



            
        }
    }
}
