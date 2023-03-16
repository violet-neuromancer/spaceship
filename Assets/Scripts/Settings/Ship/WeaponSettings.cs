using UnityEngine;

namespace Settings.Ship
{
    [CreateAssetMenu(menuName = "Spaceship/New Weapon Settings", fileName = "NewWeaponSettings")]
    public class WeaponSettings : ComponentSettings
    {
        [SerializeField] private float _recharge;
        [SerializeField] private float _damage;

        public float Recharge => _recharge;
        public float Damage => _damage;
    }
}