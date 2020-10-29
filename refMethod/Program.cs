using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geeg een getal in...");
            int a = Int32.Parse(Console.ReadLine());
            Sqr(ref a);
            Console.WriteLine(a);
        }
        static void Sqr(ref int x)
        {
            x = x * x;
        }
    }
}
