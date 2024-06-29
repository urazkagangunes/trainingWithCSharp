namespace Ornek23_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ÖRN: Kullanıcıdan sayılar alıp toplamını ekrana yazalım.
            int sayi, toplam = 0;
            bool kontrol = false;

            while (true)
            {
                #region SayiIste 
                while (!kontrol)
                {

                    Console.ResetColor();
                    Console.WriteLine("Bir sayi giriniz  :");
                    kontrol = int.TryParse(Console.ReadLine(), out sayi);
                    if (kontrol)
                        toplam += sayi;
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("HATALI GİRİŞ!");
                    }
                }

                #endregion

                #region TamamMiDevamMi

                ConsoleKeyInfo cevap= new ConsoleKeyInfo();
                
                // bastığı tuş e ve h dışında olduğu sürece soruyu soracağız...
                while (cevap.Key!=ConsoleKey.E && cevap.Key!=ConsoleKey.H)
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
                            Console.WriteLine($"Girilen sayıların toplamı = {toplam}");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Cevabını anlayamadım!");
                            break; 
                    } 
                }

                #endregion
                if (cevap.Key==ConsoleKey.H)
                {
                    Console.WriteLine("Oyun bitti... Şimdi Tekrar başlatıyoruz.");
                    kontrol = false; // yukarı çıktığında tekrar sayı istemesi için kontrol değişkeni false yapıldı. yani default olarak ilk atandığı haline getirdik.

                }
            }
        }
    }
}
