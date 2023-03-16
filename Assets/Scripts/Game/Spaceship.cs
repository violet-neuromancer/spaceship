using Settings.Enums;
using Settings.Scriptables;

namespace Game
{
    public class Spaceship
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

        public Spaceship(SpaceshipSettings settings)
        {
            _id = settings.Id;
            _health = settings.Health;
            _shield = settings.Shield;
            _shieldRegenPerSec = settings.ShieldRegenPerSec;
            _weapons = new Weapon[settings.WeaponSlotsCount];
            _modules = new Module[settings.ModuleSlotsCount];
        }

        public void ApplyModules()
        {
            foreach (var module in _modules)
            {
                switch (module.StatName)
                {
                    case "Health":
                        _health = module.ApplyModification(_health);
                        break;
                    case "Shield":
                        _shield = module.ApplyModification(_shield);
                        break;
                    case "ShieldRegenPerSec":
                        _shieldRegenPerSec = module.ApplyModification(_shieldRegenPerSec);
                        break;
                    case "Recharge":
                        foreach (var weapon in _weapons)
                        {
                            weapon.Recharge = module.ApplyModification(weapon.Recharge);
                        }

                        break;
                }
            }
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