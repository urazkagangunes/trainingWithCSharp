namespace Ornek28_EnBuyukSayiDevam
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

                //s1 en büyük 
                bool enbuyukS1Mi = s1 > s2 && s1 > s3;
                // s2 en büyük
                bool enbuyukS2Mi = s2 > s1 && s2 > s3;
                // s3 en büyük
                bool enbuyukS3Mu = s3 > s1 && s3 > s2;

                //if (enbuyukS1Mi)
                //    Console.WriteLine($" en büyük sayı {s1}");
                //else if (enbuyukS2Mi)
                //    Console.WriteLine($" en büyük sayı {s2}");
                //else if (enbuyukS3Mu)
                //    Console.WriteLine($" en büyük sayı {s3}");
                //else
                //    Console.WriteLine($" sayılar eşit");

                //

                if (s1 == s2 && s2 == s3)
                    Console.WriteLine($" sayılar eşit");
                else if (enbuyukS1Mi)
                    Console.WriteLine($" en büyük sayı {s1}");
                else if (enbuyukS2Mi)
                    Console.WriteLine($" en büyük sayı {s2}");
                else
                    Console.WriteLine($" en büyük sayı {s3}");





            }
        }
    }
}
