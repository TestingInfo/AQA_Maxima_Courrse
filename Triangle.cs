namespace Figure;

public class Triangle : Figure
{
    public Triangle(int sideA, int sideB, int sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }
    public void GetArea() // метод расчёта площади
    {
        Console.WriteLine("Площадь треугольника " + (sideA * sideB * sideC) * 0.5);
    }
}