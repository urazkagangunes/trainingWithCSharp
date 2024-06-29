namespace Ornek13_SwichCaseDevam_ConsoleKeyInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //ÖRN: x bankasının A ve B kampanyaları var
        // A kampanyası anaparaya %5 artış yapıyor
        // B kampanyası anaparaya içinde bulunduğumuz dakika çiftse %6 değilse %3 uyguluyor.
        // C kampanyası anaparaya 200 arttırsın --> tekrar ederken böyle detaylar ekleyerek kavramanızı arttırabilirsiniz.
        Baslangic:
            decimal anapara = 0m;
            const double aOran = 5; // const sabit demektir. const bir değişken bir kere tanımlanır ve içeriğindeki değer sonradan değiştirilemez!

            double bOran = 3;
        AnaparaGirisi:
            Console.ResetColor();
            Console.WriteLine("Anapara gir  :");
            bool kontrol = decimal.TryParse(Console.ReadLine(), out anapara);
            if (!kontrol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lütfen geçerli giriş yapınız!");
                goto AnaparaGirisi;

            }



        //#region Charile
        ////char olarak alalım
        ///
        //KampanyaSecimi:
        //    Console.ResetColor();
        //    Console.WriteLine("Kampanya seçiniz  ( A / B )");

        //    bool kontrolKampanya = char.TryParse(Console.ReadLine(), out char kampanya);
        //    if (!kontrolKampanya)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("Lütfen geçerli kampanaya seçiniz!");
        //        goto KampanyaSecimi;

        //    }
        //switch (kampanya)
        //{
        //    case 'A':
        //    case 'a':
        //        anapara = anapara + (anapara * (decimal)0.05);
        //        break;

        //    case 'B':
        //    case 'b':
        //        Console.WriteLine($"saat: {DateTime.Now}");
        //        if (DateTime.Now.Minute % 2 == 0)
        //            anapara = anapara + (anapara * (decimal)0.06);
        //        else
        //            anapara = anapara + (anapara * (decimal)0.03);
        //        break;
        //    default:
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("Lütfen geçerli kampanaya seçiniz!");
        //        goto KampanyaSecimi;
        //}

        //#endregion





        KampanyaSecim:
            Console.ResetColor();
            Console.WriteLine("Kampanya seçiniz  ( A / B )");
            //ConsoleKey olarak al
            ConsoleKeyInfo kampanyaSecim = new ConsoleKeyInfo();
            kampanyaSecim = Console.ReadKey();

            #region KeyInfoile
            switch (kampanyaSecim.Key)
            {
                case ConsoleKey.B:
                    Console.WriteLine($"saat: {DateTime.Now}");
                    if (DateTime.Now.Minute % 2 == 0)
                        anapara = anapara + (anapara * (decimal)0.06);
                    else
                        anapara = anapara + (anapara * (decimal)0.03);
                    break;

                case ConsoleKey.A:
                    anapara = anapara + (anapara * (decimal)0.05);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lütfen geçerli kampanaya seçiniz!");
                    goto KampanyaSecim;
            }
            #endregion


            //#region keyinfochar
            ////amacıma hizmet etmiyor üsttekini kullanacağım
            //switch (kampanyaSecim.KeyChar)
            //{
            //    case 'B':
            //    case 'b':
            //        Console.WriteLine($"saat: {DateTime.Now}");
            //        if (DateTime.Now.Minute % 2 == 0)
            //            anapara = anapara + (anapara * (decimal)0.06);
            //        else
            //            anapara = anapara + (anapara * (decimal)0.03);
            //        break;

            //    case 'A':
            //    case 'a':
            //        anapara = anapara + (anapara * (decimal)0.05);
            //        break;
            //    default:
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Lütfen geçerli kampanaya seçiniz!");
            //        goto KampanyaSecim;
            //}
            //#endregion


            Console.WriteLine($"Seçtiğiniz kampanya sonucunda paranız değerlendi :{anapara} \n");
            // not: \n bir satır aşağı inmesini sağlar.
            goto Baslangic;
        }
    }
}
