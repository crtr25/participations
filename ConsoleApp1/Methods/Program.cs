using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> favoriteThings = new List<string>();
            string answer;

       

            //loop
            do
            {
                Console.WriteLine("Please enter one of your favorite things >>");
                favoriteThings.Add(Console.ReadLine());

                Console.WriteLine("Do you have another favorite thing to add? Y/N >>");
                 answer = Console.ReadLine().ToUpper()[0] + ""; // "" to make the system think its a string or do .ToString
            }
            while (answer != "N");

            Random rand = new Random();
            int randomThing = rand.Next(0, favoriteThings.Count());
            Console.WriteLine($"Random thing {favoriteThings[randomThing]}");

            Console.ReadKey();
        }
    }
}
