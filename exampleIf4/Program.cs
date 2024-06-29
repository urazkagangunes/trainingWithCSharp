namespace Ornek09_IfDevam
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //ÖRN: Kullanıcıdan bir sayı alınız ve yazı rengini değiştiriniz
        Baslangic:
            Console.Write("1-15 arasında Sayı gir :");
            bool sayiKontrol = int.TryParse(Console.ReadLine(), out int sayi);
            if (!sayiKontrol)
            {
                Console.WriteLine("HATA Lütfen geçerli giriş yapınız!!");
            }
            else if (sayi >= 1 && sayi <= 15)
            {
                Console.ForegroundColor = (ConsoleColor)sayi; // kast ettiniz casting
                Console.WriteLine("Renk değişti mi???");

            }
            else
            {
                Console.WriteLine("HATA 1-15 arasında gir demedik miiii :D ");
            }
            goto Baslangic;
        }
    }
}


