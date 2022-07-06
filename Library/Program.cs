using System;

namespace FigLib
{
    public class Shape
    {
        public double Area { get; set; }
        public virtual double TriangleArea()
        {
            return Area;
        }
        public virtual double CircleArea()
        {
            return Area;
        }
        public void DisplayInfoTriangle()
        {
            Console.WriteLine($"Площадь треугольника = {Math.Round(TriangleArea(), 3)}");
        }
        public void DisplayInfoCircle()
        {
            Console.WriteLine($"Площадь круга = {Math.Round(CircleArea(), 3)}");
        }
    }
}