namespace Ornek24_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //do-while döngüsü while ile aynıdır.
            //sadece dowhile döngüsü şartı başlangıçta değil en sonda kontrol eder.
            //şart yanlış olsa bile 1 kere çalışıyor.
            //henüz ataması yapılmamış olan bir değişken varsa onun atamasının beklenmesi ve sonra şartın kontrol edilmesi

            int i = 10;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 50);

            Console.WriteLine("------");
            int x = 63;
            do
            {
                Console.WriteLine(x);
                x-=3;
            } while (x>=1);

        }
    }
}
