namespace ConsoleApp1;

public class Dog:Animal,ISound
{
    public Dog(string name, int age, int speed) : base(name, age, speed)
    {
        
    }

    public void MakeSound()
    {
        Console.WriteLine("гав");
    }
}