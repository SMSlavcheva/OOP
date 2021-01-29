using System;

namespace Triangle
{
    public class Program
    {
        //Create a class Triangle that has fields for its three sides and methods for calculating the Area and the Perimeter.
        //Create a custom Exception NonATriangleException exception that will be thrown when calculating the area or the 
        //perimeter methods are called. In your main method handle the exception like prompting the user for entering a valid Triangle.
        //The program should loop until the user enters a valid triangle and then prints out its Area an Perimeter​
        public static void Main(string[] args)
        {

           while (true)
            {
                try
                {
                    Console.WriteLine("Enter triangle sides: ");
                    var a = double.Parse(Console.ReadLine());
                    var b = double.Parse(Console.ReadLine());
                    var c = double.Parse(Console.ReadLine());

                    if (a <= 0)
                    {
                        throw new NonATriangleException();
                    }
                    else if (b <= 0)
                    {
                        throw new NonATriangleException();
                    }

                    else if (c <= 0)
                    {
                        throw new NonATriangleException();                       

                    }

                    else 
                    {
                        var triangle = new Triangle(a, b, c);
                        var p = triangle.CalculatePerimeter(a, b, c);
                        var s = triangle.CalculateSurface(a, b, c);

                        Console.WriteLine($"Triangle Perimeter is:{p}");
                        Console.WriteLine($"Triangle Surface is:{s}");
                        break;
                    }
                }

                catch (NonATriangleException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
        }
    }
}
