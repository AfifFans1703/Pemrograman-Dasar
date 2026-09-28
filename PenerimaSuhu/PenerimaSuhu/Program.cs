using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenerimaSuhu
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("===================================");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("       Program Kategori Suhu       ");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("===================================");

                Console.WriteLine();
                Console.Write("Masukkan Nilai Suhu: ");
                double suhu = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();
                if (suhu >= 30)
                {
                    Console.WriteLine("Panas");
                }
                else if (suhu >= 20 && suhu < 30)
                {
                    Console.WriteLine("Sejuk");
                }
                else if (suhu < 20)
                {
                    Console.WriteLine("Dingin");
                }

                // Fungsi Tambahan
                Console.WriteLine();
                Console.Write("Ulangi...? Press Y key to restart or press other key to exit... ");
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
