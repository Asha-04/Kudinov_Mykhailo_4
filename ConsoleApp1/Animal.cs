namespace ConsoleApp1;

public class Animal
{
    public string Name;
    public int Age;
    public int Speed;

    public Animal(string name, int age, int speed)
    {
        Name = name;
        Age = age;
        Speed = speed;
    }

    public void ShowSpeed()
    {
        Console.WriteLine($"швидскiсть {Name} - {Speed} " );
    }
}