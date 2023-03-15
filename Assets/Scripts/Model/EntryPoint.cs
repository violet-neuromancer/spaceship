using Settings.Scriptables;
using UnityEngine;

namespace Model
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private SpaceshipSettings _spaceshipSettingsA;
        [SerializeField] private SpaceshipSettings _spaceshipSettingsB;
        
        public void Awake()
        {
            var coroutinesHolderInstance = FindObjectOfType<CoroutinesHolder>();
            if (coroutinesHolderInstance == null)
            {
                var coroutinesHolderGameObject = new GameObject("CoroutinesHolderRoot");
                DontDestroyOnLoad(coroutinesHolderGameObject);
                ServiceLocator.Register(coroutinesHolderGameObject.AddComponent<CoroutinesHolder>());
            }
            else
            {
                ServiceLocator.Register(coroutinesHolderInstance);
            }

            var modulesService = new ModulesService();
            var shipPreparationService = new ShipPreparationService(_spaceshipSettingsA, _spaceshipSettingsB, modulesService);
            ServiceLocator.Register(shipPreparationService);
        }
    }
}