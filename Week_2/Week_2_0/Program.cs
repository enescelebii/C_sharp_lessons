using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            int i;
            for (i = 0; i < n.Length; i++)
            {
                n[i] = i + 100;
            }

            for (i = 0; i < n.Length; i++)
            {
                Console.WriteLine("Element [{0}] - {1}", i, n[i]);
            }
            Console.ReadKey();
        }
    }
}
