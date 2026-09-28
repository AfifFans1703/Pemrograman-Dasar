using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenentukanBilangan
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Masukkan Bilangan: ");
                int angka = Convert.ToInt32(Console.ReadLine());

                if (angka > 0)
                {
                    Console.WriteLine("Bilangan Positif");
                    if (angka % 2 == 0)
                    {
                        Console.WriteLine("Bilangan Genap");
                    }
                    else
                    {
                        Console.WriteLine("Bilangan Ganjil");
                    }
                }
                else if (angka < 0)
                {
                    Console.WriteLine("Bilangan Negatif");
                    if (angka % 2 == 0)
                    {
                        Console.WriteLine("Bilangan Positif");
                    }
                    else
                    {
                        Console.WriteLine("Bilangan Negatif");
                    }
                }
                else
                {
                    Console.WriteLine("Bilangan Nol");
                }
                Console.WriteLine();
                Console.Write("Ulangi...? ");
                Console.Write("Press Y key to restart or press other key to close... ");
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.Clear();
                    break;
                }
            }
        }
    }
}
