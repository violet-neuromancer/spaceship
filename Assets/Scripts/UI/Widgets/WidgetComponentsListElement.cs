using System;
using Settings;
using Settings.Ship;
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
        
        public ComponentDef Def { get; private set; }
        public string Id { get; private set; }

        public Action<WidgetComponentsListElement> OnComponentsListElementClicked;

        public void SetData(ComponentSettings settings)
        {
            Def = settings.Def;
            Id = settings.Id;

            _imageComponent.sprite = _componentIconSpriteIdPairList.GetSpriteById(settings.Id);
            _labelName.text = settings.Id;

            if (settings.Def == ComponentDef.Weapon)
            {
                var weaponSettings = (WeaponSettings)settings;
                _labelBonus.text = weaponSettings.Damage.ToString();
            }

            if (settings.Def == ComponentDef.Module)
            {
                var moduleSettings = (ModuleSettings)settings;
                _labelBonus.text = moduleSettings.Value.ToString();
            }
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            OnComponentsListElementClicked?.Invoke(this);
        }
    }
}