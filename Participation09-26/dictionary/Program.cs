using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Create a dictionary that will hold multiple values.  
                The key will be the course code (e.g. MIS3013, MIS3383, etc.) and the 
                values will be all of the students final grades (e.g. 0.95, 0.8, etc.). 
                Add at least 3 courses codes and at least 3 grades in each one. 
                Calculate the average for each course code and output it to the user, 
                make sure to format it as a 

                If you have time, convert #3 to getting input from the user and making 
                sure the key doesn't exist prior to adding it
                */

            Dictionary<string, List<double>> CourseCode = new Dictionary<string, List<double>>();
            CourseCode.Add("MIS3013", new List<double> { 0.10, 0.65, 0.95 });
          
            CourseCode.Add("MIS2113", 0.99, 0.89, 0.72);

            CourseCode.Add("MGT4113", 0.91, 0.95, 0.10);

            double sum = 0, average = 0;
            foreach (string item in CourseCode.Keys)
            {

                
            }





        }
    }
}
