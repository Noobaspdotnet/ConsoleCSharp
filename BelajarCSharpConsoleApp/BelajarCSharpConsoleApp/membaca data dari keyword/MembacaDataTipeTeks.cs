using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarCSharpConsoleApp.membaca_data_dari_keyword
{
    class MembacaDataTipeTeks
    {
        static void Main(string[] args)
        {
            string nama;

            Console.Write("masukan nama anda :");
            nama = Console.ReadLine();

            Console.WriteLine("Hallo " + nama + ", selamat datang di tutorial pemrogaman C#");

            Console.ReadLine();
        }
    }
}
