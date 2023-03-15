using Settings.Enums;
using UnityEngine;

namespace Settings.Scriptables
{
    public class ComponentSettings : ScriptableObject
    {
        [SerializeField] private string _id;
        [SerializeField] private ComponentType _componentType;

        public string Id => _id;
        public ComponentType Type => _componentType;
    }
}