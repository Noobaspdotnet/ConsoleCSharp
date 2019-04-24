using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarCSharpConsoleApp.membaca_data_dari_keyword
{
    class MembacaDataTipeKarakter
    {
        static void main()
        {
            char c;
            string s;
            Console.Write("Masukan karakter :");
            s = Console.ReadLine();

            //konversi tipe string ke karakter
            if (char.TryParse(s, out c))
            {
                Console.WriteLine("karakter yang di masukan adalah : " + c + "'");

            }
            else
            {
                Console.WriteLine("data yang dimasukan " + "tidak dapat sikonversi" + "ke tipe karakter");
;            }
        }
    }
}
