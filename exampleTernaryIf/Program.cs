namespace Ornek26_TernaryIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ternary if: tek satırda sorgulama yapmamızı sağlıyor.

            int sayi = 10;
            //bu sayı çift mi tek mi bakalım
            if (sayi % 2 == 0)
                Console.WriteLine("Çift");
            else
                Console.WriteLine("tek");

            //  değişken=  condition ? şart sağlanıyorsa hangi değeri alacak : şart sağlanmıyorsa hangi değeri alacak
            string durum = sayi % 2 == 0 ? "Çift" : "tek";

            Console.WriteLine("Hangi kampanya istersiniz ? A / B ");
            ConsoleKeyInfo kampanya = Console.ReadKey();

            double faizOrani = kampanya.Key == ConsoleKey.A ? 0.05 : 0;

            faizOrani = kampanya.Key == ConsoleKey.B ? 0.03 : 0;

            bool kontrol = false;
             faizOrani = kampanya.Key == ConsoleKey.A  && DateTime.Now.Year==2024 && kontrol ? 0.05 : 0;

            //içe içe kullanım

            faizOrani = kampanya.Key == ConsoleKey.A ?
                0.05 :
                kampanya.Key == ConsoleKey.B ? 
                0.03 : 0;


            faizOrani = kampanya.Key == ConsoleKey.A ?
              0.05 :
              kampanya.Key == ConsoleKey.B ?
              0.03 : 
              kampanya.Key==ConsoleKey.G? 0.08 :0;

        }
    }
}
