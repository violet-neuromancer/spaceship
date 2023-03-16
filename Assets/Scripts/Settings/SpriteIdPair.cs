using System;
using UnityEngine;

namespace Settings
{
    [Serializable]
    public struct SpriteIdPair
    {
        [SerializeField] private string _id;
        [SerializeField] private Sprite _sprite;

        public string ID => _id;
        public Sprite Sprite => _sprite;
    }
}