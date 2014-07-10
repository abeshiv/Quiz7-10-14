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
            string[] four = { "g", "h", "i" };
            string[] five = { "j", "k", "l" };
            string[] six = { "m", "n", "o" };
            string[] seven = { "p", "q", "r", "s" };
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
                for (int j = 0; j < second.Length; j++)
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