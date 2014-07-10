using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "hello";
            string b = "goodbye";
            string c = b;

            b = string.Concat(a);

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = "+ b);
            Console.WriteLine("c = " + c);

        }
    }
}
