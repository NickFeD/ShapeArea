namespace ShapeArea;

public class Triangle : IShape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double GetArea()
    {
        var p = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }
    public bool IsValidation()
    {
        if (SideA + SideB > SideC
        && SideB + SideC > SideA
        && SideC + SideA > SideB)
            return true;
        return false;
    }

    public bool IsRightTriangle()
    {
        var sides = new[] { SideA, SideB, SideC };
        Array.Sort(sides);
        return Math.Abs(Math.Pow(sides[2], 2) - Math.Pow(sides[0], 2) - Math.Pow(sides[1], 2)) < 0.000001;
    }
}
