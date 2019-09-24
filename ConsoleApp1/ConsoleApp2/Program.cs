using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            // creating a new collection. [] means its a collection
            int[] studentIds = new int[3];
            studentIds[0] = 1;
            studentIds[1] = 2;
            studentIds[2] = 3;
          //we have 4 integers here so either must take one away or add another in the collection
            //double[] gpas = new double[3];
            double[] gpas = { 2.5, 3.1, 4.0 };//using 3 in both because they are paralell
                                              //also could do double[] gpas = {2.5,3.1,4.0}; Just defines the variables isntead of saying how many are in it
                                              //loop really good for collections. does everying a for statement does

            Console.WriteLine("Please pick an id from the list to see their gpa:");
            foreach (int id in studentIds)
            {
                Console.Write(" " + id);
            }
            Console.WriteLine();
            int userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < studentIds.Length; i++)
            {//conditional statement
                if (studentIds[i] == userInput)
                {
                    Console.WriteLine($" The GPA for student with id {userInput} is {gpas[i]}");
                    break;
                }

            }




            Console.ReadKey();

        }
    }
}
