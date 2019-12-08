using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Luas_Lingkaran
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menghitung Luas Lingkaran");
            Console.WriteLine();
            Console.Write("masukan Jari-jari nya : ");
            string jarix = Console.ReadLine();
            int jari = Convert.ToInt32(jarix);
            const float phi1=314;
            const float phi2=3142857;
            float phi;
            if (jari % 7 == 0)
                phi = phi2/1000000;
            else
                phi = phi1/100;

            float hasil = jari * jari * phi;
            float hasil2 = (jari + jari)* phi;
            Console.WriteLine("Luas Lingkaran = "+ hasil );
            Console.Write("Keliling Lingkaran = "+ hasil2 );
            Console.ReadLine();
        }
    }
}
