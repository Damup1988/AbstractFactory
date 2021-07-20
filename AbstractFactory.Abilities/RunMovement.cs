namespace AbstractFactory
{
    public class RunMovement : Movement
    {
        public override void Move(string name)
        {
            System.Console.WriteLine($"{name} is running");
        }
    }
}