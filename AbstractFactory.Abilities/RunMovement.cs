namespace AbstractFactory
{
    public class RunMovement : Movement
    {
        public override void Move()
        {
            System.Console.WriteLine("The hero is running");
        }
    }
}