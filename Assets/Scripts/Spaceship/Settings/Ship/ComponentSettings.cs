using UnityEngine;

namespace Spaceship.Settings.Ship
{
    public class ComponentSettings : ScriptableObject
    {
        [SerializeField] private string _id;
        [SerializeField] private ComponentDef _componentDef;

        public string Id => _id;
        public ComponentDef Def => _componentDef;
    }
}