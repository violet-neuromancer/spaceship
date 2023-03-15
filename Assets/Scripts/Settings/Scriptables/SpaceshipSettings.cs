using UnityEngine;

namespace Settings.Scriptables
{
    [CreateAssetMenu(menuName = "SpaceshipSettings/New Spaceship Settings", fileName = "NewSpaceshipSettings")]
    public class SpaceshipSettings : ScriptableObject
    {
        public Sprite Icon;
        public int Health;
        public int Shield;
        public int ShieldRegenPerSec;
        public int WeaponSlotsCount;
        public int ModuleSlotsCount;
    }
}