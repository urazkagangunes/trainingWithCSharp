namespace Ornek17_For_BreakveContinueKomutu
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //ÖRN: Kullanıcıdan sayı alalım ve asal olup olmadığına bakalım
        Baslangic:
            Console.Write("Sayı gir :");
            bool sayiKontrol = int.TryParse(Console.ReadLine(), out int sayi);
            if (!sayiKontrol)
            {
                Console.WriteLine("HATA Lütfen geçerli giriş yapınız!!");
                goto Baslangic;
            }

            // 7--->> 6 5 4 3 2
            // 14 ---> 13 12 11 10 9 8 7 6 5 4 3 2
            //18 ----> 2 
            bool asalMi = false;
            for (int i = 2; i < sayi; i++)
            {
                //EĞER sayının i'ye bölümünden kalan SIFIR oluyorsa DÖNGÜYÜ KIRALIM
                //Çünkü asal olma kuralını bozuyor
                //BREAK komutu ile döngüyü kıracağız
                if (sayi % i == 0)
                    break;
                else
                    asalMi = true;

            }

            if (asalMi)
                Console.WriteLine("Bu sayı ASALDIR");
            else
                Console.WriteLine("Bu sayı ASAL DeĞİldir!");

            goto Baslangic;

        }
    }
}
