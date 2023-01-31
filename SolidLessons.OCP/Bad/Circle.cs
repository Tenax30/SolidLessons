namespace SolidLessons.OCP.Bad;

public class Circle
{
    public double Radius { get; set; }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}