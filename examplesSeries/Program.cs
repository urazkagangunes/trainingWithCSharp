namespace Ornek01_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diziler (Array)
            //içinde birçok aynı türde değer barındırabilen yapıdır.

            //Dizi nasıl tanımlanır.
            //tip[] diziIsim= new tip[elemansayisi];
            //isimleri tutacak dizi oluşturalım

            string[] isimler = new string[5];
            isimler[0] = "Betül";
            isimler[4] = "Ahmet";
            isimler[2] = "Ali";
            isimler[3] = "Veli";
            //isimler[1] = "Ayşe"; 


            // dizi tanımı 2. yol
            string[] sehirler = new string[] { "İstanbul", "İzmir", "Ankara","Adana"};
            // string tipte 4 elemanlı dizi
            //dizinin 0. indeksinden İstanbul var
            //dizinin 1. indeksinden izmir var
            //dizinin 2. indeksinden ankara var
            //dizinin 3. indeksinden adana var


            //c#ta dizilerin indexleri sıfırdan başlar.
            double[] derece = new double[2];
            derece.SetValue(17.2, 0); //0. indexe 17.2 atandı.
            derece.SetValue(30.5, 1); //0. indexe 17.2 atandı.

            byte[] plakalar = new byte[81];
            plakalar[33] = 34; // istanbul
            plakalar.SetValue(1, 0); // sıfırın indexe adananın plakası atandı

            // 
            char[] harfler = new char[10];

            Array.Resize(ref harfler, 12);
                    
        }
    }
}
