namespace SolidLessons.OCP.Bad;

public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double CalculateArea()
    {
        return Width * Height;
    }
}