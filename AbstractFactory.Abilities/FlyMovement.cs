namespace AbstractFactory
{
    public class FlyMovement : Movement
    {
        public override void Move(string name)
        {
            System.Console.WriteLine($"{name} is flying");
        }
    }
}