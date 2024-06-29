namespace Ornek31_IcIceDongu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ÖRN: Yıldız örneği
            // * * * * *
            // * * * * *
            // * * * * *

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(" B ");
                }
                // sutündaki işini bitirdi alt satıra geçsin
                Console.WriteLine();
            }
            Console.WriteLine("-----");

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j % 2 == 0)
                        Console.Write(" 0 ");
                    else
                        Console.Write(" 1 ");

                }
                // sutündaki işini bitirdi alt satıra geçsin
                Console.WriteLine();
            }


            Console.WriteLine("-------");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == j)
                        Console.Write(" 0 ");
                    else
                        Console.Write(" 1 ");

                }
                // sutündaki işini bitirdi alt satıra geçsin
                Console.WriteLine();
            }


            Console.WriteLine("-------");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (((i + j) % 2 == 0 || i == j) && j != 1 && j != 5)
                        Console.Write(" 0 ");
                    else
                        Console.Write(" 1 ");

                }
                // sutündaki işini bitirdi alt satıra geçsin
                Console.WriteLine();
            }

           

        }



    }
}
