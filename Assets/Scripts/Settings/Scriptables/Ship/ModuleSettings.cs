using Settings.Enums;
using UnityEngine;

namespace Settings.Scriptables.Ship
{
    [CreateAssetMenu(menuName = "ShipSettings/New Module Settings", fileName = "NewModuleSettings")]
    public class ModuleSettings : ComponentSettings
    {
        [SerializeField] private string _statName;
        [SerializeField] private ValueType _valueType;
        [SerializeField] private float _value;

        public string StatName => _statName;
        public ValueType ValueType => _valueType;
        public float Value => _value;
    }
}