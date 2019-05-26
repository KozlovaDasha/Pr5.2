using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr5
{
    class Program
    {
        static void Main(string[] args)
        {
            A First = new A(12, 34);
            A First1 = new A();
            B Second = new B(3, 1, 7);
            B Second2 = new B(3);
            Console.WriteLine(Second.C2);
            Console.WriteLine(Second2.C2);
            Console.ReadLine();
        }
    }
}
