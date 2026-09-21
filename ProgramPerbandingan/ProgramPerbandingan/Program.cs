using System;

namespace ProgramPerbandingan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mangga, apel = 0;

            Console.Write("jumlah mangga = ");
            mangga = int.Parse(Console.ReadLine());
            Console.Write("jumlah apel = ");
            apel = int.Parse(Console.ReadLine());

            Console.WriteLine("Hasil perbandingan: ");
            Console.WriteLine($"mangga > apel : {mangga > apel}");
            Console.WriteLine($"mangga >= apel : {mangga >= apel}");
            Console.WriteLine($"mangga < apel : {mangga < apel}");
            Console.WriteLine($"mangga <= apel : {mangga <= apel}");
            Console.WriteLine($"mangga == apel : {mangga == apel}");
            Console.WriteLine($"mangga != apel : {mangga != apel}");
        }
    }
}
