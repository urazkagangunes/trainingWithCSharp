namespace Ornek22_WhileTekari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("while döngüsü break örnek");
            int i = 10;
            while (i < 50)
            {
                if (i == 25)
                    break; // döngüyü kırar

                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("while döngüsü continue örnek");
            i = 10;
            while (i < 50)
            {
                if (i == 25)
                {
                    i++;
                    continue;
                }// döngüde sıçrama yapar / aşağı satıra inmeden başa atlar / devam eder 
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
