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
            int result;

            /*takes in users first number*/
            Console.WriteLine("Enter your first number");
            numOne = Convert.ToInt32(Console.ReadLine());

            /* specify the type of operation */
            Console.WriteLine("Enter operation type ( + , - , * , / ) ");
            operation = Console.ReadLine();

            /*takes in users second number*/
            Console.WriteLine("Enter your second number");
            numTwo = Convert.ToInt32(Console.ReadLine());

           

             //add nums 
            if (operation == "+")
            {
                result = numOne + numTwo;
                Console.WriteLine( numOne + " + " +  numTwo + " = " + result);

            }

            //subtracts num 
            else if (operation == "-")
            {
                result = numOne - numTwo;
                Console.WriteLine( numOne + " - " + numTwo + " = " + result);

            }
            //multiply nums
            else if (operation == "*")
            {
                result = numOne * numTwo;
                Console.WriteLine(numOne + " * " + numTwo + " = " + result);

            }
            //divide nums
            else if (operation == "/")
            {
                result = numOne / numTwo;
                Console.WriteLine(numOne + " / " + numTwo + " = " + result);

            }
            //result of improper operation
            else
            {
                Console.WriteLine("That is the incorrect format. Try again");
                Console.ReadLine();
            }
;        }
    }
}
