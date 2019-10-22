using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
To start your application, call your DeveloperInformation method, passing in appropriate values. 
Your application should prompt the user for  what type of calculation they want to perform and two values.  
You should use the appropriate method to perform the calculation and output the result IN YOUR MAIN METHOD. 
Ask the user if they would like to perform a new calculation, or use the result of their previous calculation as the first
value in a follow-up calculation, or if they will wish to stop.  If they say a new calculation you will need to re-prompt
them for all of their information again.  If they indicate using the result, you will need to get another value from the 
user and what type of operation they want to perform on it.  If they say they are done or wish to stop, you just need 
to thank them for using your service and end your application.

Create the following methods:
Add 
The add method should accept two parameters, both of type double, and should have a return type of double.
The add method should add the first parameter by the second parameter (e.g. val1 + val2) and return the result

Subtract 
The subtract method should accept two parameters, both of type double, and should have a return type of double.
The subtract method should subtract the first parameter by the second parameter (e.g. val1 - val2) and return the result

Multiply 
The multiply method should accept two parameters, both of type double, and should have a return type of double.
The multiply method should multiply the first parameter by the second parameter (e.g. val1 * val2) and return the result

Divide 
The divide method should accept two parameters, both of type double, and should have a return type of double.
The divide method should divide the first parameter by the second parameter (e.g. val1 / val2) and return the result

DeveloperInformation 
The DeveloperInformation method should accept three parameters, a string for the developers name, a string for the class name, and a string for the date of writing.  The method should have a return type of void..
The DeveloperInformation method should use the three parameters to output a string on the console describing who wrote the application, for what class, and on what date
             */
             /*
            double r = Add(5, 5); // Add sends the code to that function to run and returns that value. Assign a new variable for it.
            double divide = Divide(5.5, 7.5);
            */

            DeveloperInformation("Clinton Carter", "MIS-3013", "10/22/2019");
            double operand1, operand2, result;
            string answer = "";
            do
            {
                Console.WriteLine("What function do you want to perfrom? (+, -, *, /)");
                string operation = Console.ReadLine();
                if (answer == "R")
                {
                    operand1 = result;
                }
                else
                {
                    Console.WriteLine("What is the first operand?");
                    operand1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("What is the second operand?");
                    operand2 = Convert.ToDouble(Console.ReadLine());
                }

                 result = 0;
                if (operation == "+")
                {
                    result = Add(operand1, operand2);
                }
                else if (operation == "-")
                {
                    result = Subtract(operand1, operand2);
                }
                else if (operation == "*")
                {
                    result = Multiply(operand1, operand2);
                }
                else if (operation == "/")
                {
                    result = Divide(operand1, operand2);
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                }

                Console.WriteLine($"{operand1.ToString("N0")} {operation} {operand2.ToString("N0")} = {result.ToString("N0")}");
                Console.WriteLine("Do you want to perform a new calculation (N), new with result as first operand (R) or Exit (E)?");
                answer = Console.ReadLine();
            } while (answer.ToLower() != "e");

                Console.ReadKey();
          
        }
            static double Add(double val1, double val2)
            {
            double sum = val1 + val2;
            return sum;
            }
        static double Subtract(double val1, double val2)
        {
            double result = val1 - val2;
            return result;
        }
        static double Multiply(double val1, double val2)
        {
            double result = val1 * val2;
            return result;
        }
        static double Divide(double val1, double val2)
        {
            throw new NotImplementedException();
            if (val2 == 0)
            {
                return 0;
            }
            else
            {
                double result = val1 / val2;
                return result;
            }
        }
        static void DeveloperInformation(string devName, string className, string date)
        {

            Console.WriteLine($"Created by: {devName} for {className} on {date}");
        }
    }
}

