using Settings.Scriptables.Ship;

namespace Game.Model
{
    public class Weapon
    {
        private float _recharge;
        private float _damage;

        public float Recharge
        {
            get => _recharge;
            set => _recharge = value;
        }

        public float Damage => _damage;

        public Weapon(WeaponSettings settings)
        {
            _recharge = settings.Recharge;
            _damage = settings.Damage;
        }
    }
}