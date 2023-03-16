using Settings.Ship;

namespace Game.Model
{
    public class Ship
    {
        private string _id;
        private float _health;
        private float _shield;
        private float _shieldRegenPerSec;
        private Weapon[] _weapons;
        private Module[] _modules;

        public string Id => _id;
        public float Health
        {
            get => _health;
            set => _health = value;
        }

        public float Shield
        {
            get => _shield;
            set => _shield = value;
        }

        public float ShieldRegenPerSec
        {
            get => _shieldRegenPerSec;
            set => _shieldRegenPerSec = value;
        }

        public Weapon[] Weapons => _weapons;
        public Module[] Modules => _modules;

        public Ship(ShipSettings settings)
        {
            _id = settings.Id;
            _health = settings.Health;
            _shield = settings.Shield;
            _shieldRegenPerSec = settings.ShieldRegenPerSec;
            _weapons = new Weapon[settings.WeaponSlotsCount];
            _modules = new Module[settings.ModuleSlotsCount];
        }
    }
}