namespace Assignment4
{
    
    public partial interface Shape
    {
        string Name
        {
            set { }
            get { return this.GetType().Name; }
        }
        
        double GetPerimeter();
        double GetArea();
    }
    public partial class Rectangle : Shape
    {
        private double width;
        private double height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double GetPerimeter()
        {
            return 2 * (this.width + this.height);
        }
        public double GetArea()
        {
            return width * height;
        }
        string Name
        {
            set { }
            get { return this.GetType().Name; }
        }
        public override string ToString()
        {
            return Name + " Width : " + width +
            " Height : " + height + " , and its Area is " + GetArea();
        }
    }
    public partial class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Radius
        {
            set { value = this.radius; }
            get { return this.radius; }
        }
        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public string Name
        {
            set { }
            get { return this.GetType().Name; }
        }
        public override string ToString()
        {
            return this.Name + " Its radius : " + Radius + " , and its Area is " + GetArea() + ", and its perimeter is " + GetPerimeter();
        }
    }
    /*class Question3
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(4, 8);
            Console.WriteLine(rect);
            Circle circle = new Circle(4);
            Console.WriteLine(circle);

            string circlepars = Console.ReadLine();
            Console.WriteLine(Circle.Parse(circlepars));

            string recepars = Console.ReadLine();
            Console.WriteLine(Rectangle.Parse(recepars));
            Console.ReadKey();
        }
    }*/
}
