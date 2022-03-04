using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";
            /*9-10-11. satırlarda bir ürünü aslında tanımlamıştık ancak bir çatı altında ifade edemiyorduk. Programın başka bir noktasından
             istediğimiz zaman nasıl çağırabiliriz ki? İşte tam da bu noktada class kavramı içerisinde depolarsak elmayı bir nesne imiş gibi 
            tutup kulağından tek hamlede çağırabiliriz. Bir manav web mağazasında meyveleri tek çatı altında sıralamamız gerektiğinde tıpkı 
            elmaya uyguladığımız işlemleri armuta-çileğe vb. uygularız ardından bunları bir dizi (array) yapısında depolarız ki gerektiğinde foreach 
            gibi bir döngü vasıtasıyla tek hamlede hepsini çağırıp listeleyebilelim. ***************************Ö N E M L İ*************************
             */

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 }; //Normalde projelerde urun1,urun2 şeklinde belirttiğimiz kısımlar bir veri kaynağından gelir.

            //type-safe -- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------");
            }


            Console.WriteLine("---------------------------Metotlar------------------------");

            //instance - örnek
            //encapsulation - kapsülleme
            //encapsulation: Ayrı ayrı ve düzensiz olacak bir yapıyı bir kalıba sokup her yerden erişme sistemidir.

            SepetManager sepetManager = new SepetManager(); //Classtan bir örnek oluşturulur ardından çağırılır.
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,8);

            








        }
    }
}


//Dont repeat yourself - DRY - Clean Code - Best Practice - C#veJAVA gibi programlama dillerinde her şey classlardan oluşur.
