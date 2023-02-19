using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Toplama işlemi
            Console.WriteLine("Toplama işleminin sonucu: " + Toplama(3, 5));
            Console.WriteLine("Çıkarma işleminin sonucu: " + Cikarma(3, 5));
            Console.WriteLine("Çarpma işleminin sonucu: " + Carpma(3, 5));
            Console.WriteLine("Bölme işleminin sonucu: " + Bolme(3, 5));


        }

        //Toplama işlemi
        static int Toplama(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        //Çıkarma işlemi
        static int Cikarma(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        //Çarpma işlemi
        static int Carpma(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        //Bölme işlemi (float)
        static float Bolme(float sayi1, float sayi2)
        {
            return sayi1 / sayi2;
        }

    }
}
