using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Aisle { get; set; }
    
        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Aisle = "";

              
        }
        public string GetAisle()
        {

            for (int i = 0; i < Manufacturer.Length; i++)
            {
                i = 0;
                string manLetter = Manufacturer(i);
            }
            Random rand = new Random();
            double randomNumber = rand.Next(1, 25);

            return "" ;
        }
    }
}
