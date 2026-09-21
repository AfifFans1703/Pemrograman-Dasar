using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorMatematika
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("           Operator Matematika          ");
                Console.WriteLine("========================================");
                Console.WriteLine();
                Console.WriteLine("=== Tekan Tombol Untuk Menghitung Luas Bangun Datar ===");
                Console.WriteLine("A. Lingkaran");
                Console.WriteLine("B. Persegi Panjang");
                Console.WriteLine("C. Persegi");
                Console.WriteLine("D. Segitiga Sama Sisi");
                Console.WriteLine("E. Keluar Program");
                ConsoleKeyInfo input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.A)
                {
                    Console.Clear();
                    const float Phi = 3.14f;
                    Console.WriteLine("==============================");
                    Console.WriteLine("  Penghitung Luas Lingkaran   ");
                    Console.WriteLine("==============================");

                    Console.WriteLine();

                    Console.Write("jari-jari : ");

                    int r = int.Parse(Console.ReadLine());
                    float L = Phi * r * r;
                    Console.WriteLine($"L Lingkaran = {L}");

                    Console.WriteLine();
                    Console.Write("Ulangi? : (Y/N) ");
                    string jawaban = Console.ReadLine()?.Trim().ToLower();
                    if (jawaban == "y" || jawaban == "ya" || jawaban == "yes")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (input.Key == ConsoleKey.B)
                {
                    Console.Clear();
                    Console.WriteLine("===============================");
                    Console.WriteLine("Penghitung Luas Persegi Panjang");
                    Console.WriteLine("===============================");

                    Console.WriteLine();

                    Console.Write("Panjang : ");
                    double p = double.Parse(Console.ReadLine());

                    Console.Write("Lebar : ");
                    double l = double.Parse(Console.ReadLine());

                    double L = p * l;
                    Console.WriteLine($"Luas Persegi Panjang = {L}");

                    Console.WriteLine();
                    Console.Write("Ulangi? : (Y/N) ");
                    string jawaban = Console.ReadLine()?.Trim().ToLower();
                    if (jawaban == "y" || jawaban == "ya" || jawaban == "yes")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (input.Key == ConsoleKey.C)
                {
                    Console.Clear();
                    Console.WriteLine("==============================");
                    Console.WriteLine("   Penghitung Luas Persegi    ");
                    Console.WriteLine("==============================");

                    Console.WriteLine();

                    Console.Write("Panjang Sisi : ");
                    double s = double.Parse(Console.ReadLine());

                    double L = s * s;
                    Console.WriteLine($"Luas Persegi = {L}");

                    Console.WriteLine();
                    Console.Write("Ulangi? : (Y/N) ");
                    string jawaban = Console.ReadLine()?.Trim().ToLower();
                    if (jawaban == "y" || jawaban == "ya" || jawaban == "yes")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (input.Key == ConsoleKey.D)
                {
                    Console.Clear();
                    Console.WriteLine("==================================");
                    Console.WriteLine("Penghitung Luas Segitiga Sama Sisi");
                    Console.WriteLine("==================================");

                    Console.WriteLine();

                    Console.Write("Panjang Sisi : ");
                    double s = double.Parse(Console.ReadLine());

                    double L = (Math.Sqrt(3) / 4) * Math.Pow(s, 2);
                    Console.WriteLine($"Luas Segitiga Sama Sisi = {L}");

                    Console.WriteLine();
                    Console.Write("Ulangi? : (Y/N) ");
                    string jawaban = Console.ReadLine()?.Trim().ToLower();
                    if (jawaban == "y" || jawaban == "ya" || jawaban == "yes")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (input.Key == ConsoleKey.E)
                {
                    break;
                }
            }
        }
    }
}
