using System;
using System.IO;

namespace ShapesApplication
{
    public class TestShapes
    {
        public static void Main(string[] args)
        {
            int rerunProgram = 0;

            do
            {
                double width = 0;
                double height = 0;
                double sides = 0;

                //Display different options for shapes
                Console.WriteLine("From the list below, type in the number that corresponds with your desired shape: ");
                Console.WriteLine("\tCircle:    1");
                Console.WriteLine("\tSquare:    2");
                Console.WriteLine("\tTriangle:  3");
                Console.WriteLine("\tRectangle: 4");
                Console.WriteLine("\tPentagon:  5");
                Console.WriteLine("\tHexagon:   6");
                Console.WriteLine("\tHeptagon:  7");
                Console.WriteLine("\tOctagon:   8");
                Console.WriteLine("\tNonagon:   9");
                Console.WriteLine("\tDecagon:   10");

                try
                {
                    //Select which shape the user wants to build
                    Console.Write("Enter number: ");
                    int shapeNumber = Convert.ToInt16(Console.ReadLine());
                    if (shapeNumber < 1 || shapeNumber > 10) //restart program if user number is outside allowable range
                        throw new IOException("You entered number outside of valid range. Try again.");
                    Console.Write("Please enter color of shape: "); //prompt user for color of shape
                    string color = Console.ReadLine();

                    switch (shapeNumber)
                    {
                        case 1: //start building circle
                            Console.Write("Please enter the radius for your circle: ");
                            double radius = Convert.ToDouble(Console.ReadLine());
                            if (radius <= 0)
                                throw new IOException("You entered invalid radius. Try again.");
                            Circle circle = new Circle("Circle", color, radius);
                            Console.WriteLine(circle); //print out meaningful description of circle object
                            break;
                        case 2: //start building square
                            Console.Write("Please enter width for your square: ");
                            width = Convert.ToDouble(Console.ReadLine());
                            if (width <= 0)
                                throw new IOException("You entered invalid width. Try again.");
                            Square square = new Square("Square", color, width, width);
                            Console.WriteLine(square); //print out meaningful description of square object
                            break;
                        case 3: //start building triangle
                            Console.Write("Please enter base for your triangle: ");
                            double baseCalculation = Convert.ToDouble(Console.ReadLine());
                            if (baseCalculation <= 0)
                                throw new IOException("You entered invalid base. Try again.");
                            Console.Write("Please enter height for your triangle: ");
                            height = Convert.ToDouble(Console.ReadLine());
                            if (height <= 0)
                                throw new IOException("You entered invalid height. Try again.");
                            Console.Write("Please enter the length of side 1 for your triangle: ");
                            double side1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Please enter the length of side 2 for your triangle: ");
                            double side2 = Convert.ToDouble(Console.ReadLine());
                            if (side1 + side2 <= baseCalculation || side1 + baseCalculation <= side2 || side2 + baseCalculation <= side1)
                                throw new IOException("You entered invalid sides. Try again."); //throw exception if sides indicate invalid triangle
                            Triangle triangle = new Triangle("Triangle", color, baseCalculation, height, side1, side2);
                            Console.WriteLine(triangle); //print out meaningful description of triangle object
                            break;
                        case 4: //start building rectangle
                            Console.Write("Please enter width for your rectangle: ");
                            width = Convert.ToDouble(Console.ReadLine());
                            if (width <= 0)
                                throw new IOException("You entered invalid width. Try again.");
                            Console.Write("Please enter height for your rectangle: ");
                            height = Convert.ToDouble(Console.ReadLine());
                            if (height <= 0)
                                throw new IOException("You entered invalid height. Try again.");
                            if (width == height)
                                throw new IOException("The width and height of your rectangle are the same, meaning it would be a square instead. Try again.");
                            Rectangle rectangle = new Rectangle("Rectangle", color, width, height);
                            Console.WriteLine(rectangle); //print out meaningful description of rectangle object
                            break;
                        case 5: //start building pentagon
                            Console.Write("Please enter the length of sides for your pentagon: ");
                            sides = Convert.ToDouble(Console.ReadLine());
                            if (sides <= 0)
                                throw new IOException("You entered invalid side. Try again.");
                            Pentagon pentagon = new Pentagon("Pentagon", color, sides);
                            Console.WriteLine(pentagon); //print out meaningful description of pentagon object
                            break;
                        case 6: //start building hexagon
                            Console.Write("Please enter the length of sides for your hexagon: ");
                            sides = Convert.ToDouble(Console.ReadLine());
                            if (sides <= 0)
                                throw new IOException("You entered invalid side. Try again.");
                            Hexagon hexagon = new Hexagon("Hexagon", color, sides);
                            Console.WriteLine(hexagon); //print out meaningful description of hexagon object
                            break;
                        case 7: //start building heptagon
                            Console.Write("Please enter the length of sides for your heptagon: ");
                            sides = Convert.ToDouble(Console.ReadLine());
                            if (sides <= 0)
                                throw new IOException("You entered invalid side. Try again.");
                            Heptagon heptagon = new Heptagon("Heptagon", color, sides);
                            Console.WriteLine(heptagon); //print out meaningful description of heptagon object
                            break;
                        case 8: //start building octagon
                            Console.Write("Please enter the length of sides for your octagon: ");
                            sides = Convert.ToDouble(Console.ReadLine());
                            if (sides <= 0)
                                throw new IOException("You entered invalid side. Try again.");
                            Octagon octagon = new Octagon("Octagon", color, sides);
                            Console.WriteLine(octagon); //print out meaningful description of octagon object
                            break;
                        case 9: //start building nonagon
                            Console.Write("Please enter the length of sides for your nonagon: ");
                            sides = Convert.ToDouble(Console.ReadLine());
                            if (sides <= 0)
                                throw new IOException("You entered invalid side. Try again.");
                            Nonagon nonagon = new Nonagon("Nonagon", color, sides);
                            Console.WriteLine(nonagon); //print out meaningful description of nonagon object
                            break;
                        case 10: //start building decagon
                            Console.Write("Please enter the length of sides for your decagon: ");
                            sides = Convert.ToDouble(Console.ReadLine());
                            if (sides <= 0)
                                throw new IOException("You entered invalid side. Try again.");
                            Decagon decagon = new Decagon("Decagon", color, sides);
                            Console.WriteLine(decagon); //print out meaningful description of decagon object
                            break;
                    }

                    Console.Write("Enter 0 to rerun program or 1 to quit program: "); //rerun program or not
                    rerunProgram = Convert.ToInt16(Console.ReadLine());
                    if (rerunProgram != 0 && rerunProgram != 1)
                    {
                        rerunProgram = 0;
                        throw new IOException("You entered invalid input. Program is automatically restarted.");
                    }
                }

                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch (FormatException ex)
                {
                    Console.WriteLine("You entered invalid input. Try again.");
                }

                catch (OutOfMemoryException ex)
                {
                    Console.WriteLine("You entered value without enough memory available. Try again.");
                }

            } while (rerunProgram == 0);
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
        private double radius;

        public Circle(string newName, string newColor, double newRadius) : base(newName, newColor)
        {
            radius = newRadius;
        }

        private double Area()
        {
            return (radius * radius) * Math.PI;
        }

        private double Circumference()
        {
            return (radius * 2) * Math.PI;
        }

        public override string ToString()
        {
            return name + ":\n\tColor:\t\t" + color + "\n\tRadius:\t\t" + radius + "\n\tArea:\t\t" + Area() + "\n\tCircumference:\t" + Circumference();
        }
    }

