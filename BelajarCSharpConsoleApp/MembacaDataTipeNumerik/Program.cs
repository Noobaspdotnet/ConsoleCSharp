using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembacaDataTipeNumerik
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int i;
            double d;

            //membaca data bilangan bulat
            Console.Write("masukkan bilangan bulat : ");
            input = Console.ReadLine();
            if (int.TryParse(input, out i))
            {
                Console.WriteLine("anda memasukkan bilangan : " + i);
            }
            else
            {
                Console.WriteLine("SALAH : " + "konversi ke integer gagal");
            }

            //membaca bilangan rill
            Console.Write("\nmasukkan bilangan bulat : ");
            input = Console.ReadLine();
            if (double.TryParse(input, out d))
            {
                Console.WriteLine("anda memasukkan bilangan : " + d);
            }
            else
            {
                Console.WriteLine("SALAH : " + "konversi ke double gagal");
            }
            Console.ReadLine();
        }
    }
}
