using Spaceship.Game.Model;
using Spaceship.Settings;
using UnityEngine;
using UnityEngine.UI;

namespace Spaceship.Game.View
{
    public class ShipView : MonoBehaviour
    {
        [SerializeField] private Image _imageShip;
        [Header("Settings")] 
        [SerializeField] private SpriteIdPairList _shipSpriteIdPairList;

        private Ship _ship;

        private void Update()
        {
            if (_ship == null)
            {
                return;
            }
            
            
        }

        public void Init(Ship ship)
        {
            _imageShip.sprite = _shipSpriteIdPairList.GetSpriteById(ship.Id);
        }
    }
}