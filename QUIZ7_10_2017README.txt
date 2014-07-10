Van Abeshi, Quiz 7/10/14

/*
These files contain corrections to all the faulty programs given on the quiz on 7/10/2014, the corrections are as follows:


1) 
	Should state expected return as a type (int) rather than void.

2)
	The function will not return anything, as concat requires
string.concat(a, d) or a <type> followed by <concat>(parameters), and the parameters in this context need to be two different strings, not including the one first named in the equation.

Correct => "b = string.Concat(a, d)"
Current => "b = b.concat(a)

3)
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

4. All possible string combinations for 223 on a touch tone phone.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] two = { "a", "b", "c" };
            string[] three = { "d", "e", "f" };

            for (int i = 0; i < two.Length; i++)
            {
                for (int j = 0; j < two.Length; j++)
                {
                    for (int k = 0; k < three.Length; k++)
                    {
                        Console.WriteLine(two[i] + two[j] + three[k]); 
                    }
                }
            }
        }
    }
}


For any three digits:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] two = {"a", "b", "c"};
            string[] three = { "d", "e", "f" };
            string[] four = { "g", "h", "i" };
            string[] five = { "j", "k", "l" };
            string[] six = { "m", "n", "o" };
            string[] seven ={"p", "q", "r", "s"};
            string[] eight = { "t", "u", "v" };
            string[] nine = { "w", "x", "y", "z" };
            string[] first = two;
            string[] second = three;
            string[] third = four;

            Console.WriteLine("Enter the first digit: ");
            int input1 = int.Parse(Console.ReadLine());

            switch (input1)
            {

                case 2:
                    first = two;
                    break;

                case 3:
                    first = three;
                    break;

                case 4:
                    first = four;
                    break;

                case 5:
                    first = five;
                    break;

                case 6:
                    first = six;
                    break;

                case 7:
                    first = seven;
                    break;

                case 8:
                    first = eight;
                    break;

                case 9:
                    first = nine;
                    break;

                default:
                    Console.WriteLine("Unrecognized input");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }

            Console.WriteLine("Enter the second digit: ");
            int input2 = int.Parse(Console.ReadLine());

            switch (input2)
            {

                case 2:
                    second = two;
                    break;

                case 3:
                    second = three;
                    break;

                case 4:
                    second = four;
                    break;

                case 5:
                    second = five;
                    break;

                case 6:
                    second = six;
                    break;

                case 7:
                    second = seven;
                    break;

                case 8:
                    second = eight;
                    break;

                case 9:
                    second = nine;
                    break;

                default:
                    Console.WriteLine("Unrecognized input");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }

            Console.WriteLine("Enter the third digit: ");
            int input3 = int.Parse(Console.ReadLine());

            switch (input3)
            {

                case 2:
                    third = two;
                    break;

                case 3:
                    third = three;
                    break;

                case 4:
                    third = four;
                    break;

                case 5:
                    third = five;
                    break;

                case 6:
                    third = six;
                    break;

                case 7:
                    third = seven;
                    break;

                case 8:
                    third = eight;
                    break;

                case 9:
                    third = nine;
                    break;

                default:
                    Console.WriteLine("Unrecognized input");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }

            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j< second.Length; j++)
                {
                    for (int k = 0; k < third.Length; k++)
                    {
                        Console.WriteLine(first[i] + second[j] + third[k]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
*/