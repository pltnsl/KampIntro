using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme Kampı";
            string kurs2 = "Programlamaya Giriş Kursu";
            string kurs3 = "Java";
            string kurs4 = "Pyhton";
            string kurs5 = "C++";


            string[] kurslar = new string[] { "Yazılım Geliştirme Kampı", "Programlamaya Giriş Kursu", "Java", "C++" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer ");
        }
    }
}
