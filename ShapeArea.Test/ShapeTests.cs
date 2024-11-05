using ShapeArea;

namespace ShapeArea.Test;

[TestClass]
public class ShapeTests
{
    [TestMethod]
    public void CircleAreaTest()
    {
        var circle = new Circle(5);
        Assert.AreEqual(Math.PI * 25, circle.GetArea(), 0.0001);
    }

    [TestMethod]
    public void TriangleAreaTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.AreEqual(6, triangle.GetArea(), 0.0001);
    }

    [TestMethod]
    public void TriangleIsValidationTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.IsTrue(triangle.IsValidation());
    }

    [TestMethod]
    public void RightTriangleTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.IsTrue(triangle.IsRightTriangle());
    }
}
