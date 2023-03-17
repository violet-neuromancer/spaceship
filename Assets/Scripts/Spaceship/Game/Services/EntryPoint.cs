using Spaceship.Settings.Ship;
using UnityEngine;

namespace Spaceship.Game.Services
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private ShipSettings _shipSettingsA;
        [SerializeField] private ShipSettings _shipSettingsB;
        
        public void Awake()
        {
            var shipCustomisationService = new ShipCustomisationService(_shipSettingsA, _shipSettingsB);
            ServiceLocator.Register(shipCustomisationService);
        }
    }
}