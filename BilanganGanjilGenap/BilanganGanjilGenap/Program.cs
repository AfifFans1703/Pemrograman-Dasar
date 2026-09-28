using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilanganGanjilGenap
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("======================================");
                Console.WriteLine("Program Kategori Bilangan Ganjil/Genap");
                Console.WriteLine("======================================");
                Console.WriteLine("--------------------------------------");

                Console.WriteLine();
                Console.Write("Masukkan Nilai: ");

                int nilai = Convert.ToInt32(Console.ReadLine());

                // Menggunakan fungsi sisa bagi
                if (nilai % 2 == 0) // Jika hasil bagi adalah 0 (nol) maka termasuk bilangan genap
                {
                    Console.WriteLine(nilai + " Adalah Bilangan Genap!!");
                }
                else // Jika hasil bagi bukan/selain 0 (nol) maka termasuk bilangan ganjil
                {
                    Console.WriteLine(nilai + " Adalah Bilangan Ganjil!!");
                }

                Console.WriteLine(); // Fungsi tambahan (Perulangan)
                Console.Write("Ulangi...? ");
                Console.Write("Press Y key to restrat or press other key to exit... ");
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
