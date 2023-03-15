using UnityEngine;

namespace Settings.Scriptables
{
    [CreateAssetMenu(menuName = "SpaceshipSettings/New Weapon Settings", fileName = "NewWeaponSettings")]
    public class WeaponSettings : ComponentSettings
    {
        [SerializeField] private float _recharge;
        [SerializeField] private float _damage;

        public float Recharge => _recharge;
        public float Damage => _damage;
    }
}