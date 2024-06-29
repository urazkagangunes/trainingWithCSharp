namespace Ornek03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yaşınızı giriniz  :");
          //  byte yas = Convert.ToByte(Console.ReadLine()); 
            byte yas = byte.Parse(Console.ReadLine()); // dönüşümü parse ile de yapabilirsiniz.


            //
            //double kilo = Convert.ToDouble(Console.ReadLine()); 
            double kilo=double.Parse(Console.ReadLine());
           
        }
    }
}
