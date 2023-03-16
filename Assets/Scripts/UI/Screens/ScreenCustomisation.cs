using Game.Services;
using UI.Widgets;
using UnityEngine;

namespace UI.Screens
{
    public class ScreenCustomisation : MonoBehaviour
    {
        [SerializeField] private WidgetShipCustomisation _widgetShipCustomisationA;
        [SerializeField] private WidgetShipCustomisation _widgetShipCustomisationB;

        private ShipCustomisationService _shipCustomisationService;

        private void Start()
        {
            _shipCustomisationService = ServiceLocator.Get<ShipCustomisationService>();
            
            _widgetShipCustomisationA.Init(_shipCustomisationService.SpaceshipA);
            _widgetShipCustomisationB.Init(_shipCustomisationService.SpaceshipB);
        }

        public void OnClick()
        {
            _shipCustomisationService.ApplyModules();
        }
    }
}
