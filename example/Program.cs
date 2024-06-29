namespace Ornek01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // dışarıdan alınan girdiler nasıl yönetilir?
            // değişkenler variables
            // C# ta değişkenler TİP bağımlıdır.
            // Metinsel Sayısal veriler
            // string 
            //tipi değişken adı 
            string a; // değişkeni tanımladım
            a = "betül"; // değişkene atama
            Console.WriteLine(a); // değişkenin içeriği ekrana yazdırıldı.
            string adSoyad = "Betül akşan";
            byte yas = 17;
            char cinsiyet = 'K'; // char tek tırnak
            double kilo= 48.5;
            int kacKitapOkudun = 500;
            bool ehliyetinVarMi = true;
            // Datetime bir structtır. ve değişkne tipi olarak kullanılabilir?
        
          
            DateTime dogumTarihi = new DateTime(1992, 11, 14); // new kelimesi ile
            //classtan yani sınıfından nesne türetiliyor.
            Program pp = new Program();

            //C# ta değişken tipi olarak neler kullanılabiliyor?
            //c# tanımladığı tipler string byte int decimal long short char bool
            //class   //classtan yani sınıfından nesne türetiliyor.
            // Program pp = new Program();
            //struct  DateTime dogumTarihi = new DateTime(1992, 11, 14);
            //interface 
            //enum sıralı liste

            // değişkenleri nasıl kullanıyoruz?
            // ekranda gösterme, koşul ifadeleriyle sorgulama vb alt satırlardaki
            // kod işlemlerimizde içindeki değeri kullanıyoruz.

            // yukarıda tanımlanan değişkenleri ekrana yazdıralım
            Console.WriteLine("Hoşgeldiniz");
            Console.WriteLine("ad soyad " + adSoyad);
            Console.WriteLine( "yaş " + yas);
            Console.WriteLine("cinsiyet "+ cinsiyet);


        }

    }
}
