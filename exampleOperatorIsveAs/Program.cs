namespace Ornek26_OperatorIsveAs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // is ve as operatörleri
            //Bu operatörleri şuanda konu anlatımı içinde verdik
            //Bu operatörleri ilerleyen zamanlarda proje yaparken çook kullanacağız

            //as operatörü

            object deger = "betül";
            string isim;
            isim = Convert.ToString(deger);
            isim=(string)deger;
            isim = deger as string; // as cast etmektedir. bir yukarıdaki satır bunu daha kolayca yapmamızı sağlıyor.

            //is sorgulama yapıyor.

            object ad = "ayşe";
            if (ad is string) // not: windows form gördüğümüz zaman is komutu kullanacağız.
            {
                Console.WriteLine("Bu değişken string tiptedir");
            }
            bool durum = ad is string; // tek satırda kullanıldı.
        }
    }
}
