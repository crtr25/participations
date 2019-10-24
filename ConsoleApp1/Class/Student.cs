using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Student
    {
        private string name; // "-" = private, + == public, 
        private int id;

        public string city ( get; set; )
          

        public int getID()
        {

            return id;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setID(int newID)
        {
            id = newID;
        }
        public Student() //collector or constructor
        {
            id = 5;
            name = string.Empty; //""
        }

    }
}
