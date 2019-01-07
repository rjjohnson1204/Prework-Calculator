using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcualtor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne;
            int numTwo;
            string operation;
            int answer;

            /*takes in users first number*/
            Console.WriteLine("Enter your first number");
            numOne = Convert.ToInt32(Console.ReadLine());

            /*takes in users second number*/
            Console.WriteLine("Enter your second number");
            numTwo = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter operation type ( + , - , * , / ) ");
            operation = Console.ReadLine();

            if (operation == "+")
            {
                answer = numOne + numTwo;
                Console.WriteLine( numOne + " + " +  numTwo + " = " + answer);

            }
            else if (operation == "-")
            {
                answer = numOne - numTwo;
                Console.WriteLine( numOne + " - " + numTwo + " = " + answer);

            }
            else if (operation == "*")
            {
                answer = numOne * numTwo;
                Console.WriteLine(numOne + " * " + numTwo + " = " + answer);

            }
            else if (operation == "/")
            {
                answer = numOne / numTwo;
                Console.WriteLine(numOne + " / " + numTwo + " = " + answer);

            }
            else
            {
                Console.WriteLine("That is the incorrect format. Try again");
                Console.ReadLine();
            }
;        }
    }
}
