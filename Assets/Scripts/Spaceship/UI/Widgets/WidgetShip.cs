using System.Collections.Generic;
using Spaceship.Game.Model;
using Spaceship.Settings;
using Spaceship.Settings.Ship;
using UnityEngine;
using UnityEngine.UI;

namespace Spaceship.UI.Widgets
{
    public class WidgetShip : MonoBehaviour
    {
        [SerializeField] private Image _imageSpaceship;
        [SerializeField] private Transform _weaponsContainer;
        [SerializeField] private Transform _modulesContainer;
        [Header("Prefabs")]
        [SerializeField] private WidgetShipComponentSlot widgetShipComponentSlotPrefab;
        [Header("Settings")]
        [SerializeField] private SpriteIdPairList _spaceshipSpriteIdPairList;

        public List<WidgetShipComponentSlot> WidgetWeapons { get; private set; }
        public List<WidgetShipComponentSlot> WidgetModules { get; private set; }

        public void Init(Ship ship)
        {
            _imageSpaceship.sprite = _spaceshipSpriteIdPairList.GetSpriteById(ship.Id);
            WidgetWeapons = new List<WidgetShipComponentSlot>();
            for (var i = 0; i < ship.Weapons.Length; i++)
            {
                var widgetWeapon = Instantiate(widgetShipComponentSlotPrefab, _weaponsContainer);
                widgetWeapon.Init(ComponentDef.Weapon, i);
                WidgetWeapons.Add(widgetWeapon);
            }

            WidgetModules = new List<WidgetShipComponentSlot>();
            for (var i = 0; i < ship.Modules.Length; i++)
            {
                var widgetModule = Instantiate(widgetShipComponentSlotPrefab, _modulesContainer);
                widgetModule.Init(ComponentDef.Module, i);
                WidgetModules.Add(widgetModule);
            }
        }
    }
}