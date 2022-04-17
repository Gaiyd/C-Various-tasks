using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class ShapesLINQ
    {

    public String NameOfShape { get; set; }
    public double Area { get; set; }
    public double Perimeter { get; set; }

    }
    public class LINQ
    {

        static void Main()
        {
            

            string[] scores = TextFileProcessor.Read("shapes.txt");
            Shape[] shapes = new Shape[scores.Length];

            var output = new List<ShapesLINQ>();
            List<ShapesLINQ> list = new List<ShapesLINQ>();

            for (int i = 0; i < scores.Length; i++)
            {
                string phrase = scores[i];
                string[] words = phrase.Split(",");
                if (words[0].Equals("Rectangle"))
                {
                    shapes[i] = Rectangle.Parse(scores[i]);
                    
                    output.Add(new ShapesLINQ { NameOfShape = "Rectangle", Area = shapes[i].GetArea(), Perimeter = shapes[i].GetPerimeter() });

                }
                else
                {
                    shapes[i] = Circle.Parse(scores[i]);
                    output.Add(new ShapesLINQ { NameOfShape = "Circle", Area = shapes[i].GetArea(), Perimeter = shapes[i].GetPerimeter() });
                }
                
            }
            var output1 = output.OrderBy(x => x.NameOfShape).ThenBy(x => x.Area).ToList();
            var output2 = output.OrderBy(x => x.Perimeter).ToList();

            foreach (var ShapesLINQ in output2)
            {
                Console.WriteLine($"Type: { ShapesLINQ.NameOfShape }    Area: { ShapesLINQ.Area }   Perimeter: { ShapesLINQ.Perimeter }");
            }

            Console.WriteLine();

            var outputrec = output.Where(x => x.NameOfShape == "Rectangle").ToList();
            double avgperirec = outputrec.Average(x => x.Perimeter);
            double avarearec = outputrec.Average(x => x.Area);
            Console.WriteLine("RECTANGLES: Average Perimeter is " + avgperirec + " Average Area " + avarearec );

            Console.WriteLine();

            var outputcirc = output.Where(x => x.NameOfShape == "Circle").ToList();
            double avgpericirc = outputcirc.Average(x => x.Perimeter);
            double avareacirc = outputcirc.Average(x => x.Area);
            Console.WriteLine("CIRCLES: Average Perimeter is " + avgpericirc + " Average Area " + avareacirc);

            Console.WriteLine();

            double avgperi = output.Average(x => x.Perimeter);
            double avarea = output.Average(x => x.Area);
            int count = output.Count();
            Console.WriteLine("Average Perimeter is "+ avgperi+" Average Area "+ avarea+" Total count of shapes " + count);


        }
    }
}
