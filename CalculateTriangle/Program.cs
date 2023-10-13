using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type;
            int[] f = new int[2];
            int[] s = new int[2];
            int[] t = new int[2];
            (type, f, s, t) = Triangle.GoTriangle("1000", "1000", "1000");
            Console.WriteLine(type + " " + f[0] + " " + f[1] + s[0] + " " + s[1] + t[0] + " " + t[1]);
            Console.ReadKey();
        }
    }
}
