using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesMidterm
{
    // Create 3 subclasses of Shape: Triange, Circle and Square
    public abstract class Shape
    {
            class Triangle : Shape
           {
              public double Area()
             {
                double s1, s2, s3, totalarea, c;
                Console.WriteLine("Please enter the side1: ");
                s1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the side2: ");
                s2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the side3: ");
                s3 = double.Parse(Console.ReadLine());
                totalarea = (s1 + s2 + s3) / 3;
                c = Math.Sqrt((c - s1) * (c - s2) * (c - s3));
                Console.WriteLine("Area is" + totalarea);
                Console.ReadLine();
            }
        }

        class Circle : Shape
        {
            public double Area()
            {
                Console.WriteLine("Please enter the radius: ");
                double radius = double.Parse(Console.ReadLine());
                double pi = Math.PI;
                double area = pi * (radius * radius);
                Console.WriteLine("The Area (A=πr2) of your circle is: ", area);
            }

            class Square : Shape
            {
                public double Area()
                {
                    double a, b, totalarea;
                    Console.WriteLine("Please enter the side: ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the length: ");
                    b = double.Parse(Console.ReadLine());
                    totalarea = Math.Sqrt(side * side);
                    Console.WriteLine("area is" + totalarea);
                    Console.ReadLine();
                }
            

                public abstract double Area { get; }

            // override the ToString() method in your shape subclasses
            public abstract override string ToString();
        }
    }
}
