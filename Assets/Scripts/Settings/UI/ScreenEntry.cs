using System;
using UI.Screens;
using UnityEngine;

namespace Settings.UI
{
    [Serializable]
    public class ScreenEntry
    {
        [SerializeField] private ScreenDef _def;
        [SerializeField] private AbstractScreen _screen;

        public ScreenDef Def => _def;
        public AbstractScreen Screen => _screen;
    }
}