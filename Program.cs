using System;

namespace PRG2_20192_P1_4_02
{
    class Program
    {
        static void Main(string[] args)
        {
            float hipotenusa;
            
            Console.WriteLine("MENU SEGITIGA SIKU-SIKU");
            Console.WriteLine("1.Hitung Luas");
            Console.WriteLine("2.Hitung Hipotenusa");
            Console.WriteLine("3.Hitung Keliling");
            Console.WriteLine("4.Keluar");
            Console.Write("Menu Pilihan : ");
            int angka = Convert.ToInt16(Console.ReadLine());
            switch(angka)
            {
                case 1 :
                    {
                        
                        Console.WriteLine("Menghitung luas segitiga");
                        Console.Write("Masukan alas segitiga : ");
                        float alas = float.Parse(Console.ReadLine());
                        Console.Write("Masukan Tinggi segitiga : ");
                        float tinggi = float.Parse(Console.ReadLine());
                        float luas = alas * tinggi / 2;
                        Console.WriteLine("Luas Segitiga dengan alas {0} dan tinggi {1} adalah {2} cm ",alas,tinggi,luas );
                        System.Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Hipotenusa Segitiga");
                        Console.Write("Masukan alas segitiga : ");
                        float alas = float.Parse(Console.ReadLine());
                        Console.Write("Masukan Tinggi segitiga : ");
                        float tinggi = float.Parse(Console.ReadLine());
                        hipotenusa = (float)Convert.ToDouble(Math.Sqrt((alas * alas) + (tinggi * tinggi)));
                        Console.WriteLine("Hipotenusa dari segitiga dengan alas {0} dan tinggi {1} adalah {2} cm ",alas,tinggi,hipotenusa);
                        System.Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Menghitung Keliing segitiga");
                        Console.Write("Masukan alas segitiga : ");
                        float alas = float.Parse(Console.ReadLine());
                        Console.Write("Masukan Tinggi segitiga : ");
                        float tinggi = float.Parse(Console.ReadLine());
                        float keliling = hipotenusa = (float)Convert.ToDouble(Math.Sqrt((alas * alas) + (tinggi * tinggi))) + alas + tinggi;
                        Console.WriteLine("Keliling dari segitiga dengan alas {0} dan tinggi {1} adalah {2} cm ", alas, tinggi, keliling);
                        System.Console.ReadKey();
                        break;

                    }
                case 4:
                    {
                        Environment.Exit(0);
                        break;
                    }
            }
        }
    }
}
