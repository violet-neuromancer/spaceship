using System;
using Settings.Enums;
using Settings.Scriptables;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI.Widgets
{
    public class WidgetComponentsListElement : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private Image _imageComponent; 
        [SerializeField] private TMP_Text _labelName;
        [SerializeField] private TMP_Text _labelBonus;
        [SerializeField] private SpriteIdPairList _componentIconSpriteIdPairList;
        
        public ComponentType Type { get; private set; }
        public string Id { get; private set; }

        public Action<WidgetComponentsListElement> OnWidgetClicked;

        public void SetData(ComponentSettings settings)
        {
            Type = settings.Type;
            Id = settings.Id;

            _imageComponent.sprite = _componentIconSpriteIdPairList.GetSpriteById(settings.Id);
            _labelName.text = settings.Id;

            if (settings.Type == ComponentType.Weapon)
            {
                var weaponSettings = (WeaponSettings)settings;
                _labelBonus.text = weaponSettings.Damage.ToString();
            }

            if (settings.Type == ComponentType.Module)
            {
                var moduleSettings = (ModuleSettings)settings;
                _labelBonus.text = moduleSettings.Value.ToString();
            }
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            OnWidgetClicked?.Invoke(this);
        }
    }
}