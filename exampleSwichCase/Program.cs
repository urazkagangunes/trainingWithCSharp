namespace Ornek12_SwichCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Swtich case kullanımı
            #region Ornek1
            int gun = 6;
            switch (gun)
            {
                case 1:
                    Console.WriteLine("PAZARTESİ");
                    break;
                case 2:
                    Console.WriteLine("SALI");
                    break;
                case 3:
                    Console.WriteLine("ÇRŞ");
                    Console.WriteLine("Haftanın tam ortasındayız");
                    break;
                case 4:
                    Console.WriteLine("PRŞ");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("HAFTASONU");
                    break;
                default:
                    Console.WriteLine("1-7 aralığı dışında değer girdiniz! bunun karşılığını bulamıyorum!");
                    break;
            }

            #endregion


            #region Ornek2

            char deneme = 'B';
            switch (deneme)
            {
                case '_': break;
                default:
                    break;
            }

            ConsoleColor renk= ConsoleColor.Green;

            switch (renk)
            {
                case ConsoleColor.Magenta: break;
            }

            IslemturuAl:
            Console.ResetColor();
            Console.WriteLine("Hangi işlemi yapmak istediğinizi seçiniz!!");
            Console.WriteLine("Toplama ---> 1");
            Console.WriteLine("Çıkarma ---> 2");
            Console.WriteLine("Çarpma  ---> 3");
            Console.WriteLine("Bölme   ---> 4");

            bool islemKontrol = int.TryParse(Console.ReadLine(), out int islemtur);

            if (!islemKontrol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("HATA! Lütfen geçerli bir işlem seçiniz!");
                goto IslemturuAl;
            }


            switch ((IslemTuru)islemtur)
            {
                case IslemTuru.Toplama:
                    Console.WriteLine($"{10+20}");
                    break;
                case IslemTuru.Cikarma:
                    Console.WriteLine($"{10- 20}");
                    break;
                case IslemTuru.Carpma:
                    Console.WriteLine($"{10 * 20}");
                    break;
                case IslemTuru.Bolme:
                    Console.WriteLine($"{10 / 20}");
                    break;
                case IslemTuru.ModAl:
                    Console.WriteLine($"{20 % 3}");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("HATA! Lütfen geçerli bir işlem sayısı giriniz!!");
                    goto IslemturuAl;
                    break;
            }


            string ay = "Mayıs";

            switch (ay)
            {
                case "Ocak":
                case "Şubat":
                    Console.WriteLine("KIŞ");
                    break;


                case "Mart":
                case "Nisan":
                case "Mayıs":
                    Console.WriteLine("İLKBAHAR");
                    break;

                case "Haziran":
                case "Temmuz":
                case "Ağustos":
                    Console.WriteLine("YAZ");
                    break;

                default:
                    break;
            }

            #endregion
        }
    }
}


public enum IslemTuru
{
    Toplama = 1,
    Cikarma = 2,
    Carpma = 3,
    Bolme = 4,
    ModAl = 5
}