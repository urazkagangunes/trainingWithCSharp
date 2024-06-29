namespace Ornek18_WhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //while --iken
        //şart sağlandığı sürece döner.
        //int sayac = 1;

        //while (sayac < 10) 
        //{
        //    Console.WriteLine("merhaba");
        //    sayac++;
        //}
        //int sayac = 10;

        //while (sayac > 0)
        //{
        //    Console.WriteLine(sayac);
        //    sayac--;
        //}


        //break komutu while döngüsünde nasıl kullanılıyor?

        //While döngüsünde BREAK CONTUNIE kullanılır
        Baslangic:
            Console.Write("Sayı gir :");
            bool sayiKontrol = int.TryParse(Console.ReadLine(), out int sayi);
            if (!sayiKontrol)
            {
                Console.WriteLine("HATA Lütfen geçerli giriş yapınız!!");
                goto Baslangic;
            }

            int sayac = 2;
            bool asalMi = false;
            while (sayac < sayi)
            {
                if (sayi % sayac == 0)
                {
                    asalMi = false;
                    break;
                }
                else
                    asalMi = true;
                sayac++;
            }

            if (asalMi)
                Console.WriteLine("Bu sayı ASALDIR");
            else
                Console.WriteLine("Bu sayı ASAL DeĞİldir!");

            goto Baslangic;


            ////#region ASAL Kontrolu geriye dogru baktık 5 4 3 2 1
            ////int sayac = sayi - 1;
            ////bool asalMi = false;
            ////while (sayac > 1)
            ////{
            ////    if (sayi % sayac == 0)
            ////    {
            ////        asalMi = false;
            ////        break;
            ////    }
            ////    else
            ////        asalMi = true;
            ////    sayac--;
            ////}

            ////#endregion

            if (asalMi)
                Console.WriteLine("Bu sayı ASALDIR");
            else
                Console.WriteLine("Bu sayı ASAL DeĞİldir!");

            goto Baslangic;
        }
    }
}
