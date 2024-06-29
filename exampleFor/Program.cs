namespace Ornek15_ForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for (initializer; condition; iterator) SYNTAX
            //for (başlangıç değeri ; koşul ; artış/azalış miktarı)
            //ÖRN: 1den 20ye kadar olan sayıları yazdıralım

            //Console.WriteLine("1-20 arasındaki sayılar");
            //for (int sayac = 1; sayac < 21; sayac += 1)
            //{
            //    Console.WriteLine( sayac);
            //}
            //Console.WriteLine("1-20 arasındaki tek sayılar");

            //for (int sayac = 1; sayac < 21; sayac += 3)
            //{
            //    Console.WriteLine(sayac);
            //}
            //Console.WriteLine("20den başlayarak geriye doğru çift sayılar");

            //for (int sayac = 20; sayac >=2; sayac -= 2)
            //{
            //    Console.WriteLine(sayac);
            //}

            //ÖRN: 1den 20ye kadar olan sayıları yazdıralım
            for (int i = 0; i <=20; i++) //i = i +1 i=i-1 i--
            {
                Console.WriteLine(i);

            }
        }
    }
}
