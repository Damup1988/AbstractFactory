namespace AbstractFactory
{
    public class Sword : Weapon
    {
        public override void Hit()
        {
            System.Console.WriteLine("Slice and dice!");
        }
    }
}