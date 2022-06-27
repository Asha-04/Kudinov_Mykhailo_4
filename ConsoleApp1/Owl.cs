namespace ConsoleApp1;

public class Owl:Bird,ISound
{
    public Owl(string name, int age, int speed, int height) : base(name, age, speed, height)
    {
        
    }

    public void MakeSound()
    {
        Console.WriteLine("у-у-ху");
    }
}