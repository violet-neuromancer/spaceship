using UnityEngine;

namespace Model
{
    public class EntryPoint : MonoBehaviour
    {
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
            
            
        }
    }
}