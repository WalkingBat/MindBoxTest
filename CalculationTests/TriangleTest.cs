using Xunit;
using FigLib;

namespace CalculationTests;

public class TriangleTest
{
    [Fact]
    public void Test1()
    {
        //исходные данные
        double a = 7;
        double b = 8;
        double c = 9;
        double expected = 26.832;

        //получение значения с помощью тестируемого метода
        Shape triangle = new Triangle(a, b, c);
        double actual = triangle.TriangleArea();

        //сравнение ожидаемого результата с полученным
        Assert.AreEqual(expected, actual);
    }
}