namespace Ornek16_Faktoryel_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5 4 3 2 1
            int sonuc = 1;
            for (int i = 5; i >=1; i--) 
            {
                Console.Write($"{i} ");
                sonuc = sonuc * i;
            }

            Console.WriteLine($"sonuç={sonuc}");
            // 5 4 3 2 1
            sonuc = 1;
            for (int i = 1; i <=5; i++)
            {
                Console.Write($"{i} ");
                sonuc = sonuc * i;
            }

            Console.WriteLine($"sonuç={sonuc}");

        }
    }
}
