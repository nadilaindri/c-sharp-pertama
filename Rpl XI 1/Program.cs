using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rpl_XI_1
{
    class Program
    {
   static void Main(string[] args)
        {
        string warna;
        Console.Write("Masukkan warna:");
        warna = Console.ReadLine();
        if (warna == "merah" || warna == "merah")
        {
            Console.Write("\nWarna yang diinput adalah warna merah");
        }
        else if (warna == "biru")
        {
            Console.Write("\nWarna yang diinput adalah warna biru");
        }
        else
        {
            Console.Write("\nWarna yang diinput bukan warna merah dan biru");
        }
        Console.Read();




        }
    }
}
