using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void MathDelegate(int a, int b);

namespace lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathDelegate del;
            del = (a, b) => Console.WriteLine(a + b);
            del += (a, b) => Console.WriteLine(a - b);
            del += (a, b) => Console.WriteLine(a * b);
            del(10, 3);

            Console.ReadLine();
        }
    }
}