    public class Square : Shapes
    {
        private double width;
        private double height;

        public Square(string newName, string newColor, double newWidth, double newHeight) : base(newName, newColor)
        {
            width = newWidth;
            height = newHeight;
        }

        protected double Area()
        {
            return width * height;
        }

        protected double Perimeter()
        {
            return (width * 2) + (height * 2);
        }

        public override string ToString()
        {
            return name + ":\n\tColor:\t\t" + color + "\n\tWidth:\t\t" + width + "\n\tHeight:\t\t" + height + "\n\tArea:\t\t" + Area() + "\n\tPerimeter:\t" + Perimeter();
        }
    }

    public class Rectangle : Square
    {
        public Rectangle(string newName, string newColor, double newWidth, double newHeight) : base(newName, newColor, newWidth, newHeight)
        {
        }
    }

    public class Triangle : Shapes
    {
        private double baseCalculation;
        private double height;
        private double side1;
        private double side2;

        public Triangle(string newName, string newColor, double newBaseCalculation, double newHeight, double newSide1, double newSide2) : base(newName, newColor)
        {
            baseCalculation = newBaseCalculation;
            height = newHeight;
            side1 = newSide1;
            side2 = newSide2;
        }

        private double Area()
        {
            return (baseCalculation * height) / 2;
        }

        private double Perimeter()
        {
            return side1 + side2 + baseCalculation;
        }

