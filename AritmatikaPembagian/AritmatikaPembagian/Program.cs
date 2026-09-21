using System;

namespace AritmatikaPembagian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mangga, orang, hasil = 0;

            Console.Write("jumlah mangga= ");
            mangga = int.Parse(Console.ReadLine());
            Console.Write("jumlah orang= ");
            orang = int.Parse(Console.ReadLine());

            hasil = mangga / orang;

            Console.WriteLine($"Hasil mangga / orang = {hasil}");
        }
    }
}
