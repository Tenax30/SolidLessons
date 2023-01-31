namespace SolidLessons.OCP.Bad;

public class AreaCalculator
{
    public double CalculateShapeArea(object shape)
    {
        return shape switch
        {
            Circle circle => circle.CalculateArea(),
            Rectangle rectangle => rectangle.CalculateArea(),
            _ => throw new Exception("Unknown Shape")
        };
    }
}