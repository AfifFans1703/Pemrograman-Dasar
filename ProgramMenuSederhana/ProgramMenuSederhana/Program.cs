using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramMenuSederhana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================");
            Console.WriteLine("              Menu              ");
            Console.WriteLine("================================");
            Console.WriteLine();
            double angka;
            double angka0;
            int keluar = 0;
            Console.Write("Nilai/Angka: ");
            angka = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("=====================");
                Console.WriteLine("       Pilihan       ");
                Console.WriteLine("=====================");
                Console.WriteLine("1. Tambah");
                Console.WriteLine("2. Tampil");
                Console.WriteLine("3. Edit");
                Console.WriteLine("4. Hapus");
                Console.WriteLine("5. Keluar");
                Console.Write("Pilihan: ");
                Console.WriteLine();
                int pilihan = Convert.ToInt32(Console.ReadLine());
                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("Tambah");
                        Console.Write($"{angka} + ");
                        angka0 = Convert.ToDouble(Console.ReadLine());
                        angka = angka + angka0;
                        Console.WriteLine($"Nilai/Angka: {angka}");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Tampil");
                        Console.WriteLine($"Nilai/Angka: {angka}");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Edit");
                        Console.Write("Masukkan Nilai/Angka Baru: ");
                        angka = Convert.ToDouble(Console.ReadLine());
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Hapus");
                        Console.Write("Wait");
                        Thread.Sleep(350);
                        Console.Write(".");
                        Thread.Sleep(350);
                        Console.Write("..");
                        Thread.Sleep(350);
                        Console.Write("...");
                        angka = 0;
                        Console.WriteLine();
                        Console.WriteLine($"Nilai Telah Dihapus! {angka}");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Keluar");
                        Console.WriteLine("Tekan Enter untuk Keluar...");
                        keluar = 1;
                        Console.ReadLine();
                        break;
                }
                if (keluar == 1)
                {
                    break;
                }
                else if (keluar == 0)
                {
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}
