using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodeParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double d1;
            double d2;

            //menggunakan metode parse
            Console.Write("masukkan bilangan bulat : ");
            input = Console.ReadLine();
            d1 = double.Parse(input);
                Console.WriteLine("anda memasukkan bilangan : " + d1);

            //menggunakan metode convert
            Console.Write("\nmasukkan bilangan bulat : ");
            input = Console.ReadLine();
            d2 = Convert.ToDouble(input);
            Console.WriteLine("anda memasukkan bilangan : " + d2);

            Console.ReadLine();
        }
    }
}
