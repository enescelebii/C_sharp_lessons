using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            int[] temp = list;
            Console.WriteLine("ordinal Array:");

            foreach (int i in list)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
            Array.Reverse(list);
            Console.WriteLine("Reversed Array: ");
            foreach (int i in list)
            {
                Console.WriteLine(i + " ");
            }
            Array.Sort(list);
            Console.WriteLine("Sorted array: ");
            foreach(int i in list)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
