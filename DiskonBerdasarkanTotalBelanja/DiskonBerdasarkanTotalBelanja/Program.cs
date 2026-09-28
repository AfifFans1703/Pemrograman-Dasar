using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskonBerdasarkanTotalBelanja
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Total Belanja: ");
                double total = Convert.ToDouble(Console.ReadLine());

                double diskon;

                if (total >= 10000000)
                {
                    diskon = 0.15;
                }
                else if (total >= 1000000)
                {
                    diskon = 0.10;
                }
                else
                {
                    diskon = 0;
                }

                double potongan = total * diskon;
                double bayar = total - potongan;

                Console.WriteLine("Diskon : " + potongan);
                Console.WriteLine("Bayar : " + bayar);
                Console.WriteLine();
                Console.WriteLine("------------------------------");
                Console.WriteLine("==============================");
                Console.WriteLine("Terima Kasih Telah Berbelanja!");
                Console.WriteLine("==============================");
                Console.WriteLine("------------------------------");

                Console.ReadLine();
                Console.WriteLine();
                ConsoleKeyInfo input = Console.ReadKey();

                Console.Write("Ulangi...? ");
                Console.Write("Press Y key to restrat or press other key to close... ");
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
