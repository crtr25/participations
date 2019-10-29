using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation10_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What participation would you like to run? A or B");
            string choice = (Console.ReadLine().ToLower());
            string answer;
            if (choice == "a")
            {
                Problem1();
            }
            else if (choice == "b")
            {
                Problem2();
            }
        }

        static void Problem1()
        {
            List<Double> grades = new List<double>();
            string answer;
            do
            {
                Console.WriteLine("Enter an exam grade.");
                string examGradesAS = Console.ReadLine();
                double examGrades = Convert.ToDouble(examGradesAS);
                grades.Add(examGrades);
                Console.WriteLine("Do you have another exam grade you want to enter? Yes or No?");
                answer = Console.ReadLine().ToLower();
            } while (answer != "no");

            double minhold = 101;
            double maxhold = 0;
            double sum = 0;
            foreach (double gr in grades)
            {
                if (gr < minhold)
                {
                    minhold = gr;
                }
                if (gr > maxhold)
                {
                    maxhold = gr;
                }
                sum += gr;
            }
            double average = sum / grades.Count();


            //ouput
            Console.WriteLine($"Your min grade is {minhold}");
            Console.WriteLine($"Your max grade is {maxhold}");
            Console.WriteLine($"Your average exam grade is {average}");




            //output with built in functions
            /*
            Console.WriteLine($"Your lowest exam grade is {grades.Min()}");
            Console.WriteLine($"Your highest exam grade is {grades.Max()}");
            Console.WriteLine($"Your exam average is {grades.Average()}");
            */






            Console.ReadKey();
        }
        static void Problem2()
        {
            //Problem 1 - Add all #'s from 1 - 100
            int counter;
            int sum = 0;

            for (counter = 1; counter <= 100; counter++)
            {
                sum = sum + counter;
            }
            Console.WriteLine(sum);


            //Problem 2 - Ask the user if they want to iterate

            string answer = string.Empty;
            counter = 0;

            Console.WriteLine("Do you want to iterate again? >>");
            answer = Console.ReadLine().ToLower();
            //answer = answer.ToLower();

            while (answer.ToLower() != "no")
            {
                Console.WriteLine("Do you want to iterate again? >>");
                answer = Console.ReadLine().ToLower();
                counter++;
            }

            Console.WriteLine(counter);

            counter = 0;
            answer = string.Empty;

            do
            {
                Console.WriteLine("Do you want to iterate again? >>");
                answer = Console.ReadLine().ToLower();
                counter++;
            } while (answer.ToLower() != "no");
            counter--;

            Console.WriteLine(counter);

            Console.ReadKey();
        }
    }
}
