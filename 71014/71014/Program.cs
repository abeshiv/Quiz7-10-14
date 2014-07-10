using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71014
{
    class Program
    {
        static int myfunc(int x, int y)
        {
            Console.WriteLine(x * y);
            Console.ReadLine();
            return (x * y);
        }
        static void Main(string[] args)
        {
            int result =myfunc(2, 3);
        }
    }
}
