using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class TextBox
    {
        public int Padding { get; set; }
        public ConsoleColor BackColor {get; set;}
        public ConsoleColor ForeColor { get; set;}
        public string Text { get; set; }

        public TextBox()
        {
            BackColor = 0;
            ForeColor = 0;
            Padding = 0;
            Text = "";

        }
        public void DisplayText()
        {
            Console.BackgroundColor = BackColor;
            Console.ForegroundColor = ForeColor;
  
            var newstr = Text.PadLeft(Padding + Text.Length).PadRight(Padding * 2 + Text.Length);
            Console.WriteLine($"{newstr}");
        }
    }
}
