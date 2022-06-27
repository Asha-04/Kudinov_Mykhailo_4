namespace ConsoleApp1;

public class Bird:Animal
{
    public int Height;
    public Bird(string name, int age, int speed, int height) : base(name, age, speed)
    {
        Height = height;
    }
    public void ShowHeight()
    {
        Console.WriteLine($"висота {Name} - {Height} " );
    }
}