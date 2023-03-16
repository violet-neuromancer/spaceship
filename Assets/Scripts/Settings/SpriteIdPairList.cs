using System;
using UnityEngine;

namespace Settings
{
    [CreateAssetMenu(menuName = "Spaceship/Pairs/New sprite-id", fileName = "SpriteIdPairList")]
    public class SpriteIdPairList : ScriptableObject
    {
        [SerializeField] private SpriteIdPair[] _pairs;

        public Sprite GetSpriteById(string id)
        {
            return Array.Find(_pairs, pair => pair.ID.Equals(id)).Sprite;
        }
    }
}