using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingByOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            
            GeetValues(out x, out y);
            int z = x * y;
            Console.WriteLine(z);
        }
        static void GeetValues(out int a, out int b)
        {
            a = 8;
            b = 9;
        }
    }
}
