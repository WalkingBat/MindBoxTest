using System;

namespace FigLib
{
    public class Triangle : Shape
    {
        public double sideA {get; set;}
        public double sideB {get; set;}
        public double sideC {get; set;}
        public Triangle(double a, double b, double c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
            if (sideA*sideA + sideB*sideB == sideC*sideC)
            {
                Console.WriteLine("Треугольник - прямоугольный!");
            }
            else if (sideA == sideB && sideA == sideC)
            {
                Console.WriteLine("Треугольник - равносторонний!");
            }
        }
        public override double TriangleArea()
        {
            double P = (sideA + sideB + sideC) / 2;
            double S = Math.Sqrt(P*(P - sideA)*(P - sideB) *(P - sideC));
            return S;
        }
        
    }
}