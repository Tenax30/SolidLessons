namespace SolidLessons.DI.Bad;

public class Order
{
    public Guid Id { get; set; }
    public string Product { get; set; }
    public string Price { get; set; }
    public bool Completed { get; set; }
}