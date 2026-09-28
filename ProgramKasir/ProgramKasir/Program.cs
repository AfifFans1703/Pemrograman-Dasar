using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramKasir
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("===================================");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("       Mesin Kasir Sederhana       ");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("===================================");

                Console.WriteLine();
                Console.Write("Masukkan Total Harga Barang: ");

                double total = Convert.ToDouble(Console.ReadLine());
                double diskon;
                double potongan;
                double bayar;

                Console.WriteLine();
                Console.WriteLine("=========================");
                Console.WriteLine("  Pilih Jenis Pelanggan  ");
                Console.WriteLine();
                Console.WriteLine("1. Umum");
                Console.WriteLine("2. Member");

                int jenis = Convert.ToInt32(Console.ReadLine());

                switch (jenis)
                {
                    case 1:
                        Console.WriteLine("--==== Pelanggan Umum ====--");
                        diskon = 0.0;
                        potongan = total * diskon;
                        bayar = total - potongan;
                        Console.WriteLine("Total Barang Yang Harus dibayar Adalah Rp " + bayar);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("--==== Pelanggan Member ====--");
                        diskon = 0.05;
                        potongan = total * diskon;
                        bayar = total - potongan;
                        Console.WriteLine("Total Barang Yang Harus dibayar Adalah Rp " + bayar);
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Menu Tidak Tersedia");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Ulangi...? Press Y key to restart or press other key to exit... ");
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