        private string TypeTriangle()
        {
            if ((side1 == side2 && side1 != baseCalculation) || (side1 == baseCalculation && side1 != side2) || (side2 == baseCalculation && side2 != side1))
                return "Triangle: \tIsosceles";
            else if (side1 == side2 && side1 == baseCalculation)
                return "Triangle: \tEquilateral";
            else
                return "Triangle: \tScalene";
        }

        public override string ToString()
        {
            return name + ":\n\tColor:\t\t" + color + "\n\t" + TypeTriangle() + "\n\tBase:\t\t" + baseCalculation + "\n\tHeight:\t\t" + height + "\n\tSide 1:\t\t" + side1 + "\n\tSide 2:\t\t" + side2 + "\n\tArea:\t\t" + Area() + "\n\tPerimeter:\t" + Perimeter();
        }
    }

    public class Pentagon : Shapes
    {
        private double sides;

        public Pentagon (string newName, string newColor, double newSides) : base(newName, newColor)
        {
            sides = newSides;
        }

        private double Area()
        {
            return (.25) * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(sides, 2);
        }

        private double Perimeter()
        {
            return sides * 5;
        }

        public override string ToString()
        {
            return name + ":\n\tColor:\t\t" + color + "\n\tSides:\t\t" + sides + "\n\tArea:\t\t" + Area() + "\n\tPerimeter:\t" + Perimeter();
        }
    }

    public class Hexagon : Shapes
    {
        private double sides;

        public Hexagon(string newName, string newColor, double newSides) : base(newName, newColor)
        {
            sides = newSides;
        }

        private double Area()
        {
            return ((3 * Math.Sqrt(3)) / 2) * Math.Pow(sides, 2);
        }

        private double Perimeter()
        {
            return sides * 6;
        }

        public override string ToString()
        {
            return name + ":\n\tColor:\t\t" + color + "\n\tSides:\t\t" + sides + "\n\tArea:\t\t" + Area() + "\n\tPerimeter:\t" + Perimeter();
        }
    }

    public class Heptagon : Shapes
    {
        private double sides;

        public Heptagon(string newName, string newColor, double newSides) : base(newName, newColor)
        {
            sides = newSides;
        }

        private double Area()
        {
            return (.25) * 7 * Math.Pow(sides, 2) * (1 / Math.Tan(Math.PI / 7));
        }

        private double Perimeter()
        {
            return sides * 7;
        }

        public override string ToString()
        {
            return name + ":\n\tColor:\t\t" + color + "\n\tSides:\t\t" + sides + "\n\tArea:\t\t" + Area() + "\n\tPerimeter:\t" + Perimeter();
        }
    }

    public class Octagon : Shapes
    {
        private double sides;

        public Octagon(string newName, string newColor, double newSides) : base(newName, newColor)
        {
            sides = newSides;
        }

        private double Area()
        {
            return 2 * (1 + Math.Sqrt(2)) * Math.Pow(sides, 2);
        }

        private double Perimeter()
        {
            return sides * 8;
        }

        public override string ToString()
        {
            return name + ":\n\tColor:\t\t" + color + "\n\tSides:\t\t" + sides + "\n\tArea:\t\t" + Area() + "\n\tPerimeter:\t" + Perimeter();
        }
    }

    public class Nonagon : Shapes
    {
        private double sides;

        public Nonagon(string newName, string newColor, double newSides) : base(newName, newColor)
        {
            sides = newSides;
        }

        private double Area()
        {
            return (.25) * 9 * Math.Pow(sides, 2) * (1 / Math.Tan(Math.PI / 9));
        }

        private double Perimeter()
        {
            return sides * 9;
        }

        public override string ToString()
        {
            return name + ":\n\tColor:\t\t" + color + "\n\tSides:\t\t" + sides + "\n\tArea:\t\t" + Area() + "\n\tPerimeter:\t" + Perimeter();
        }
    }

    public class Decagon : Shapes
    {
        private double sides;

        public Decagon(string newName, string newColor, double newSides) : base(newName, newColor)
        {
            sides = newSides;
        }

        private double Area()
        {
            return (.25) * 10 * Math.Pow(sides, 2) * (Math.Sqrt(5 + (2 * Math.Sqrt(5))));
        }

        private double Perimeter()
        {
            return sides * 10;
        }

        public override string ToString()
        {
            return name + ":\n\tColor:\t\t" + color + "\n\tSides:\t\t" + sides + "\n\tArea:\t\t" + Area() + "\n\tPerimeter:\t" + Perimeter();
        }
    }
}
    
