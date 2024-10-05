using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_homework
{
    internal class Program
    {

        public void Topla_Carp(int a, int b, out int add, out int mult) 
        { 
            add = a + b;
            mult = a * b;
        }
        static void Main(string[] args)
        {
            int a,b , topla , carp;
            
            Console.WriteLine("iki sayı giriniz\nA:");

            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sayıyı giriniz\nB:");
            b = Convert.ToInt32(Console.ReadLine());
            Program program = new Program();
            program.Topla_Carp(a,b,out topla, out carp);
            Console.WriteLine("Toplam: {0} , Çarpım: {1}",topla,carp);
            Console.ReadLine();
        }
    }
}
