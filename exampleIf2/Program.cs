namespace Ornek07_IfDevam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ÖRN: Kullanıcıdan yaş isteyiniz ve 18 yaşından küçük kullanıcıları
            //kayıt etmeyiniz

            Console.WriteLine("Yaşınızı giriniz  :");
            bool kontrol = byte.TryParse(Console.ReadLine(), out byte yas);
            if (kontrol)
            {
                Console.WriteLine("Bilgiler kontrol ediliyor...");

                // kuralları koşulları sorgulamaya devam edelim
                if (yas > 18)
                {
                    Console.WriteLine("Kayıt başarılı!");
                }
                else
                {
                    Console.WriteLine("18 yaşından küçük old için kayıt başarısız!");

                }

            }
            else // kontrol==false // else yanına şart yazılmaz
            {
                Console.WriteLine("Lütfen geçerli giriş yapınız!");
            }

        }
    }
}
