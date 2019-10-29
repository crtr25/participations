using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1
{
    class Rectangle
    {
      public double Length { get; set; }
      public double Width { get; set; }

        /// <summary>
        /// 
        /// Default onstructor for the rectangle setting all the values to 0
        /// </summary>

    public Rectangle()
        {
            Length = 0;
            Width = 0;

        }


        //doesnt have parameters
        public double CalculateArea()
        {
            double area = Length * Width;
            return area;
        }

        public double CalculatePerimeter()
        {
            
            return 2 * (Length + Width);
        }
      

    }
    
}
