using UnityEngine;

namespace Spaceship.Settings.Ship
{
    [CreateAssetMenu(menuName = "Spaceship/New Module Settings", fileName = "NewModuleSettings")]
    public class ModuleSettings : ComponentSettings
    {
        [SerializeField] private string _statName;
        [SerializeField] private ValueDef _valueDef;
        [SerializeField] private float _value;

        public string StatName => _statName;
        public ValueDef ValueDef => _valueDef;
        public float Value => _value;
    }
}