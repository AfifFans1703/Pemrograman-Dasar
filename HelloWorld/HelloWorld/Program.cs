using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Praktik 1
            // Nama : Muhammad Afifansyah Setiawan
            // Kelas : X PPLG 2
            // Membuat project console
            Console.WriteLine("== Membuat project Console ==");
            Console.WriteLine();
            Console.WriteLine("Hello, World");
            Console.WriteLine("PPLG");
            Console.WriteLine();

            // Praktik 2
            // Nama : Muhammad Afifansyah Setiawan
            // Kelas : X PPLG 2
            // Perbedaan Write dan WriteLine
            Console.WriteLine("== Perbedaan Write dan WriteLine");
            Console.WriteLine();
            Console.WriteLine("= Write =");
            Console.Write("Hello");
            Console.Write("Hai");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("= WriteLine =");
            Console.WriteLine("Halow");
            Console.WriteLine("Dunia");
            Console.WriteLine();

            // Praktik 3
            // Nama : Muhammad Afifansyah Setiawan
            // Kelas : X PPLG 2
            // Membuat dan memanggil variabel
            Console.WriteLine("== Membuat dan memanggil variabel ==");
            Console.WriteLine();
            string nama = "Muhammad Afifansyah Setiawan";
            int umur = 15;
            double tinggi = 169.75;
            char kelas = 'X';
            bool aktif = true;
            Console.WriteLine("Nama : " + nama);
            Console.WriteLine("Umur : " + umur + " tahun");
            Console.WriteLine("Tinggi : " + tinggi + " cm");
            Console.WriteLine("Kelas : " + kelas);
            Console.WriteLine("Aktif : " + aktif);
            Console.WriteLine();

            // Praktik 4
            // Nama : Muhammad Afifansyah Setiawan
            // Kelas : X PPLG 2
            // Input dan nama variabel
            Console.WriteLine("== Input dan nama variabel ==");
            Console.Write("Masukkan nama Anda: ");
            string nama0 = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Masukkan umur : ");
            int umur0 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("====== DATA SISWA ======");
            Console.WriteLine();
            Console.WriteLine("Nama : " + nama0);
            Console.WriteLine("Umur : " + umur0 + " tahun");
            Thread.Sleep(1000);
            Console.WriteLine();

            // Praktik 5
            // Nama : Muhammad Afifansyah Setiawan
            // Kelas : X PPLG 2
            // Program biodata sederhana
            Console.WriteLine("== Program biodata sederhana ==");
            Console.WriteLine();
            Console.Write("Nama Lengkap : ");
            string nama1 = Console.ReadLine();
            Console.Write("Absen : ");
            int absen = int.Parse(Console.ReadLine());
            Console.Write("Umur : ");
            int umur1 = int.Parse(Console.ReadLine());
            Console.Write("Kelas (X, XI, atau XII) :");
            string kelas0 = Console.ReadLine();
            Console.Write("Jurusan : ");
            string jurusan = Console.ReadLine();
            Console.Write("Kelas ke : ");
            int kelasKe = int.Parse(Console.ReadLine());
            Console.Write("Sekolah : ");
            string sekolah = Console.ReadLine();

            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine("===== Identitas Siswa =====");
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine("Nama : "+ nama1);
            Thread.Sleep(500);
            Console.WriteLine("Umur : "+ umur);
            Thread.Sleep(500);
            Console.WriteLine("Absen : "+ absen);
            Thread.Sleep(500);
            Console.WriteLine("Kelas : "+ kelas0 + jurusan + kelasKe);
            Thread.Sleep(500);
            Console.WriteLine("Sekolah : "+ sekolah);
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("Program seleai");
            Console.WriteLine();
        }
    }
}
