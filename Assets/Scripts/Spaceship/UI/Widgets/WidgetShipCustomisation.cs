using System.Collections.Generic;
using Spaceship.Game.Model;
using Spaceship.Game.Services;
using Spaceship.Settings.Ship;
using UnityEngine;

namespace Spaceship.UI.Widgets
{
    public class WidgetShipCustomisation : MonoBehaviour
    {
        [SerializeField] private WidgetShip _widgetShip;
        [SerializeField] private GameObject _panelComponents;
        [SerializeField] private Transform _componentsContainer;
        [Header("Prefabs")]
        [SerializeField] private WidgetComponentsListElement _widgetComponentsListElementPrefab;
        [Header("Settings")]
        [SerializeField] private ComponentsList _componentsList;

        private readonly List<WidgetComponentsListElement> _widgetComponentsList = new();

        private Ship _ship;
        private WidgetShipComponentSlot _selectedComponentSlot;
        private ShipCustomisationService _shipCustomisationService;

        private void Start()
        {
            _shipCustomisationService = ServiceLocator.Get<ShipCustomisationService>();
        }

        private void OnDestroy()
        {
            foreach (var componentsListElement in _widgetComponentsList)
            {
                componentsListElement.OnComponentsListElementClicked -= OnComponentsListElementClicked;
            }
            
            foreach (var widgetComponent in _widgetShip.WidgetWeapons)
            {
                widgetComponent.OnShipComponentClicked -= OnShipComponentClicked;
            }
            
            foreach (var widgetComponent in _widgetShip.WidgetModules)
            {
                widgetComponent.OnShipComponentClicked -= OnShipComponentClicked;
            }
        }

        public void Init(Ship ship)
        {
            _ship = ship;
            
            _widgetShip.Init(ship);

            foreach (var component in _componentsList.AllSettings)
            {
                var widgetComponent = Instantiate(_widgetComponentsListElementPrefab, _componentsContainer);
                widgetComponent.SetData(component.Value);
                widgetComponent.gameObject.SetActive(false);
                _widgetComponentsList.Add(widgetComponent);
                widgetComponent.OnComponentsListElementClicked += OnComponentsListElementClicked;
            }

            foreach (var widgetComponent in _widgetShip.WidgetWeapons)
            {
                widgetComponent.OnShipComponentClicked += OnShipComponentClicked;
            }
            
            foreach (var widgetComponent in _widgetShip.WidgetModules)
            {
                widgetComponent.OnShipComponentClicked += OnShipComponentClicked;
            }
        }

        private void OnShipComponentClicked(WidgetShipComponentSlot selectedComponentSlotSlot)
        {
            _panelComponents.SetActive(true);
            
            _selectedComponentSlot = selectedComponentSlotSlot;
            
            foreach (var widgetComponentsListElement in _widgetComponentsList)
            {
                widgetComponentsListElement.gameObject.SetActive(widgetComponentsListElement.Def == selectedComponentSlotSlot.Def);
            }
        }

        private void OnComponentsListElementClicked(WidgetComponentsListElement selectedComponent)
        {
            _componentsList.TryGetSettings(selectedComponent.Id, out var componentSettings);
            _selectedComponentSlot.SetComponentData(componentSettings.Id);
            _shipCustomisationService.ReplaceComponent(_ship, _selectedComponentSlot.Index, componentSettings);
            
            _selectedComponentSlot = null;
            _panelComponents.SetActive(false);
        }
    }
}