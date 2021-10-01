using System;

namespace C_sharp_ornekleri
{
    class toplama_islemi_konsol
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Merhaba Dunya!");
            int sayi1, sayi2, sonuc;
            Console.WriteLine("Toplama İşlemi Programı");
            Console.Write("1. Sayi : ");
            sayi1=Convert.ToInt16(Console.ReadLine());

            Console.Write("2. Sayi : ");
            sayi2=Convert.ToInt16(Console.ReadLine());

            sonuc=sayi1+sayi2;
            
            Console.Write("{0} + {1} = {2}",sayi1, sayi2, sonuc);
        }
    }
}
