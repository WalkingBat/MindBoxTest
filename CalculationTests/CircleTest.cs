using Xunit;
using FigLib;

namespace CalculationTests;

public class CircleTest
{
    [Fact]
    public void Test1()
    {
        //исходные данные
        double radius = 5;
        double expected = 78.5398163397;

        //получение значения с помощью тестируемого метода
        Shape circle = new Circle(radius);
        double actual = circle.CircleArea();

        //сравнение ожидаемого результата с полученным
        Assert.AreEqual(expected, actual);
    }
}