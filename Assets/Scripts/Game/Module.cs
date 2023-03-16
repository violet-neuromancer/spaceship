using Settings.Enums;
using Settings.Scriptables;

namespace Game
{
    public class Module
    {
        private string _statName;
        private ValueType _valueType;
        private float _value;

        public string StatName => _statName;
        public ValueType ValueType => _valueType;
        public float Value => _value;

        public Module(ModuleSettings settings)
        {
            _statName = settings.StatName;
            _valueType = settings.ValueType;
            _value = settings.Value;
        }

        public float ApplyModification(float stat)
        {
            stat = _valueType == ValueType.Absolute
                ? stat + _value
                : stat + stat * _value;

            return stat;
        }
    }
}