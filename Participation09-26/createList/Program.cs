using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a list that will hold all of the users grades. 
             Keep prompting the user if they have another grade to enter
             until they say 'no'.  Once you have all of the inputs, use a for
             each loop to iterate through the list and calculate the average. 
             Output the users grade average.
             */

            List<double> studentGrades = new List<double>();
            string answer;
            double sum = 0, gradeAverage = 0;

            do
            {
                Console.WriteLine("Enter a grade >>");
                studentGrades.Add(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("Do you want to enter another grade? >>" );
                answer = Console.ReadLine().ToLower();
            } while (answer != "no");
            {

            }
            foreach (double grade in studentGrades)
            {
                sum += grade;
                gradeAverage = sum / studentGrades.Count();
            }
            Console.WriteLine($"Your GradeAverage = { gradeAverage}");

            Console.ReadKey();
        }
    }
}
