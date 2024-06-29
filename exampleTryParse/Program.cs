namespace Ornek04_TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bizim elimizde COnvert ve PArse olmasına rağmen
            // dönüşüm yaparken TRYParse kullanmamız faydalı olacaktır.
            // Kullanıcıdan değer alındığında ( yani olurda ÇEVİRME/DÖNÜŞTÜRME)
            // işleminde BİR SORUN çıkma ihtimaline karşı TRY PARSE kullanırsak
            // sorun olsa bile proje patlamadan çalışmaya devam eder.

            // TryParse metodunu kim çağırdıysa kendisine verilen değeri ona
            // dönüştürmeye çalışır
            // Eğer dönüşüm başarılı olursa o değeri out komutunun hemen
            // yanında tanımladığı değişkene atar ve BOOL TRUE sonucunu verir.
            //
            //Eğer dönüşüm başarısız ise BOOL değişkene FALSE atamasını yapar 
            //out komutunun hemen yanında tanımladığı değişkene HİÇ birşey
            ////ATAYAMAZ
            ///

            Console.WriteLine("Yaşınızı giriniz  :");
            //   byte age= byte.Parse(Console.ReadLine());

            // 1. yöntem
            bool cevap = byte.TryParse(Console.ReadLine(), out byte yas);
            Console.WriteLine($"cevap değişkeninin değeri= {cevap}");
            Console.WriteLine($"yas değişkeninin değeri= {yas}");
            //2. yöntem
            Console.WriteLine("Yaşınızı giriniz  :");

            bool kontrol = byte.TryParse(Console.ReadLine(), out byte yasiniz);
            Console.WriteLine($"kontrol değişkeninin değeri= {kontrol}");
            Console.WriteLine($"yasiniz değişkeninin değeri= {yasiniz}");



            Console.WriteLine("Kilonuzu giriniz  :");
            //   byte age= byte.Parse(Console.ReadLine());

            // 1. yöntem
            bool cevap2 = int.TryParse(Console.ReadLine(), out int kilo);
            Console.WriteLine($"cevap2 değişkeninin değeri= {cevap2}");
            Console.WriteLine($"kilo değişkeninin değeri= {kilo}");
            //2. yöntem
            Console.WriteLine("Kilo giriniz  :");

            int kilonuz;
            bool kontrol2 = int.TryParse(Console.ReadLine(), out kilonuz);
            Console.WriteLine($"kontrol2 değişkeninin değeri= {kontrol2}");
            Console.WriteLine($"kilonuz değişkeninin değeri= {kilonuz}");
        }
    }
}
