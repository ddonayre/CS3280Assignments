
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesMidterm
{
    // Create 3 subclasses of Shape: Triange, Circle and Square
    public abstract class Shape
    {
        public abstract double Area
        {
            get;
        }

        public abstract override string ToString();
    }

    /// <summary>
    /// /////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    /// 
    public class Triangle : Shape
    {
        public double height;
        public double width;
        private double _Area;
        override public double Area
        {
            get { return _Area; }
        }

        public Triangle(double triHeight, double triBase) : base()
        {
            height = triHeight;
            width = triBase;
            this._Area = 0.5 * triBase * triHeight;
        }
        public override string ToString()
        {
            return ($"Triangle: Height = {height} and Base = {width}");
        }
    }
    /// <summary>
    /// /////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    /// 
    public class Circle : Shape
    {
        
        public double radius;
        private double _Area;

        override public double Area
        {
            get { return _Area; }
        }
        public Circle(double radius)
        {
           this.radius = radius;
           double pi = Math.PI;
           this._Area = pi * (radius * radius);
        }

        public override string ToString()
        {
            return ($"Circle: Radius = {radius}");
        }

    }
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 
     public class Square : Shape
     {
         private double _Area;
         public double side;

         override public double Area
         {
              get { return _Area; }
         }
         public Square(double side)
         {
            this.side = side;
            this._Area = side * side;
         }

         public override string ToString()
         {
            return ($"Square: Side = {side}");
         }

                //public abstract double Area { get; }

                // override the ToString() method in your shape subclasses
                //            public abstract override string ToString();
     }
}

