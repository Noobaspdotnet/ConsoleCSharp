using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembacaDataKarakter
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            string d;

            Console.Write("Masukan Karakter :");
            d = Console.ReadLine();

            //konversi dari tipestring ke karakter
            if (char.TryParse(d, out c))
            {
                Console.WriteLine("Karakter yang di masukan adalah '" + c + "'");
            }
            else
            {
                Console.WriteLine("data yang anda masukan " + "tidak dapat di konversi" + "ke tipe karakter");
            }
            Console.ReadLine();
        }
    }
}
