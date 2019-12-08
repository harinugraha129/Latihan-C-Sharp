using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menghitung Luas Segitiga");
            Console.Write("masukan Alas nya : ");
            int alas = int.Parse(Console.ReadLine());
            double koma;
            koma = 0.5;
            Console.Write("masukan tinggi nya : ");
            int tinggi = int.Parse(Console.ReadLine());
           
            double hasil = alas * tinggi * koma;


            Console.Write("Luas Segitiga adalah ");
            Console.WriteLine(hasil);
          

            Console.ReadLine();
        }
    }
}
