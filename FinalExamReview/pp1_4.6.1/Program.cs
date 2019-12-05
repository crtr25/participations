using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp1_4._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string loop;
            do
            {   //variables

                double addition = 0;
                double subtraction = 0;
                double multiplication = 0;
                double LeftPower = 0;
                double RightPower = 0;


                Equation eq = new Equation();

                Console.WriteLine("Pick your first number.");
                eq.Left = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Pick your second number");
                eq.Right = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Would you like to add, subtract, multiply, exponent?");
                string choice = Console.ReadLine().ToLower();





                if (choice == "add")
                {
                    addition = eq.Add();
                    Console.WriteLine(addition);
                }
                else if (choice == "subtract")
                {
                    subtraction = eq.Subtract();
                    Console.WriteLine(subtraction);

                }
                else if (choice == "multiply")
                {
                    multiplication = eq.Multiply();
                    Console.WriteLine(multiplication);

                }
                else if (choice == "exponent")
                {
                    Console.WriteLine("Which number do you want to assign a power too? first or second?");
                    string number = Console.ReadLine().ToLower();
                    Console.WriteLine("To what power do you want to raise that number too? Pick a number.");
                    int exp = Convert.ToInt16(Console.ReadLine());

                    if (number == "first")
                    {
                        LeftPower = eq.LeftToThePower(exp);
                        Console.WriteLine(LeftPower);

                    }
                    else if (number == "second")
                    {
                        RightPower = eq.RightToThePower(exp);
                        Console.WriteLine(RightPower);

                    }

                }
                Console.WriteLine("Do you want to create an equation? Y or N");
                loop = Console.ReadLine().ToLower();
            } while (loop == "y");












            Console.ReadKey();
        }
    }
}
