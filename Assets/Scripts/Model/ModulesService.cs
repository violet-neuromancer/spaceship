namespace Model
{
    public class ModulesService
    {
        public void ApplyModules(Spaceship spaceship)
        {
            foreach (var module in spaceship.Modules)
            {
                switch (module.StatName)
                {
                    case "Health":
                        spaceship.Health = module.ApplyModification(spaceship.Health);
                        break;
                    case "Shield":
                        spaceship.Shield = module.ApplyModification(spaceship.Shield);
                        break;
                    case "ShieldRegenPerSec":
                        spaceship.ShieldRegenPerSec = module.ApplyModification(spaceship.ShieldRegenPerSec);
                        break;
                    case "Recharge":
                        foreach (var weapon in spaceship.Weapons)
                        {
                            weapon.Recharge = module.ApplyModification(weapon.Recharge);
                        }
                        break;
                }
            }
        }
    }
}