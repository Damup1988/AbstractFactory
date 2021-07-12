namespace AbstractFactory
{
    public class FlyMovement : Movement
    {
        public override void Move()
        {
            System.Console.WriteLine("The hero is flying");
        }
    }
}