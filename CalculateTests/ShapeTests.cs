using Calculate;

namespace CalculateTests;

public class ShapeTests
{
    [Fact]
    public void Circle_Area_Correct()
    {
        var circle = new Circle(5);
        double area = circle.CalculateArea();
        Assert.Equal(78.5398, area, 4); 
    }

    [Fact]
    public void Triangle_Area_Correct()
    {
        var triangle = new Triangle(3, 4, 5);
        double area = triangle.CalculateArea();
        Assert.Equal(6, area, 4); 
    }

    [Fact]
    public void Triangle_IsRightAngled_True()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightAngled()); 
    }

    [Fact]
    public void Triangle_IsRightAngled_False()
    {
        var triangle = new Triangle(3, 4, 6);
        Assert.False(triangle.IsRightAngled()); 
    }

    [Fact]
    public void ShapeAreaCalculator_CalculateArea_Circle()
    {
        IShape shape = new Circle(5);
        double area = ShapeAreaCalculator.CalculateArea(shape);
        Assert.Equal(78.5398, area, 4);
    }

    [Fact]
    public void ShapeAreaCalculator_CalculateArea_Triangle()
    {
        IShape shape = new Triangle(3, 4, 5);
        double area = ShapeAreaCalculator.CalculateArea(shape);
        Assert.Equal(6, area, 4);
    }
}