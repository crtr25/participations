using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMissed
{
    class Toy
    {
        public string Manufaacturer {get; set;}
        public string Name { get; set; }
        public double Price { get; set; }
        private string Aisle; //private doesn't need gets and sets
        private Random rand;

        public Toy()
        {
            // this is the constructor. get the instance of this class
            Manufaacturer = "";
            Name = "";
            Aisle = "";
            Price = 0;
            rand = new Random();
        }
        public string GetAisle()
        {
            int aisleNumber = rand.Next(1, 25);
            Aisle += Manufaacturer[0] + aisleNumber;
            // aisle = "" + Manufacturer[0] + aisleNumber;
            // string can't be mixed with doubles so must seperate them
            return Aisle;
        }



    }
}
