using Game.Model;
using Settings;
using UnityEngine;
using UnityEngine.UI;

namespace Game.View
{
    public class ShipView : MonoBehaviour
    {
        [SerializeField] private Image _imageShip;
        [Header("Settings")] 
        [SerializeField] private SpriteIdPairList _shipSpriteIdPairList;

        public void Init(Ship ship)
        {
            _imageShip.sprite = _shipSpriteIdPairList.GetSpriteById(ship.Id);
        }
    }
}