using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 36;

            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "Java";
            kurs1.Egitmen = "Kerem Varış";
            kurs1.IzlenmeOranı = 64;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Pyhton";
            kurs2.Egitmen = "Berkay Bilgin";
            kurs2.IzlenmeOranı = 80;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C#";
            kurs3.Egitmen = "Engin Demiroğ";
            kurs3.IzlenmeOranı = 68;


            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.IzlenmeOranı = 100;


            //Console.WriteLine(kurs1.KursAdi+" : "+ kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }


        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOranı { get; set; }
    }
}
