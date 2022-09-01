namespace Figure;
//ctor снипет конструктора

public class Circle : Figure
{
    public Circle(int circumference)
    {
        this.circumference = circumference;
    }
    public void GetArea()
    {
        Console.WriteLine("Площадь круга " + (Math.Pow(circumference, 2)) / (4 * Math.PI));
    }
}