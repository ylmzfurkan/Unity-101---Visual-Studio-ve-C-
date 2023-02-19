﻿using System;

namespace ZarOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            TavlaZari tavlaZari1 = new TavlaZari(8);
            Console.WriteLine("Zar 1: " + tavlaZari1.ZarAt());

            TavlaZari tavlaZari2 = new TavlaZari(8);
            Console.WriteLine("Zar 2: " + tavlaZari2.ZarAt());

            if (tavlaZari1.ZarAt() > tavlaZari2.ZarAt())
            {
                Console.WriteLine("Zar 1 kazandı!");
            }
            else if (tavlaZari1.ZarAt() < tavlaZari2.ZarAt())
            {
                Console.WriteLine("Zar 2 kazandı!");
            }
            else
            {
                Console.WriteLine("Berabere!");
            }

            Console.ReadLine();
        }
    }
}
