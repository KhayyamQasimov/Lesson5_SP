using System;
using System.IO;

namespace Encyrpt_Decyrpt
{
    public class CyrptoMethod
    {
        public static void EncyrptMethod()
        {
            try
            {
                Console.WriteLine("Sifrelenecek faylin tam yolunu daxil edin (Meselen: C:\\fayl.txt): ");
                string inputFile = Console.ReadLine();

                if (!File.Exists(inputFile))
                {
                    Console.WriteLine("XETA: Gosterilen fayl tapilmadi!");
                    return;
                }

                Console.WriteLine("Sifrelenmis yeni fayl hara yadda saxlanilsin? (Meselen: C:\\sifreli_fayl.enc): ");
                string outputFile = Console.ReadLine();

                Console.WriteLine("Sifrelemenin acar sozunu daxil edin: ");
                string key = Console.ReadLine();

                if (Loading.StartLoading())
                {
                    AesOperation.EncryptFile(key, inputFile, outputFile);
                    Console.WriteLine($"\nUgurla sifrelendi! Fayl buradadir: {outputFile}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nERROR: {ex.Message}");
            }
        }

        public static void DecyrptMethod()
        {
            try
            {
                Console.WriteLine("Desifrelenecek (sifresi acilacaq) faylin tam yolunu daxil edin: ");
                string inputFile = Console.ReadLine();

                if (!File.Exists(inputFile))
                {
                    Console.WriteLine("XETA: Gosterilen fayl tapilmadi!");
                    return;
                }

                Console.WriteLine("Sifresi acilmis yeni fayl hara yadda saxlanilsin? (Meselen: C:\\aciq_fayl.txt): ");
                string outputFile = Console.ReadLine();

                Console.WriteLine("Desifrelenmenin acar sozunu daxil edin: ");
                string DecyrptKey = Console.ReadLine();

                if (Loading.StartLoading())
                {
                    AesOperation.DecryptFile(DecyrptKey, inputFile, outputFile);
                    Console.WriteLine($"\nUgurla desifre olundu! Fayl buradadir: {outputFile}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nERROR: Sifreni acarken xeta bas verdi. Acar soz sehv ola biler. (Detallar: {ex.Message})");
            }
        }
    }
}