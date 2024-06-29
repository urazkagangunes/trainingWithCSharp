namespace Ornek11_Datetime_TimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doğum tarihi giriniz   :");
            DateTime.TryParse(Console.ReadLine(), out DateTime dt);
           
            //if yerleştirerek gerekli kontrolleri yapmalıyız.

            // TimeSpan : zaman aralığı demektir
            //Datetime ile ilgili matematiksel işlemlerimizi yapmamızı sağlar
            //DateTime ve Timespan bir structır.

            //2024-1992
            Console.WriteLine($"Yaşınız= {DateTime.Now.Year - dt.Year}");

            TimeSpan zamanAraligi = new TimeSpan(); // yapıdan (structtan) bir örnek (yani nesne) türetiyoruz. 

            zamanAraligi = DateTime.Now - dt;
            Console.WriteLine($"Kaç gündür yaşamışsınız = {zamanAraligi.TotalDays}");

            zamanAraligi = DateTime.Now - dt;
            Console.WriteLine($"Kaç saattir yaşamışsınız = {zamanAraligi.TotalHours}");

        }
    }
}
