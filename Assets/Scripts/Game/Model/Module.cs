using Settings;
using Settings.Ship;

namespace Game.Model
{
    public class Module
    {
        private string _id;
        private string _statName;
        private ValueDef _valueDef;
        private float _value;

        public string Id => _id;
        public string StatName => _statName;
        public ValueDef ValueDef => _valueDef;
        public float Value => _value;

        public Module(ModuleSettings settings)
        {
            _id = settings.Id;
            _statName = settings.StatName;
            _valueDef = settings.ValueDef;
            _value = settings.Value;
        }

        public float ApplyModification(float stat)
        {
            stat = _valueDef == ValueDef.Absolute
                ? stat + _value
                : stat + stat * _value;

            return stat;
        }
    }
}