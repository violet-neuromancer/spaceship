using System.Collections.Generic;
using Settings.Enums;
using Settings.Scriptables;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Widgets
{
    public class WidgetSpaceship : MonoBehaviour
    {
        [SerializeField] private WidgetSpaceshipComponent widgetSpaceshipComponentPrefab;
        [SerializeField] private Image _imageSpaceship;
        [SerializeField] private Transform _weaponsContainer;
        [SerializeField] private Transform _modulesContainer;

        public List<WidgetSpaceshipComponent> WidgetWeapons { get; private set; }
        public List<WidgetSpaceshipComponent> WidgetModules { get; private set; }

        public void Init(SpaceshipSettings spaceshipSettings)
        {
            _imageSpaceship.sprite = spaceshipSettings.Icon;
            WidgetWeapons = new List<WidgetSpaceshipComponent>();
            for (var i = 0; i < spaceshipSettings.WeaponSlotsCount; i++)
            {
                var widgetWeapon = Instantiate(widgetSpaceshipComponentPrefab, _weaponsContainer);
                widgetWeapon.Init(ComponentType.Weapon);
                WidgetWeapons.Add(widgetWeapon);
            }

            WidgetModules = new List<WidgetSpaceshipComponent>();
            for (var i = 0; i < spaceshipSettings.ModuleSlotsCount; i++)
            {
                var widgetModule = Instantiate(widgetSpaceshipComponentPrefab, _modulesContainer);
                widgetModule.Init(ComponentType.Module);
                WidgetModules.Add(widgetModule);
            }
        }
    }
}