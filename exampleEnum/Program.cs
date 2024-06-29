using System.ComponentModel.Design;

namespace Ornek10_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Enum örneğidir
        //Enumlar namespace içinde tanımlanır class içinde DEĞİL!!!

        //ÖRN: kullanıcıdan 2 sayı alınız. Seçtiği işlem türüne göre sonucu hesaplayınız
        Baslangic:
            int s1, s2, islemtur;

        sayi1Al:
            Console.ResetColor();
            Console.WriteLine("Sayı Gir:");
            bool sayi1Kontrol = int.TryParse(Console.ReadLine(), out s1);

        sayi2Al:
            Console.ResetColor();
            Console.WriteLine("Sayı Gir:");
            bool sayi2Kontrol = int.TryParse(Console.ReadLine(), out s2);

            if (!sayi1Kontrol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("HATA! Lütfen 1. sayıyı düzgün giriniz!");
                goto sayi1Al;
            }

            if (!sayi2Kontrol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("HATA! Lütfen 1. sayıyı düzgün giriniz!");
                goto sayi2Al;
            }


        #region Islem Bolumu
        IslemturuAl:
            Console.ResetColor();
            Console.WriteLine("Hangi işlemi yapmak istediğinizi seçiniz!!");
            Console.WriteLine("Toplama ---> 1");
            Console.WriteLine("Çıkarma ---> 2");
            Console.WriteLine("Çarpma  ---> 3");
            Console.WriteLine("Bölme   ---> 4");

            bool islemKontrol = int.TryParse(Console.ReadLine(), out islemtur);

            if (!islemKontrol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("HATA! Lütfen geçerli bir işlem seçiniz!");
                goto IslemturuAl;
            }

            if ((IslemTuru)islemtur == IslemTuru.Toplama)
            {
                Console.WriteLine($"Sonuç= {s1 + s2}");
            }
            else if (islemtur == (int)IslemTuru.Cikarma)
            {
                Console.WriteLine($"Sonuç= {s1 - s2}");

            }
            else if (islemtur == (int)IslemTuru.Bolme)
            {
                //s2 sıfır olmamalı!
                if (s2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("HATA! Sıfıra bölme işlemi yapılama!");
                }
                else
                    Console.WriteLine($"Sonuç= {s1 / s2}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("HATA! Lütfen geçerli bir işlem sayısı giriniz!!");
                goto IslemturuAl;
            }
            #endregion
            goto Baslangic;
        }
    }

    public enum Cinsiyet : byte
    {
        Kadin = 255,
        Erkek = 1,
        Belirsiz = 3
        //sayı vermek zorundayız
        //sıralı sayı değil farklı sırada sayı verilebilir
        //integer'ın sınırlarına göre sayı verebilirsiniz
    }

    public enum Ehliyet
    {
        A,
        B,
        C, D, E
        //herhangi bir sayı vermeden de tanımlanabilir. Fakat kendisi sayıları atar.
    }

    public enum IslemTuru
    {
        Toplama = 1,
        Cikarma = 2,
        Carpma = 3,
        Bolme = 4,
        ModAl = 5
    }

}
