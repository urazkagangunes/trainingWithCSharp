namespace Ornek20_WhileDevam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Kullanıcı doğru giriş yapmadığı sürece sayı isteyelim
            //kaç defa döneceğimi bilmediğim için while ya da do while kullanmalıyım
            bool sayiKontrol = false;
            while (!sayiKontrol)
            {
                Console.ResetColor();
                Console.Write("Sayı gir :");
                sayiKontrol = int.TryParse(Console.ReadLine(), out int sayi);

                if (!sayiKontrol)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("HATA Lütfen geçerli giriş yapınız!!");
                    //eskiden döngüleri bilmediğimizde goto derdik
                }
            }
            Console.WriteLine("HOŞGELDİNNN...");








        }
    }
}
