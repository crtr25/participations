using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //creating dictionary
            Dictionary<int, double> studentGrades = new Dictionary<int, double>();
            studentGrades.Add(1, 3.5);
            studentGrades.Add(2, 3.0);
            studentGrades.Add(3, 4.0);

            Console.Write("Please pick a student id to see their gpa: ");

            foreach (var studentId in studentGrades.Keys)
            {
                Console.Write(studentId +" ");
            }
            Console.WriteLine();
            //converting to int
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The student with id {userInput} has a GPA of {studentGrades[userInput]}");

            //use conditional to check to see if the input is in the dictionary
            if (studentGrades.ContainsKey(userInput) == ) //no need to say true 
            {
                Console.WriteLine($"The student with id {userInput} has a GPA of {studentGrades[userInput]}");

            }
            else
            {
                Console.WriteLine("Sorry you entered an invalid ID. Goodbye!");
            }


            Console.ReadKey();
      
        }
    }
}
