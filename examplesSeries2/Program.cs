namespace Ornek02_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dizinin elemanlarını ekrana yazdıralım.

            int[] sayilar = new int[5] { 100, 200, 300, 400, 500 };

            //1. yol
            Console.WriteLine("Sayılar dizisinin elamanları");
            //Console.WriteLine(sayilar[0]);
            //Console.WriteLine(sayilar[1]);
            //Console.WriteLine(sayilar[2]);
            //Console.WriteLine(sayilar[3]);
            //Console.WriteLine(sayilar[4]);

            //2. yol ve olması gereken işlem
            //döngü kurarak yazdıralım
            for (int i = 0; i < sayilar.Length; i++) 
            {
                Console.WriteLine(sayilar[i]);
            }


            Array.Resize(ref sayilar, 12);
            Console.WriteLine("Sayılar dizisinin elaman sayısı 12 olarak yenilendi");
            Console.WriteLine("Sayılar dizisinin elamanları");

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }


            Array.Resize(ref sayilar, 3);
            Console.WriteLine("Sayılar dizisinin elaman sayısı 3 olarak yenilendi");
            Console.WriteLine("Sayılar dizisinin elamanları");

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            //Foreach döngüsü ile dizinin elemanlarını yazdırmak
            Console.WriteLine("Sayılar dizisini foreach döngüsünü kullanarak yazdıralım");
            Console.WriteLine("Sayılar dizisinin elamanları");

            foreach (int sayi in sayilar) 
            {
                Console.WriteLine(sayi);

            }

        }
    }
}
