using Settings.Scriptables;
using UnityEngine;

namespace Game
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private SpaceshipSettings _spaceshipSettingsA;
        [SerializeField] private SpaceshipSettings _spaceshipSettingsB;
        
        public void Awake()
        {
            var shipPreparationService = new ShipPreparationService(_spaceshipSettingsA, _spaceshipSettingsB);
            ServiceLocator.Register(shipPreparationService);
        }
    }
}