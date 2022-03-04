using System;

namespace KampIntroo
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği 
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");//simüle ediyoruz.
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);

        }
    }
}
