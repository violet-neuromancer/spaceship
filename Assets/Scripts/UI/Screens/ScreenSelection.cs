using Model;
using UI.Widgets;
using UnityEngine;

namespace UI.Screens
{
    public class ScreenSelection : MonoBehaviour
    {
        [SerializeField] private WidgetSpaceshipSelection _widgetSpaceshipASelection;
        [SerializeField] private WidgetSpaceshipSelection _widgetSpaceshipBSelection;

        private ShipPreparationService _shipPreparationService;

        private void Start()
        {
            _shipPreparationService = ServiceLocator.Get<ShipPreparationService>();
            
            _widgetSpaceshipASelection.Init(_shipPreparationService.SpaceshipA);
            _widgetSpaceshipBSelection.Init(_shipPreparationService.SpaceshipB);
        }
    }
}
