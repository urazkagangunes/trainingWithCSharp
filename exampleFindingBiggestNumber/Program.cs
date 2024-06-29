namespace Ornek27_EnBuyukSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ÖRN: Girilen 3 sayıdan hangisinin en büyük olduğunu bulalım
            while (true)
            {

                bool kontrol1 = false, kontrol2 = false, kontrol3 = false;
                int s1 = 0, s2 = 0, s3 = 0;

                #region Sayi1Iste 
                while (!kontrol1)
                {
                    Console.ResetColor();
                    Console.WriteLine("1. sayi giriniz  :");
                    kontrol1 = int.TryParse(Console.ReadLine(), out s1);
                    if (!kontrol1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("HATALI GİRİŞ!");
                    }
                }
                #endregion

                #region Sayi2Iste 
                while (!kontrol2)
                {
                    Console.ResetColor();
                    Console.WriteLine("2. sayi giriniz  :");
                    kontrol2 = int.TryParse(Console.ReadLine(), out s2);
                    if (!kontrol2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("HATALI GİRİŞ!");
                    }
                }
                #endregion

                #region Sayi3Iste 
                while (!kontrol3)
                {
                    Console.ResetColor();
                    Console.WriteLine("3. sayi giriniz  :");
                    kontrol3 = int.TryParse(Console.ReadLine(), out s3);
                    if (!kontrol3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("HATALI GİRİŞ!");
                    }
                }
                #endregion

                //hepsi eşit mi?
                if (s1 == s2 && s2 == s3)
                {
                    Console.WriteLine($"Tüm sayıları eşit girdiniz en büyük sayı {s1}");
                }

                //en büyük sayı s1 olabilir
                else if (s1 > s2 && s1 > s3)
                {
                    Console.WriteLine($" en büyük sayı {s1}");

                }
                //en büyük sayı s2 olabilir
                else if (s2 > s1 && s2 > s3)
                {
                    Console.WriteLine($" en büyük sayı {s2}");

                }
                else            //en büyük sayı s3 olabilir

                {
                    Console.WriteLine($" en büyük sayı {s3}");

                }

            }
        }
    }
}
