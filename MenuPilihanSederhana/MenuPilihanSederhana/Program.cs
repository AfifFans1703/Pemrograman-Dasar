using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MenuPilihanSederhana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("       Program Menu Sederhana       ");
            Console.WriteLine("====================================");
            double angka;
            double angka0;
            int keluar = 0;
            Console.WriteLine();
            Console.Write("Masukkan Angka Awal: ");
            angka = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Angka {angka}");
            Console.WriteLine("Tekan Enter untuk lanjut...");
            Console.ReadLine();
            while (true)
            {
                Console.WriteLine("=============");
                Console.WriteLine("   Pilihan   ");
                Console.WriteLine("=============");
                Console.WriteLine();
                Console.WriteLine("1. Penjumlahan");
                Console.WriteLine("2. Pengurangan");
                Console.WriteLine("3. Perkalian");
                Console.WriteLine("4. Keluar");
                Console.Write("Pilihan: ");
                int pilihan = Convert.ToInt32(Console.ReadLine());
                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("=== Penjumlahan ===");
                        Console.Write($"{angka} + ");
                        angka0 = Convert.ToDouble(Console.ReadLine());
                        angka = angka + angka0;
                        Console.WriteLine($"Angka: {angka}");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("=== Pengurangan ===");
                        Console.Write($"{angka} - ");
                        angka0 = Convert.ToDouble(Console.ReadLine());
                        angka = angka - angka0;
                        Console.WriteLine($"Angka: {angka}");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("=== perkalian ===");
                        Console.Write($"{angka} x ");
                        angka0 = Convert.ToDouble(Console.ReadLine());
                        angka = angka * angka0;
                        Console.WriteLine($"Angka: {angka}");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("=== Keluar ===");
                        Console.Write("Tekan Enter untuk Keluar...");
                        keluar = 1;
                        Console.ReadLine();
                        break;
                }
                if (keluar == 1)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}
