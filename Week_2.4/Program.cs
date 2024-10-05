using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2._4
{
    internal class Program
    {
        public void swap(ref int x,ref int y)
        {

            x = x - y;
            y = y + x;
            x = y - x;
        }
        static void Main(string[] args)
        {
            Program n = new Program();

            int b = 100;
            int a = 200;

            //arkadaşlar

            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);

            n.swap(ref a,ref b);

            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);
            Console.ReadLine();
        }
    }
}
