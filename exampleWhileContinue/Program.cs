namespace Ornek19_While_Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {

        ////continue komutu döngüyü kırmaz. Döngüde işlem yaptığınız yerden sizi sıçratır atlatır (döngünün başına)
        //// Değeri atlatır

        //for (int i = 1; i < 10; i++)
        //{
        //    if (i % 2 == 0)
        //        continue; // devam et  ATLA GEÇ  Continue komutu gördüğü yerde döngüde aşağıdaki satırlara inmez 

        //    Console.WriteLine(i);
        //}

        //While döngüsünde CONTUNIE kullanılır
        Baslangic:
            Console.Write("Sayı gir :");
            bool sayiKontrol = int.TryParse(Console.ReadLine(), out int sayi);
            if (!sayiKontrol)
            {
                Console.WriteLine("HATA Lütfen geçerli giriş yapınız!!");
                goto Baslangic;
            }

            int sayac = 2;
            bool asalMi = true;
            while (sayac < sayi)
            {
                if (sayi % sayac == 0)
                {
                    sayac++;
                    asalMi = false;
                    continue;
                }
               
                sayac++;
            }

            if (asalMi)
                Console.WriteLine("Bu sayı ASALDIR");
            else
                Console.WriteLine("Bu sayı ASAL DeĞİldir!");

            goto Baslangic;







        }
    }
}
