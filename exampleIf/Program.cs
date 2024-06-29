namespace Ornek06_IFDevam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------");
            //ÖRN: Kullanıcıdan yaş isteyiniz ve 18 yaşından küçük kullanıcıları
            //kayıt etmeyiniz
            Console.WriteLine("Yaşınızı giriniz  :");
            bool kontrol = byte.TryParse(Console.ReadLine(), out byte yas);
            if (kontrol == true)
            {
                Console.WriteLine("Bilgiler kontrol ediliyor...");
            }
            else // kontrol==false // else yanına şart yazılmaz
            {
                Console.WriteLine("Lütfen geçerli giriş yapınız!");
            }
        }
    }
}
