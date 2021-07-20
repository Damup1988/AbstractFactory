namespace AbstractFactory
{
    public class Sword : Weapon
    {
        public override void Hit(string name)
        {
            System.Console.WriteLine($"{name} doing slice and dice!");
        }
    }
}