using Settings.Enums;
using UnityEngine;
using UnityEngine.Serialization;

namespace Settings.Scriptables
{
    public class ComponentSettings : ScriptableObject
    {
        [SerializeField] private string _id;
        [SerializeField] private ComponentType _componentType;
        [SerializeField] private Sprite _icon;

        public string Id => _id;
        public ComponentType Type => _componentType;
        public Sprite Icon => _icon;
    }
}