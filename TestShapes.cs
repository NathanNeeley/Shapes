using System;

namespace ShapesApplication
{
    public class TestShapes
    {
        public void static Main(string[] args)
        {
            Console.WriteLine("Please enter what type of shape you want to build: ");
            string shape = Console.ReadLine();
			Console.WriteLine("Please enter color of shape: ");
			string color = Console.ReadLine();
            switch (shape.ToLower())
            {
                case "circle":
					Console.WriteLine("Please enter the radius for your circle: ");
					double radius = Convert.ToDouble(Console.ReadLine());
					Circle circle = new Circle(shape, color, radius);
                    break;
				case "square":
					Console.WriteLine("Please enter width for your square: ");
					double width = Convert.ToDouble(Console.ReadLine());
					Square square = new Square(shape, color, width, width);
					break;
				case "rectangle":
					Console.WriteLine("Please enter width for your rectangle: ");
					double width = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Please enter height for your rectangle: ");
					double height = Convert.ToDouble(Console.ReadLine());
					Rectangle rectangle = new Rectangle(shape, color, width, height);
					break;
            }
        }
    }

    public class Shapes
    {
        protected string name;
		protected string color;

        public Shapes(string newName, string newColor)
        {
            name = newName;
            color = newColor;
        }
    }

    public class Circle : Shapes
    {
        public Circle(string newName, string newColor, double newRadius) : base(newName, newColor)
        {
        }

        public double Area()
        {
            return (radius * radius) * Math.PI;
        }

        public double Circumference()
        {
            return (radius * 2) * Math.PI;
        }

        public override string ToString()
        {
            return name + ":\n\t\tRadius:\t" + radius + "\n\t\tArea:\t" + Area() + "\n\t\tCircumference:\t" + Circumference();
        }
    }

	public class Square : Shapes
	{
		public Square(string newName, string newColor, double width, double height) : base(newName, newColor)
		{
		}

		public double Area()
		{
			return width * height;
		}

		public double Perimeter()
		{
			return (width * 2) + (height * 2);
		}

		public override string ToString()
		{
			return name + ":\n\t\tWidth:\t" + width + "\n\t\tHeight:\t" + height + "\n\t\tArea:\t" + Area() + "\n\t\tPerimeter:\t" + Perimeter();
		}
	}

	public class Rectangle : Square
	{
        public Rectangle(string newName, string newColor, double newWidth, double newHeight) : base(newName, newColor, newWidth, newHeight)
		{
		}
	}
}
