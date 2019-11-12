using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Clinton Carter
namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBox tb = new TextBox();
            tb.BackColor = ConsoleColor.Blue;
            tb.ForeColor = ConsoleColor.DarkRed;
            tb.Text = "I'm not a fan of classes right now!";
            tb.Padding = 1;
            tb.DisplayText();

            TextBox tb1 = new TextBox();
            tb1.BackColor = ConsoleColor.DarkGreen;
            tb1.ForeColor = ConsoleColor.DarkYellow;
            tb1.Text = "What is this shiz";
            tb1.Padding = 3;
            tb1.DisplayText();

            Console.ReadKey();
        }
    }
}
