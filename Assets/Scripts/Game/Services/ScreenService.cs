using System.Collections.Generic;
using Settings.UI;
using UI.Screens;
using UnityEngine;

namespace Game.Services
{
    public class ScreenService : MonoBehaviour
    {
        [SerializeField] private ScreensList _screens;
        [SerializeField] private RectTransform _parent;

        private readonly Stack<AbstractScreen> _history = new();

        public AbstractScreen Current { get; private set; }

        private void Awake()
        {
            Create(ScreenDef.Customisation);
        }

        private void OnDestroy()
        {
            _history.Clear();
        }

        public void Create(ScreenDef definition)
        {
            var screen = _screens.Get(definition);
            CreateScreen(screen);
        }

        public void Create(AbstractScreen screen)
        {
            CreateScreen(screen);
        }

        public void Back()
        {
            if (_history.Count <= 0)
            {
                return;
            }

            Current.Destroy();
            Current = _history.Pop();
            Current.Show();
        }

        private void CreateScreen(AbstractScreen screen)
        {
            if (Current != null)
            {
                _history.Push(Current);
                Current.Hide();
            }

            Current = Instantiate(screen, _parent);
            Current.InjectService(this);
        }
    }
}