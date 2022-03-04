using System;

namespace Dongulerr
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            //array-dizi çoklu verilerimizi tutmak istiyoruz.

            string[] kurslar = new string[] {kurs1,
                "Programlamaya Başlangıç İçin Temel Kurs", 
                "Java","Python" };



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("sayfa sonu - footer");

            foreach (string kurs in kurslar) //Dizi yapılarını foreach ile de dolaşabiliriz. 
            {
                Console.WriteLine(kurs);
            }
            //Classlara geçilen yerde kaldım.  28.02.2022


        }
    }
}
