using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soloMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            Solo(a);
            Console.WriteLine(a);
        }
        static void Solo(int x)
        {
            x = x * x;
        }
    }
}
