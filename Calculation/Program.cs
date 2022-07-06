using System;
using FigLib;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape figure = new Shape();

            Console.WriteLine("Введите стороны треугольника:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            Shape triangle = new Triangle(a, b, c);
            triangle.DisplayInfoTriangle();
            Console.WriteLine();

            Console.WriteLine("Введите радиус круга:");
            double r = Convert.ToDouble(Console.ReadLine());
            
            Shape circle = new Circle(r);
            circle.DisplayInfoCircle();
        }
    }
}