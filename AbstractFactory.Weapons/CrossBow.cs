namespace AbstractFactory
{
    public class CrossBow : Weapon
    {
        public override void Hit()
        {
            System.Console.WriteLine($"A bolt has been fired");
        }
    }
}