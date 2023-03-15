using UnityEngine;

namespace Settings.Scriptables
{
    [CreateAssetMenu(menuName = "SpaceshipSettings/New Weapon Settings", fileName = "NewWeaponSettings")]
    public class WeaponSettings : ComponentSettings
    {
        [SerializeField] private int _shootDuration;
        [SerializeField] private int _damage;

        public int ShootDuration => _shootDuration;
        public int Damage => _damage;
    }
}