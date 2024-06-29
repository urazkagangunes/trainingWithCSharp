using System.Threading.Channels;

namespace Ornek05_DiziDevamveRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ÖRN: 10 ile 50 arasında rastgele 6 sayı üretip ekrana yazalım.
            int[] sayilar = new int[60];

            Random rnd = new Random(); // rnd isimli Random tipli değişkenimiz
            // sınıftan örnek türettik

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(10, 51);
            }

            Array.ForEach(sayilar, s => Console.Write($"{s} \t"));
            Console.WriteLine();


            Console.WriteLine($"sayılar dizisindeki en büyük elaman ={sayilar.Max()}");
            Console.WriteLine($"sayılar dizisindeki en küçük elaman ={sayilar.Min()}");
            Console.WriteLine($"sayılar dizisindeki kaç elemanlı ={sayilar.Count()}");
        }
    }
}
