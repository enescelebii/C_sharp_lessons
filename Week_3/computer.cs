using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3
{
    internal class computer
    {
        private string processor { get; set; }
        private int speed { get; set; }

        public override string ToString()
        {
            return Convert.ToString(speed) + " " + processor;
        }
        public computer(int speed, string processor)
        {
            this.speed = speed;
            this.processor = processor;
        }
    }
}
