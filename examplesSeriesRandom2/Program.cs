namespace Ornek06_DizilerRandomDevam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ÖRN: 1 ile 100 arasında rastgele 20 farklı sayı üretip ekrana yazalım.
            int[] sayilar = new int[20];

            Random rnd = new Random(); // rnd isimli Random tipli değişkenimiz
            // sınıftan örnek türettik

            for (int i = 0; i < sayilar.Length; i++)
            {
                //ürettiğin sayıdan dizide yoksa o sayıyı diziye ekle
                int uretilensayi = rnd.Next(0, 101);
                //1. yol contains ile yapabiliriz
                //if (!sayilar.Contains(uretilensayi))
                //{
                //    sayilar[i] = uretilensayi;
                //}
                //else
                //    i--;

                //2. yol indexof ile yapabiliriz
                if (Array.IndexOf(sayilar, uretilensayi) ==-1)
                {
                    sayilar[i] = uretilensayi;
                }
                else
                    i--;
            }

            // Array.ForEach(sayilar, s => Console.WriteLine($"{s}"));
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine($"{i+1}. sayı = {sayilar[i]}");
            }
            Console.WriteLine();


            Console.WriteLine($"sayılar dizisindeki en büyük elaman ={sayilar.Max()}");
            Console.WriteLine($"sayılar dizisindeki en küçük elaman ={sayilar.Min()}");
            Console.WriteLine($"sayılar dizisindeki kaç elemanlı ={sayilar.Count()}");
        }

    }
}
