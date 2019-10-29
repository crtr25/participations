using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Clinton";
            Student myStudent = new Student(); // this calls that method inside student.cs.
            myStudent.setName(myName);
            myStudent.setID(5);

            Student myStudent1 = new Student();



            Console.WriteLine(myStudent.getName());
            Console.ReadKey();
        }
    }
}
