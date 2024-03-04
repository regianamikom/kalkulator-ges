using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kakulator";
            //int a= 10; //declarasi variabel a, dengan nilai awal 10;
            //int b= 5; ///declarasi variabel b, dengan nilai awal 5;

            /*Console.WriteLine("input nilai a=");
            int a = int.Parse(Console.ReadLine()); // proses casting

            Console.WriteLine("input nilai a=");
            int b = int.Parse(Console.ReadLine()); // proses casting


            Console.WriteLine("Hasil penjumlahan " + a + " + " + b + " = " + penjumlahan(a, b));
            Console.WriteLine("Hasil pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
            Console.WriteLine("Hasil perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
            Console.WriteLine("Hasil pembagian {0} - {1} = {2}", a, b, pembagian(a, b));
            */

            Console.WriteLine("pilihan menu Caculator");
            Console.WriteLine("1. penambahan \n2. pengurangan \n3. perkalian \n4. pembagian");
            Console.WriteLine("input nomor menu [1..4]=");
      
            Console.ReadKey();
        }
        static int penjumlahan(int a, int b)
        {
            return a + b;
        }
       static int pengurangan(int a, int b) 
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;   
        }
        static int pembagian(int a, int b)
        {
            return a / b;   
        }
    }
}
