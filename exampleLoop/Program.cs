namespace Ornek14_DonguyeGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 1;

            Baslangic:
            if (sayac <=15)
            {
                Console.WriteLine(sayac);
                sayac = sayac + 1;
            }
            goto Baslangic;

            //DÖNGÜ: Tekrar eden işlemleri kolayca yapabilmek amacıyla döngü kullanırız
           
            // FOR : Bir kod bloğunu bir  başlangıç ve bitiş değeri arasında belirli defa tekrar tekrar çalıştıran yapıdır

            //Foreach: Koleksiyonlara özel döngüdür. Aslında for'un koleksiyonlara göre özelleştirilmiş halidir.

            // //WHILE, DO-WHILE : Bir kod bloğunu  bir şarta bağlı olarak şart sağlandığı sürece tekrar tekrar çalıştıran yapıdır.

        }
    }
}
