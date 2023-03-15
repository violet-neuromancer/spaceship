﻿using System.Collections.Generic;
using Settings.Scriptables;
using UnityEngine;

namespace UI.Widgets
{
    public class WidgetSpaceshipSelection : MonoBehaviour
    {
        [SerializeField] private WidgetSpaceship _widgetSpaceship;
        [SerializeField] private GameObject _panelComponents;
        [SerializeField] private Transform _components;
        [SerializeField] private WidgetComponentsListElement _widgetComponentPrefab;
        [SerializeField] private ComponentsList _componentsList;

        private readonly List<WidgetComponentsListElement> _widgetComponentsList = new();

        private WidgetSpaceshipComponent _selectedComponentSlot;

        public void Init(SpaceshipSettings spaceshipSettings)
        {
            _widgetSpaceship.Init(spaceshipSettings);

            foreach (var component in _componentsList.AllSettings)
            {
                var widgetComponent = Instantiate(_widgetComponentPrefab, _components);
                widgetComponent.SetData(component.Value);
                widgetComponent.gameObject.SetActive(false);
                _widgetComponentsList.Add(widgetComponent);
                widgetComponent.OnWidgetClicked += OnComponentsListElementClicked;
            }

            foreach (var widgetComponent in _widgetSpaceship.WidgetWeapons)
            {
                widgetComponent.OnComponentClicked += OnComponentClicked;
            }
            foreach (var widgetComponent in _widgetSpaceship.WidgetModules)
            {
                widgetComponent.OnComponentClicked += OnComponentClicked;
            }
        }

        private void OnComponentClicked(WidgetSpaceshipComponent selectedComponentSlot)
        {
            _panelComponents.SetActive(true);
            
            _selectedComponentSlot = selectedComponentSlot;
            
            foreach (var widgetComponent in _widgetComponentsList)
            {
                widgetComponent.gameObject.SetActive(widgetComponent.Type == selectedComponentSlot.Type);
            }
        }

        private void OnComponentsListElementClicked(WidgetComponentsListElement selectedComponent)
        {
            _componentsList.TryGetSettings(selectedComponent.Id, out var componentSettings);
            _selectedComponentSlot.SetData(componentSettings.Icon, componentSettings.Id);
            
            _selectedComponentSlot = null;
            _panelComponents.SetActive(false);
        }
    }
}