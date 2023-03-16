using System.Collections.Generic;
using Game;
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
        [SerializeField] private SpriteIdPairList _spaceshipSpriteIdPairList;

        public List<WidgetSpaceshipComponent> WidgetWeapons { get; private set; }
        public List<WidgetSpaceshipComponent> WidgetModules { get; private set; }

        public void Init(Spaceship spaceship)
        {
            _imageSpaceship.sprite = _spaceshipSpriteIdPairList.GetSpriteById(spaceship.Id);
            WidgetWeapons = new List<WidgetSpaceshipComponent>();
            for (var i = 0; i < spaceship.Weapons.Length; i++)
            {
                var widgetWeapon = Instantiate(widgetSpaceshipComponentPrefab, _weaponsContainer);
                widgetWeapon.Init(ComponentType.Weapon, i);
                WidgetWeapons.Add(widgetWeapon);
            }

            WidgetModules = new List<WidgetSpaceshipComponent>();
            for (var i = 0; i < spaceship.Modules.Length; i++)
            {
                var widgetModule = Instantiate(widgetSpaceshipComponentPrefab, _modulesContainer);
                widgetModule.Init(ComponentType.Module, i);
                WidgetModules.Add(widgetModule);
            }
        }
    }
}