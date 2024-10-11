using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3
{
    internal class Program
    {
        class car
        {
            private int speed { get; set; }


            public override string ToString()
            {
                return Convert.ToString(speed);
            }

            public car(int speed)
            {
                this.speed = speed;
            }

           
        }
        static void Main(string[] args)
        {
            computer bilgisayar = new computer(100, "intel");
            car araba = new car(400);
            Console.WriteLine(araba.ToString());
            Console.WriteLine(bilgisayar.ToString());
            Console.ReadLine();
        }
    }
}
