using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Console
{
    class Program
    {
        static void Main(string[] args)
        {

            //variables
            int n1 = 0;
            int n2 = 0;
            string input;
           // int sum;
           // int sub;
           // int mult;
           // int div;


            // Getting the numbers


            bool result = false;
            //Convert
            while (result == false)
            {
                Console.Write(" Please enter the first number...:");
                input = Console.ReadLine();
                result = int.TryParse(input, out n1);
                if (result == false)
                {
                    Console.WriteLine($"{input} is not a valid int");
                }
            }
            result = false;
            while (result == false)
            {

                Console.Write("Please enter the second number...:");
                input = Console.ReadLine();
                result = int.TryParse(input, out n2);
                if (result == false)
                {
                    Console.WriteLine($"{input} is not a valid int");
                }
            }

            Console.WriteLine($"{n1} + {n2} = {n1 + n2}");  // inside of curly is an expression (string interpolation)
            Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
            Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
            Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
            //Console.Read();

            // IF statements

            if (n1 < n2)
            {
                Console.WriteLine($"{n1} is less than {n2}");
            }
            else
            {
                Console.WriteLine($"{n1} is not less than {n2}");
            }

            if (n1 > n2)
            {
                Console.WriteLine($"{n1} is greater than {n2}");
            }
            else
            {
                Console.WriteLine($"{n1} is not greater than {n2}");
            }

            if (n1 != n2)
            {
                Console.WriteLine($"{n1} does not equal {n2}");
            }
            else
            {
                Console.WriteLine($"{n1} equals {n2} ");
            }
            Console.Read();
        }
    }
}
