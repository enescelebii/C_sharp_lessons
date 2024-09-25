using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1
{
    internal class Program
    {
        class Bread
        {
            public int counter;
        }

        static class Butter
        {
            public static int counter;
        }

        static void Main(string[] args)
        {
            Bread a = new Bread();
            a.counter = 1;
            Console.WriteLine(a.counter);
            Butter.counter = 8;
        }
    }
}
