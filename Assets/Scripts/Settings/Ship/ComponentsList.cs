using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Utils;

namespace Settings.Ship
{
    public class ComponentsList : ScriptableObject
    {
        [SerializeField] private WeaponSettings[] _weapons;
        [SerializeField] private ModuleSettings[] _modules;
        
        private Dictionary<string, ComponentSettings> _allSettings;

        public IEnumerable<WeaponSettings> Weapons => _weapons;
        public IEnumerable<ModuleSettings> Modules => _modules;
        
        public Dictionary<string, ComponentSettings> AllSettings =>
            //Don't believe Unity 2021 documentation about Awake in ScriptableObject. It is not called consistently.
            _allSettings ??= EnumerableEx.Concat<ComponentSettings>(_weapons, _modules).ToDictionary(s => s.Id);

        public bool TryGetSettings(string id, out ComponentSettings settings)
        {
            var result = AllSettings.TryGetValue(id, out settings);
            if (!result)
            {
                Debug.LogError($"There is no Component Settings for {id}");
            }
            return result;
        }
    }
}