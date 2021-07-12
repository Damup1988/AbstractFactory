namespace AbstractFactory
{
    public class ArcherFactory : HerroFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new CrossBow();
        }
    }
}