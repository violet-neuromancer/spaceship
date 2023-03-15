using Settings.Scriptables;

namespace Model
{
    public class Weapon
    {
        private int _shootDuration;
        private int _damage;
        
        public int ShootDuration => _shootDuration;
        public int Damage => _damage;

        public Weapon(WeaponSettings settings)
        {
            _shootDuration = settings.ShootDuration;
            _damage = settings.Damage;
        }
    }
}