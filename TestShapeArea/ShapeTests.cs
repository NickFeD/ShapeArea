using ShapeArea;

namespace TestShapeArea;

public class ShapeTests
{
    [Fact]
    public void CircleAreaTest()
    {
        var circle = new Circle(5);
        Assert.Equal(Math.PI * 25, circle.GetArea(), 4);
    }

    [Fact]
    public void TriangleAreaTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.Equal(6, triangle.GetArea(), 4);
    }
    [Fact]
    public void TriangleIsValidationTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsValidation());
    }

    [Fact]
    public void RightTriangleTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightTriangle());
    }
}
