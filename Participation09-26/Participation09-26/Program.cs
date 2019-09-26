using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation09_26
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.Write($"Your course are { courseName[0]} { courseNumber[0]}  { courseName[1]} { courseNumber[1]}  { courseName[2]} {courseNumber[2]}");

            Console.ReadKey();
        }
    }
}
