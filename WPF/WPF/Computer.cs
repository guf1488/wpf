using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF
{
    public class Computer
    {
        public Computer(string m, string p, int mem)
        {
            Monitor = m;
            Processor = p;
            Memory = mem;
        }

        public string Monitor { get; set; }
        public string Processor { get; set; }
        public int Memory { get; set; }

    }
}
