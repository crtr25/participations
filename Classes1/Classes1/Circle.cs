using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1
{
    class Circle
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 0;
        }
        public double CalculateArea()
        {
            double area = Math.PI * (Radius * Radius);
            return area;
        }

        public double CalculatePerimeter()
        {

            return 2 * Math.PI * Radius;
        }
    }
}
