using Settings.Enums;
using Settings.Scriptables;

namespace Model
{
    public class Spaceship
    {
        private string _id;
        private int _health;
        private int _shield;
        private int _shieldRegenPerSec;
        private Weapon[] _weapons;
        private Module[] _modules;

        public string Id => _id;
        public int Health => _health;
        public int Shield => _shield;
        public int ShieldRegenPerSec => _shieldRegenPerSec;
        public Weapon[] Weapons => _weapons;
        public Module[] Modules => _modules;

        public Spaceship(SpaceshipSettings settings)
        {
            _id = settings.Id;
            _health = settings.Health;
            _shield = settings.Shield;
            _shieldRegenPerSec = settings.ShieldRegenPerSec;
            _weapons = new Weapon[settings.WeaponSlotsCount];
            _modules = new Module[settings.ModuleSlotsCount];
        }

        public void ReplaceComponent(int index, ComponentSettings componentSettings)
        {
            if (componentSettings.Type == ComponentType.Module)
            {
                ReplaceModule(index, (ModuleSettings)componentSettings);
            }
            
            if (componentSettings.Type == ComponentType.Weapon)
            {
                ReplaceWeapon(index, (WeaponSettings)componentSettings);
            }
        }

        private void ReplaceModule(int index, ModuleSettings moduleSettings)
        {
            Modules[index] = new Module(moduleSettings);
        }

        private void ReplaceWeapon(int index, WeaponSettings weaponSettings)
        {
            Weapons[index] = new Weapon(weaponSettings);
        }
    }
}