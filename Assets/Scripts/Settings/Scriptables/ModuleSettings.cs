using Settings.Enums;
using UnityEngine;

namespace Settings.Scriptables
{
    [CreateAssetMenu(menuName = "SpaceshipSettings/New Module Settings", fileName = "NewModuleSettings")]
    public class ModuleSettings : ComponentSettings
    {
        public string StatName;
        public ValueType ValueType;
        public int Value;
    }
}