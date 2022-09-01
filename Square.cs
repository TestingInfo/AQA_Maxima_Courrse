namespace Figure;

public class Square : Figure
{
    public Square(int sideA)
    {
        this.sideA = sideA;
    }

    public void GetArea() // метод расчёта площади
    {
        Console.WriteLine("Площадь квадрата " + sideA * sideA);
    }
}