using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public partial interface Shape
    {
        public void Print()
        {
         ToString();
        }
    }

    public partial class Rectangle
    {
        public static Rectangle Parse(string input)
        {
            string phrase = input;
            string[] words = phrase.Split(",");
            Rectangle output = new(double.Parse(words[1]), double.Parse(words[2]));
            return output;
        }
    }

    public partial class Circle
    {
        public static Circle Parse(string input)
        {
            string phrase = input;
            string[] words = phrase.Split(",");
            Circle output2 = new(double.Parse(words[1]));
            return output2;
        }
    }

}
