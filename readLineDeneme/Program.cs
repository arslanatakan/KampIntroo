using System;

namespace readLineDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi;
            Console.WriteLine("Bir sayı giriniz: ");
            sayi = Console.ReadLine();
            if (sayi>0)
            {
                Console.WriteLine(sayi +"Pozitif bir sayıdır.");
            }
        }
    }
}
