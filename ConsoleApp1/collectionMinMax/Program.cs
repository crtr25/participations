using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ask the user to enter all of their exam grades.  Once they are done,
             calculate the minimum score, the maximum score and the average score for
             all of their scores.  Perform this using a Loop and not any built in
             functions.
           EXTRA:
           Calculate the Mode of the exam scores.
           */
            /*Console.WriteLine("Enter an exam grade.");
            string examGradesAS = Console.ReadLine();
            double examGrades = Convert.ToDouble(examGradesAS);
            grades.Add(examGrades);
            Console.WriteLine("Do you have another exam grade you want to enter? Yes or No?");
            string answer = Console.ReadLine().ToLower();*/
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
            double maxhold = 0 ;
            double sum = 0;
            foreach (double gr in grades)
            {
                if ( gr < minhold)
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
    }
}
