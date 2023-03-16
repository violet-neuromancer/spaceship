using System;
using Settings;
using Settings.Ship;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI.Widgets
{
    public class WidgetShipComponentSlot : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private Image _imageComponent;
        [SerializeField] private TMP_Text _labelName;
        [Header("Settings")]
        [SerializeField] private SpriteIdPairList _componentSpriteIdPairList;

        public ComponentDef Def { get; private set; }
        public string ID { get; private set; }
        public int Index { get; private set; }
        
        public Action<WidgetShipComponentSlot> OnShipComponentClicked;

        public void Init(ComponentDef componentDef, int index)
        {
            Def = componentDef;
            Index = index;
        }

        public void SetComponentData(string id)
        {
            _imageComponent.sprite = _componentSpriteIdPairList.GetSpriteById(id);
            _labelName.text = id;
            ID = id;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            OnShipComponentClicked?.Invoke(this);
        }
    }
}