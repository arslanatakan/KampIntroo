﻿using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30;

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ?? 999;

            // int-decimal-float-double-bool ==> DEĞER TİP
            // array-class-interface ==> REFERANS TİP
            //      BELLEKTE stack ve heap adında iki alan vardır;
            //      değer tip olanlar STACK'te gerçekleşir.
            //  int[] sayilar1 dendiğinde stackte bir değişken tanımladık sonra..
            //  int[] sayilar1 = new int[] {1,2,3}; yaparken NEW dendiğinde gider HEAP'te bir yer açar.

        }
    }
}
