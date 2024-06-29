namespace Ornek30_EnbuyukSayiSon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ÖRN: Girilen sayılardan hangisinin en büyük olduğunu bulalım

            int sayi, enbuyuk=0; ;
            bool kontrol; // ilk atamasını yapmadık çünkü do-while kullandık
            do
            {
                #region SayiIste 
                do
                {
                    Console.ResetColor();
                    Console.WriteLine("Bir sayi giriniz  :");
                    kontrol = int.TryParse(Console.ReadLine(), out sayi);
                    if (kontrol)
                        enbuyuk = sayi > enbuyuk ? sayi : enbuyuk;
                        //if (sayi > enbuyuk)
                          //  enbuyuk = sayi;
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("HATALI GİRİŞ!");
                    }

                } while (!kontrol);


                #endregion



                #region TamamMiDevamMi   
                ConsoleKeyInfo cevap; // do while kullandığım için ilk atamasını yapmaya gerek kalmadı. Çünkü 40.satırda ataması yapılıyor. sonra aşağıda 57. satırda sorgulanacak
                do
                {

                    Console.ResetColor();
                    Console.WriteLine("Tekrar sayı girmek ister misin? E / H");
                    cevap = Console.ReadKey();
                    Console.WriteLine();
                    switch (cevap.Key)
                    {
                        case ConsoleKey.E:
                            kontrol = false; // yukarı çıktığında tekrar sayı istemesi için kontrol değişkeni false yapıldı. yani default olarak ilk atandığı haline getirdik.
                            //Console.Clear(); 
                            break;
                        case ConsoleKey.H:
                            Console.WriteLine($"Girilen sayılardan en büyük olan = {enbuyuk}");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Cevabını anlayamadım!");
                            break;
                    }

                }
                while (cevap.Key != ConsoleKey.E && cevap.Key != ConsoleKey.H);
                // bastığı tuş e ve h dışında olduğu sürece soruyu soracağız...

                #endregion

                if (cevap.Key == ConsoleKey.H)
                  Console.WriteLine("Oyun bitti... Şimdi Tekrar başlatıyoruz.");

            } while (true);


        }
    }
}
