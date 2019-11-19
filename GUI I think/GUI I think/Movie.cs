using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_I_think
{
    class Movie
    {
      
        public int Id { get; set; }
        public int duration { get; set; }
        public int gross { get; set; }
        public string genres { get; set; }
        public string movie_title { get; set; }
        public string movie_imbd_link { get; set; }

        public override string ToString()
        {
            string sentence = Id + " | " +  duration + " | " + gross + " | " + genres + " | " + movie_title;
            return sentence;
        }

    }
}
