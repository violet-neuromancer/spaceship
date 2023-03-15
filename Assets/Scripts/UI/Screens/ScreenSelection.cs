using Settings.Scriptables;
using UI.Widgets;
using UnityEngine;

namespace UI.Screens
{
    public class ScreenSelection : MonoBehaviour
    {
        [SerializeField] private WidgetSpaceshipSelection _widgetSpaceshipASelection;
        [SerializeField] private SpaceshipSettings _spaceshipASettings;
        [SerializeField] private WidgetSpaceshipSelection _widgetSpaceshipBSelection;
        [SerializeField] private SpaceshipSettings _spaceshipBSettings;

        private void Start()
        {
            _widgetSpaceshipASelection.Init(_spaceshipASettings);
            _widgetSpaceshipBSelection.Init(_spaceshipBSettings);
        }
    }
}
