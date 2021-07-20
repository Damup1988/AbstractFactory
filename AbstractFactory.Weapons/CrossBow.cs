namespace AbstractFactory
{
    public class CrossBow : Weapon
    {
        public override void Hit(string name)
        {
            System.Console.WriteLine($"A bolt has been fired by {name}");
        }
    }
}