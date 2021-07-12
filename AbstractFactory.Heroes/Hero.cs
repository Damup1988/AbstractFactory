namespace AbstractFactory
{
    public class Hero
    {
        private Weapon weapon;
        private Movement movement;
        private string _name;
        public string Name { get => _name; set { _name = value; } }

        public Hero(HerroFactory factory, string Name)
        {
            weapon = factory.CreateWeapon();
            movement = factory.CreateMovement();
            this.Name = Name;
        }

        public void Move()
        {
            movement.Move();
        }

        public void Hit()
        {
            weapon.Hit();
        }
    }
}