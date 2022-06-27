using System;

namespace ConsoleApp1
{
    class Programm
    {
        static void Main()
        {
            Owl owl = new Owl("Сашко", 13, 80, 200);
            Dog dog = new Dog("Шарiк", 7, 30);
            owl.MakeSound();
            dog.MakeSound();
            owl.ShowHeight();
            owl.ShowSpeed();
            dog.ShowSpeed();
        }
    }


}