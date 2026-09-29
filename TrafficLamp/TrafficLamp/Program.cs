using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrafficLamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("=========================================");
            Console.WriteLine("            Lampu Lalu Lintas            ");
            Console.WriteLine("=========================================");
            Console.WriteLine("-----------------------------------------");

            double waktum;
            double waktuh;
            double waktuk;
            double waktumerah;
            double waktuhijau;
            double waktukuning;
            Console.Write("Lama Lampu Merah: ");
            waktum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Lama Lampu Hijau: ");
            waktuh = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Lama Lampu Kuning: ");
            waktuk = Convert.ToDouble(Console.ReadLine());

            waktumerah = waktum * 1000;
            waktuhijau = waktum * 1000;
            waktukuning = waktum * 1000;

            
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Thread.Sleep(Convert.ToInt32(waktumerah));
                Console.WriteLine("Lampu MERAH");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Thread.Sleep(Convert.ToInt32(waktuhijau));
                Console.WriteLine("Lampu Hijau");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Thread.Sleep(Convert.ToInt32(waktukuning));
                Console.WriteLine("Lampu KUNING");
            }
        }
    }
}
