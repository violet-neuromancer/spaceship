using System;
using Settings.Enums;
using Settings.Scriptables;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI.Widgets
{
    public class WidgetSpaceshipComponent : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private Image _imageComponent;
        [SerializeField] private TMP_Text _labelName;
        [SerializeField] private SpriteIdPairList _componentSpriteIdPairList;

        public ComponentType Type { get; private set; }
        public string ID { get; private set; }
        public int Index { get; private set; }
        
        public Action<WidgetSpaceshipComponent> OnComponentClicked;

        public void Init(ComponentType componentType, int index)
        {
            Type = componentType;
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
            OnComponentClicked?.Invoke(this);
        }
    }
}