using Spaceship.Game.Services;
using UnityEngine;

namespace Spaceship.UI.Screens
{
    public abstract class AbstractScreen : MonoBehaviour
    {
        protected ScreenService Service;

        public void InjectService(ScreenService service)
        {
            Service = service;
        }

        public void Destroy()
        {
            Destroy(gameObject);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        public void Show()
        {
            gameObject.SetActive(true);
        }
    }
}