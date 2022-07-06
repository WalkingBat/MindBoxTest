using System;

namespace FigLib
{
    public class Circle : Shape
    {
        public double radius {get; set;}
        public Circle(double r)
        {
            radius = r;
        }
        public override double CircleArea()
        {
            Area = Math.PI*Math.Pow(radius, 2);
            return Area;
        }
    }
}