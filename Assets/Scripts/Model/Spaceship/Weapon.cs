namespace Model.Spaceship
{
    public class Weapon : IComponent
    {
        private int _shootDuration;
        private int _damage;

        public Weapon(int shootDuration, int damage)
        {
            _shootDuration = shootDuration;
            _damage = damage;
        }
    }
}