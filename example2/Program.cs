using System.Text;

namespace Ornek02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ilk örnekte değişkenlerin değerleriniz biz atadık
            //Bu örnekte dışardan alınacak böylece tipi farklı olan değişkenlerin
            //dönüşümüne bakacağız.
            Console.WriteLine("Ad - soyad giriniz : ");
            string adSoyad = Console.ReadLine(); // satırı okur

            Console.WriteLine("Yaş giriniz : ");
            // değişken dönüşüm dönüşüm işlemleri
            byte yas = Convert.ToByte(Console.ReadLine()); // C# tip bağımlı dildir.

            Console.WriteLine("Kilonuzu giriniz : ");
            // değişken dönüşüm dönüşüm işlemleri
            double kilo = Convert.ToDouble(Console.ReadLine()); // C# tip bağımlı dildir.


            Console.WriteLine("Cinsiyet giriniz : ");
            // değişken dönüşüm dönüşüm işlemleri
            char cinsiyet = Convert.ToChar(Console.ReadLine()); // C# tip bağımlı dildir.

            decimal x = Convert.ToDecimal(Console.ReadLine());

            //string tipinin istisna durumları vardır.
            //string vip gibi özel muamelelere sahiptir.
            string deneme = Convert.ToString(DateTime.Now.Year);
            string deneme2 = DateTime.Now.ToString();

            Console.Clear();
            Console.WriteLine("Hoşgeldiniz");
            Console.WriteLine("1. yöntemle yazdırdık");
            Console.WriteLine("ad soyad " + adSoyad);
            Console.WriteLine("cinsiyet " + cinsiyet);

            Console.WriteLine("2. yöntemle yazdırdık");

            Console.WriteLine(string.Format("adsoyad:",adSoyad));
            Console.WriteLine("3. yöntemle yazdırdık");

            Console.WriteLine("Ad Soyad {0} Yaş {1} Cinsiyet {2}",adSoyad, yas,cinsiyet);

            Console.WriteLine("4. yöntemle yazdırdık dolar işaretli");

            //string format
            Console.WriteLine($"Ad Soyad {adSoyad} cinsiyet= {cinsiyet} yaş= {yas}");

            Console.WriteLine("5. yöntemle yazdırdık string builder");

            //Daha profesyonel fakat daha uzun yazması sürdüğü için daha nadir tercih edilir.
            StringBuilder sb = new StringBuilder(); // classtan nesne üreterek değişkenimi oluşturdum
            sb.Append("ADsoyad: ");
            sb.Append(adSoyad);
            sb.Append("cİNSİYET ");
            sb.Append(cinsiyet);
            Console.WriteLine(sb);

        }
    }
}
