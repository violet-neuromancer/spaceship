using Settings.Scriptables;

namespace Model
{
    public class ShipPreparationService
    {
        public Spaceship SpaceshipA { get; private set; }
        public Spaceship SpaceshipB { get; private set; }

        public ShipPreparationService(SpaceshipSettings spaceshipASettings, SpaceshipSettings spaceshipBSettings)
        {
            SpaceshipA = new Spaceship(spaceshipASettings);
            SpaceshipB = new Spaceship(spaceshipBSettings);
        }
    }
}