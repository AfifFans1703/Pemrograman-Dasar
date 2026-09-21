using System;

namespace AritmatikaPerkalian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mangga, apel, hasil = 0;

            Console.Write("mangga = ");
            mangga = int.Parse(Console.ReadLine());
            Console.Write("apel = ");
            apel = int.Parse(Console.ReadLine());

            hasil = mangga * apel;

            Console.WriteLine($"Hasil mangga * apel = {hasil}");
        }
    }
}
