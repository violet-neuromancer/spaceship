using UnityEngine;

namespace Settings.Scriptables
{
    [CreateAssetMenu(menuName = "SpaceshipSettings/New Spaceship Settings", fileName = "NewSpaceshipSettings")]
    public class SpaceshipSettings : ScriptableObject
    {
        [SerializeField] private string _id;
        [SerializeField] private int _health;
        [SerializeField] private int _shield;
        [SerializeField] private int _shieldRegenPerSec;
        [SerializeField] private int _weaponSlotsCount;
        [SerializeField] private int _moduleSlotsCount;
        
        public string Id => _id;
        public int Health => _health;
        public int Shield => _shield;
        public int ShieldRegenPerSec => _shieldRegenPerSec;
        public int WeaponSlotsCount => _weaponSlotsCount;
        public int ModuleSlotsCount => _moduleSlotsCount;
    }
}