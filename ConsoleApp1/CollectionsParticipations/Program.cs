using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsParticipations
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create parallel arrays, one will have the course subject(e.g.MIS, MATH, etc.) and the other will hold 
             course numbers(e.g. 3033, 3013, etc.).
              Ask the user to input 3 for each, store them in the array.Then use a different loop to output the 
              results to the user concatenated together(e.g.MIS3033, MATH3013).

            Create a list that will hold all of the users grades.Keep prompting the user if they have another grade to
            enter until they say 'no'.Once you have all of the inputs, 
              use a for each loop to iterate through the list and calculate the average.Output the users grade average.

            Create a dictionary that will hold multiple values.The key will be the course code(e.g.MIS3013, MIS3383, 
            etc.) and the values will be all of the students final grades(e.g. 0.95, 0.8, etc.).
            Add at least 3 courses codes and at least 3 grades in each one.Calculate the average for each course
            code and output it to the user, make sure to format it as a
            If you have time, convert #3 to getting input from the user and making sure the key doesn't exist prior 
            to adding it
            */




            //array
            //creating dictionary
            
            string[] courseName = new string[3];
            int[] courseNumber = new int[3];
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Input a course subject (ex: MIS). >>");
                courseName[i] = Console.ReadLine().ToUpper();


                Console.WriteLine("Input that course number. >>");
                courseNumber[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.Write($"Your course are { courseName[0]} { courseNumber[0]}  { courseName[1]} { courseNumber[1]}  { courseName[2]} {courseNumber[2]}" );

            Console.ReadKey();
            




        }
    }
}
