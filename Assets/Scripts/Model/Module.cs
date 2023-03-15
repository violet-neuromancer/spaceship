using Settings.Enums;
using Settings.Scriptables;

namespace Model
{
    public class Module
    {
        private string _statName;
        private ValueType _valueType;
        private int _value;

        public string StatName => _statName;
        public ValueType ValueType => _valueType;
        public int Value => _value;

        public Module(ModuleSettings settings)
        {
            _statName = settings.StatName;
            _valueType = settings.ValueType;
            _value = settings.Value;
        }
    }
}