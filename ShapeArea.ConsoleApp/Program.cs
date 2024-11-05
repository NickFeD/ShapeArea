using ShapeArea;

namespace ShapeArea.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        IShape? shape = null;
        Console.WriteLine("Hello, World!");
        var read = Console.ReadLine();
        switch (read)
        {
            case "c":
                Console.WriteLine("Radius: ");
                var radius = double.Parse(Console.ReadLine());

                shape = new Circle(radius);
                break;

            case "t":
                Console.WriteLine("siteA: ");
                var siteA = double.Parse(Console.ReadLine());

                Console.WriteLine("siteC: ");
                var siteB = double.Parse(Console.ReadLine());

                Console.WriteLine("siteC: ");
                var siteC = double.Parse(Console.ReadLine());

                shape = new Triangle(siteA, siteB, siteC);
                break;
            default:
                break;
        }
        if (shape is not null)
        {
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }
}
