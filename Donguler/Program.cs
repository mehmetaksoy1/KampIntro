﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "phython";
            string kurs5 = "C++";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya başlangıç için temel kurs", "Java","phyton"};


            for (int i = 0; i < kurslar.Length; i++)
            {

                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar) //kursları tek tek dolaş demek
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
