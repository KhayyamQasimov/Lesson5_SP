using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Encyrpt_Decyrpt
{
    public class Loading
    {
        public static bool StartLoading()
        {
            Console.WriteLine("\n[Space] - Dayandir / Davam et | [Esc] - Legv et");
            bool isPaused = false;

            for (int i = 0; i <= 100; i++)
            {
                while (Console.KeyAvailable || isPaused)
                {
                    if (Console.KeyAvailable)
                    {
                        var key = Console.ReadKey(true).Key;

                        if (key == ConsoleKey.Escape)
                        {
                            Console.WriteLine("\n\nProses legv olundu!");
                            return false;
                        }
                        else if (key == ConsoleKey.Spacebar)
                        {
                            isPaused = !isPaused;

                            if (isPaused)
                            {
                                Console.Write($"\rYuklenir... {i}% [Dayandirildi]     ");
                            }
                        }
                    }

                    if (isPaused)
                    {
                        Thread.Sleep(100);
                    }
                }

                Console.Write($"\rYuklenir... {i}%                  ");
                Thread.Sleep(45);
            }

            Console.WriteLine("\nYuklenme tamamlandi!\n");
            return true;
        }
    }
}
