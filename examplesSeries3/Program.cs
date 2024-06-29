using System.Threading.Channels;

namespace Ornek03_DizilerDevam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizinin elemanlarını sıralayalım
            int[] sayilar= new int[] { 100, 20, -3 };

            Console.WriteLine("Dizinin elamanları ");
            foreach (int sayi in sayilar)
                Console.Write($"{sayi} \t");

            Console.WriteLine();
            //Dizinin elamanlarını sıralamak istersek Array.Sort 
            Array.Sort(sayilar);
            Console.WriteLine("Dizinin elamanları küçükten büyüğe sıralandı");
            foreach(int sayi in sayilar)
                Console.Write($"{sayi} \t");
            Console.WriteLine();


            char[] harfler = new char[] { 'B', 'N', 'Z', 'A' };

            Console.WriteLine("Dizinin elamanlarısıralandı");
            foreach (char h in harfler)
                Console.Write($"{h} \t");
            Console.WriteLine();
            Array.Sort(harfler);
            Console.WriteLine("Dizinin elamanları küçükten büyüğe sıralandı");
            foreach (char h in harfler)
                Console.Write($"{h} \t");

            Console.WriteLine();


            //önce sort ile küçükten büyüğe sıralıyorz sonra diziyi tersine çeviriyoruz böylece büyükten küçüğe sıralamış oluyoruz. Çünkü büyükten küçüğe sıralayan bir komut yok.

            string[] isimler = new string[] { "zeynep", "ali", "betül", "ezgi", "ayşe" };
            Console.WriteLine("Dizinin elamanları ");
            foreach (string s in isimler)
                Console.Write($"{s} \t");

            Console.WriteLine();
            Array.Sort(isimler);

            Console.WriteLine("Dizinin elamanları sıralandı ");
            foreach (string s in isimler)
                Console.Write($"{s} \t");
            Console.WriteLine();
            Array.Reverse(isimler);

            foreach (string s in isimler)
                Console.Write($"{s} \t");


            Console.WriteLine();

            DateTime[] dt = new DateTime[] { DateTime.Now, new DateTime(1992, 11, 14), new DateTime(2000, 1, 5) };
            Console.WriteLine("Dizinin elamanları ");
            foreach (DateTime d in dt)
                Console.Write($"{d} \t");
            Console.WriteLine();

            Array.Reverse(dt);
            Console.WriteLine("Array.Reverse ");
            foreach (DateTime d in dt)
                Console.Write($"{d} \t");
            Console.WriteLine();

            Console.WriteLine("-----------------------");
            ConsoleColor[] renkler = new ConsoleColor[] {ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Magenta };

            foreach (ConsoleColor r in renkler)
                Console.Write($"{r} \t");
            Console.WriteLine();

            //Array.Foreach ile Action yazarak yukarıdaki foreach işleminin aynısını daha kısa 
            //yazıyoruz
            //Böylece tek satırsa FOREACH döngüsü kurmuş oluyoruz
            //İleride işleyeceğimiz LINQ konusuna temel oluşturmak için burada bir kez kullandık


            Array.ForEach(renkler, r => Console.Write($"{r} \t"));

            Console.WriteLine();
            Array.ForEach(renkler, rnk => Console.Write($"{rnk} \t"));
            Console.WriteLine();
            Array.ForEach(renkler, x => Console.Write($"{x} \t"));




        }
    }
}
