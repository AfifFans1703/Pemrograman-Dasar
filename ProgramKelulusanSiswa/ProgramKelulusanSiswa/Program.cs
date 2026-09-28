using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramKelulusanSiswa
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Nama Siswa: ");
                string nama = Console.ReadLine();

                Console.Write("Nilai: ");
                int nilai = Convert.ToInt32(Console.ReadLine());

                if (nilai < 0 || nilai > 100)
                {
                    Console.WriteLine("Masukkan Tidak Valid");
                }
                else if (nilai >= 75)
                {
                    Console.WriteLine(nama + " Dinyatakan LULUS !!");
                }
                else
                {
                    Console.WriteLine(nama + " Dinyatakan WEROG !!");
                }
                Console.WriteLine();
                Console.Write("Ulangi...? ");
                Console.Write("Press Y to restart or press other key to close... ");
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
