using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp1_4._6._1
{
    class Equation
    {
        public double Left { get; set; }
        public double Right { get; set; }

        public Equation()
        {
            Left = 0;
            Right = 0;
        }
        public Equation(double Left, double Right)
        {
            Left = 0;
            Right = 0;
        }
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
            double leftP = Math.Pow(Left, power);
            return leftP;

        }
        public double RightToThePower(int power)
        {
            double rightP = Math.Pow(Right, power);
            return rightP;
        }

    }
}
