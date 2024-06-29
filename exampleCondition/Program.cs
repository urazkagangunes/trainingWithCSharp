namespace Ornek05_KosulIfadeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programın iş akışına göre sorgulanması istenen kuralları
            //if ve switch case ile sorgulayabiliriz.

          
            // if eğer demektir
            if (10 > 5) //10 5ten büyük mü? cevap: True //parantez içindeki sorunun ya da durumun cevabı TRUE ise if'in içine girer.
                // if clause condition true code works
            {
                Console.WriteLine("if bloğuna girdi 10> 5");
            }

            if (1!=0) // 1 sıfıra eşit değil midir? cevap :TRUE 
            {
                Console.WriteLine("if bloğuna girdi 1 eşit değildir 0");

            }
            //matematik mantıktan geliyor 1 ve 1 = 1

            if (1 != 0 && DateTime.Now.Year == 2024) // 1 sıfıra eşit değil midir? cevap :TRUE 
            {
                Console.WriteLine("if bloğuna girdi her iki şartı da sağlıyor.");

            }

            if (DateTime.Now.Year == 2024 || DateTime.Now.Hour > 1) // 1 sıfıra eşit değil midir? cevap :TRUE 
            {
                Console.WriteLine("if bloğuna girdi herhangi bir şart sağlandı");

            }


            Console.WriteLine("--------------");
            //ÖRN: Kullanıcıdan yaş isteyiniz ve 18 yaşından küçük kullanıcıları
            //kayıt etmeyiniz
            Console.WriteLine("Yaşınızı giriniz  :");
            bool kontrol = byte.TryParse(Console.ReadLine(), out byte yas);
            if (kontrol==false) ///
            {
                Console.WriteLine("Lütfen uygun giriş yapınız!");
            }
        }
    }
}
