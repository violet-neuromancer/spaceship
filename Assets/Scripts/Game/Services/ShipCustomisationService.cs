using Game.Model;
using Settings.Scriptables.Ship;

namespace Game.Services
{
    public class ShipCustomisationService
    {
        public Ship SpaceshipA { get; private set; }
        public Ship SpaceshipB { get; private set; }

        public ShipCustomisationService(ShipSettings shipASettings, ShipSettings shipBSettings)
        {
            SpaceshipA = new Ship(shipASettings);
            SpaceshipB = new Ship(shipBSettings);
        }

        public void ApplyModules()
        {
            SpaceshipA.ApplyModules();
            SpaceshipB.ApplyModules();
        }

        public void ReplaceComponent(Ship ship, int index, ComponentSettings componentSettings)
        {
            ship.ReplaceComponent(index, componentSettings);
        }
    }
}