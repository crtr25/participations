using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamReview
{
    class Equation
    {
        public double Left { get; set; }
        public double Right { get; set; }

        public Equation() { }
        public Equation(double Left, double Right) { }
        public double Add()
        {
            double adds = Left + Right;
            return adds;
        }
        public double Subtract()
        {
            double subs = Left - Right;
            return subs;
        }
        public double Multiply()
        {
            double mult = Left * Right;
            return mult;
        }
        public double LeftToThePower(int power)
        {
            double leftP = Math.Pow(Left,power);
            return leftP;
        }
        public double RightToThePower(int power)
        {
            double rightP = Math.Pow(Right, power);
            return rightP;
        }


    }
}
