using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    internal class Program
    {
        static public int Maximum(int a, int b)
        {
            if (a > b)
                return a;
            return b;
        }

        static public int Minimum(int a, int b)
        {
            if (a < b)
                return a;
            return b;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine((a+b)/2);
            Console.WriteLine(Maximum(Math.Abs(a),Math.Abs(b)) - Minimum(Math.Abs(a), Math.Abs(b)));
            Console.WriteLine(Math.Round((Convert.ToDouble(a) / Convert.ToDouble(b)), 2));
        }
    }
}
