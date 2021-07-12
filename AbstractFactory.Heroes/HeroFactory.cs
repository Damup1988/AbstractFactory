namespace AbstractFactory
{
    public abstract class HerroFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreateWeapon();
    }
}