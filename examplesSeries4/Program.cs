namespace Ornek04_DizilerDevam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi içindeki bir elamanın index numarasını bulalım

            char[] harfler = new char[] { 'g', 's', 'a', 'x', 'b', 'n','d', 'c', 'd' };
            //d elemanı dizide kaçıncı indextedir?

            int index = Array.IndexOf(harfler, 'd');
            Console.WriteLine($"d elemanı dizide {index}. indekstedir.");

            index = Array.LastIndexOf(harfler, 'd');
            Console.WriteLine($"d elemanı dizide {index}. indekstedir.");

            string[] isimler = new string[] { "Ayşe", "ahmet", "betÜL", "VELİ" };

            //contains komutu içerir mi
           bool varMi= isimler.Contains("ayşe"); // isimler dizisi ayşe elemanını içerir mi? İsimler dizisinde ayşe elemanı var mıdır?
            //ayşe dizide Ayşe şeklinde bulunmaktadır. Contains metodu büyük küçük harfe duyarlıdır.
           
            if (varMi)
                Console.WriteLine("Ayşe dizide buldum");
            else
                Console.WriteLine("ayşe dizide yoktur");

            //2. yol

            if (isimler.Contains("betÜL")) // eşit mi diye bakıyor
                Console.WriteLine("betÜL dizide buldum");
            else
                Console.WriteLine("betÜL dizide yoktur");


            // 
            Console.WriteLine("\n \n ");
            string sehir = "istanbul"; // her string bir char dizisidir
            foreach (var item in sehir) // var da nedirrrrr????? item daa nedirrr?????
            {
                if (sehir.Contains("s")) // s harfi var mı?
                {
                    Console.WriteLine("s harfi vardır");
                }
                Console.WriteLine(item);
            }
        }
    }
}
