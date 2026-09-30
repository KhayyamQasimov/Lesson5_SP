using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encyrpt_Decyrpt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] secimler = { "1. Encrypt (Sifrele)", "2. Decrypt (Sifreni ac)", "3. Cixis" };
            int secilmisIndex = 0;
            bool davam = true;

            while (davam)
            {
                Console.Clear();
                Console.WriteLine("Sifreleme proqrami :)\n");

                for (int i = 0; i < secimler.Length; i++)
                {
                    if (i == secilmisIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"=> {secimler[i]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"   {secimler[i]}");
                    }
                }

                ConsoleKeyInfo basilanDuyma = Console.ReadKey(true);

                if (basilanDuyma.Key == ConsoleKey.UpArrow)
                {
                    secilmisIndex--;
                    if (secilmisIndex < 0)
                        secilmisIndex = secimler.Length - 1;
                }
                else if (basilanDuyma.Key == ConsoleKey.DownArrow)
                {
                    secilmisIndex++;
                    if (secilmisIndex >= secimler.Length)
                        secilmisIndex = 0;
                }
                else if (basilanDuyma.Key == ConsoleKey.Enter)
                {
                    Console.Clear();

                    switch (secilmisIndex)
                    {
                        case 0:
                            CyrptoMethod.EncyrptMethod();
                            break;
                        case 1:
                            CyrptoMethod.DecyrptMethod();
                            break;
                        case 2:
                            davam = false;
                            Console.WriteLine("Proqramdan cixilir...");
                            break;
                    }

                    if (davam)
                    {
                        Console.WriteLine("\nMenyuya qayitmaq ucun isdenilen duymeye basin...");
                        Console.ReadKey(true);
                    }
                }
            }
        }
    }
}
