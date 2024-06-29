namespace Ornek08_IfDevam
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //if else if 
        //if else if else

        //ÖRN: Kullanıcıdan yaş isteyiniz ve 18 yaşından küçük kullanıcıları
        //kayıt etmeyiniz
        Baslangic:
            Console.WriteLine("Yaşınızı giriniz  :");
            bool kontrol = byte.TryParse(Console.ReadLine(), out byte yas);
            if (!kontrol)  // soru: kontrol değişkeni FALSE mu? cevap: TRUE(evet)
                Console.WriteLine("Lütfen Geçerli giriş yapınız!!!!");
            else if (yas < 18 || yas >= 70)
                Console.WriteLine("HATA: Yaş 18 ile 70 arasında olmalıdır!!");
            else
              Console.WriteLine("KAYIT başarılıdır!");

            
            goto Baslangic;
            //ÖNEMLİ NOT:
            //if'i tek başına kullanabilirim
            //if - else şeklinde kullanabilirim
            //if içinde if kullanabilirim
            //if -else if -else if-... şeklinde kullanabilirim
            //if -else if- else if -... -else şeklinde kullanabilirim
            //if koşulunun içinde sadece tek bir satır kod yazacaksanız süslü parantezleri kullanmayabilirsiniz
            //Ben tek satır yazsam her daim süslü parantez kullanıyorum
            //sebebi alışkanlık + daha temiz durduğunu düşünüyorum + ilerleyen günlerde if'in koşulu artarsa zaten süslü koydupum için süslü parentezi unutmamış olurum
        }
    }
}
