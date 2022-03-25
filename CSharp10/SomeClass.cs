//file scoped namespaces
namespace CSharp10Net6;

internal class SomeClass
{
    private void SomeFunc()
    {
        using (var writer = new StringWriter())
        {
            writer.WriteLine("...");
        }

        var writer1 = new StringWriter();
        writer1.WriteLine("...");
    }

    //record is a reference type
     public record Point2D(double X, double Y)
     {
     }

    //public record Point2D(double X, double Y);
    public record class Point3D(double X, double Y, double Z);

    //struct is a value type
    public record struct Point(double X, double Y, double Z);
    public readonly record struct Point1(double X, double Y, double Z);

}

