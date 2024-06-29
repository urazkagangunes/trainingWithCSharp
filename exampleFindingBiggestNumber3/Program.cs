using System.Runtime.Intrinsics.Arm;

namespace Ornek29_EnBuyukSayiDevam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ÖRN: Girilen 3 sayıdan hangisinin en büyük olduğunu bulalım
            while (true)
            {

                bool kontrol1 = false, kontrol2 = false, kontrol3 = false;
                int s1 = 0, s2 = 0, s3 = 0, enbuyuk = 0;


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

                if (s1 == s2 && s2 == s3)
                {
                    Console.WriteLine("sayılar eşittir!");
                    Console.WriteLine($"en büyük ={s1}");
                    // enbuyuk=s1;
                }
                else
                {
                    // bu kod aşağıdakinden daha iyidir!
                    //enbuyuk = s1 > enbuyuk ? s1 : enbuyuk;
                    //enbuyuk = s2 > enbuyuk ? s2 : enbuyuk;
                    //enbuyuk = s3 > enbuyuk ? s3 : enbuyuk;

                    //kısa kod iyi kod demek değildir!! Çünkü burada daha fazla kontrol yapması gerekti
                    enbuyuk = s1 > s2 && s1 > s3? s1 :
                              s2 > s1 && s2> s3 ? s2 :
                              s3 > enbuyuk ? s3 : enbuyuk;



                    Console.WriteLine($"en büyük ={enbuyuk}");
                }

                ////Eğer sayılar eşittir mesajı gerekli değilse aşağıdakini kullanırız.
                //enbuyuk = s1 > enbuyuk ? s1 : enbuyuk;
                //enbuyuk = s2 > enbuyuk ? s2 : enbuyuk;
                //enbuyuk = s3 > enbuyuk ? s3 : enbuyuk;
                //Console.WriteLine($"en büyük ={enbuyuk}");

            }

        }
    }
}
