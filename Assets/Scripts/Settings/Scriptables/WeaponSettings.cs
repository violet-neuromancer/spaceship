using UnityEngine;

namespace Settings.Scriptables
{
    [CreateAssetMenu(menuName = "SpaceshipSettings/New Weapon Settings", fileName = "NewWeaponSettings")]
    public class WeaponSettings : ComponentSettings
    {
        public int ShootDuration;
        public int Damage;
    }
}