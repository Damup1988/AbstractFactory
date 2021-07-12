using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero damup = new Hero(new WarriorFactory(), "Damir");
            damup.Hit();
            damup.Move();

            Hero max = new Hero(new ArcherFactory(), "Maxim");
            max.Hit();
            max.Move();
        }
    }
}
