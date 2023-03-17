using System;
using Spaceship.UI.Screens;
using UnityEngine;

namespace Spaceship.Settings.UI
{
    [CreateAssetMenu(menuName = "Spaceship/New Screens List", fileName = "NewScreensList")]
    public class ScreensList : ScriptableObject
    {
        [SerializeField] private ScreenEntry[] _screens;

        public AbstractScreen Get(ScreenDef definition)
        {
            return Array.Find(_screens, pair => pair.Def.Equals(definition)).Screen;
        }
    }
}