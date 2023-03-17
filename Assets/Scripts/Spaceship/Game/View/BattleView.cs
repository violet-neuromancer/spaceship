using Spaceship.Game.Services;
using UnityEngine;

namespace Spaceship.Game.View
{
    public class BattleView : MonoBehaviour
    {
        public ShipView ShipViewA;
        public ShipView ShipViewB;

        private ShipCustomisationService _shipCustomisationService;

        private void Start()
        {
            _shipCustomisationService = ServiceLocator.Get<ShipCustomisationService>();
            
            ShipViewA.Init(_shipCustomisationService.ShipA);
            ShipViewB.Init(_shipCustomisationService.ShipB);
        }
    }
}