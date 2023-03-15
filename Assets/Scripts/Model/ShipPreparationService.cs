using Settings.Scriptables;

namespace Model
{
    public class ShipPreparationService
    {
        public Spaceship SpaceshipA { get; private set; }
        public Spaceship SpaceshipB { get; private set; }

        private readonly ModulesService _modulesService;

        public ShipPreparationService(SpaceshipSettings spaceshipASettings, SpaceshipSettings spaceshipBSettings, 
            ModulesService modulesService)
        {
            SpaceshipA = new Spaceship(spaceshipASettings);
            SpaceshipB = new Spaceship(spaceshipBSettings);

            _modulesService = modulesService;
        }

        public void PrepareComponents()
        {
            _modulesService.ApplyModules(SpaceshipA);
            _modulesService.ApplyModules(SpaceshipB);
        }
    }
}