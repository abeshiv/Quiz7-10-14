using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(100);
            myFunc(number);


        }
        public static void myFunc(int number)
        {
            Console.WriteLine(number);
            

            if (number % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
                    Console.ReadLine();
        }
    }
}
