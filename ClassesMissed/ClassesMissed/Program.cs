using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMissed
{
    class Program
    {
        static void Main(string[] args)
        {
            ToyBox tb = new ToyBox();

            Toy toy1 = new Toy();
            toy1.Manufaacturer = "Hasbro";
            toy1.Name = "Some dog thing";
            toy1.Price = 29.99;

            Toy toy2 = new Toy();
            toy2.Manufaacturer = "Hasbro";
            toy2.Name = "Life";
            toy2.Price = 15.99;

            tb.Toys.Add(toy1);
            tb.Toys.Add(toy2);
            Console.WriteLine("About to enter the loop");
            foreach (var toy in tb.Toys)
            {
                Console.WriteLine("Made it to the loop");
                Console.WriteLine(toy.ToString()  );
            }
            Console.WriteLine("Passed the loop");
            Console.ReadKey();
        }
    }
}
