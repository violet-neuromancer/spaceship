using System;
using Settings.Enums;
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

        public ComponentType Type { get; private set; }
        public string ID { get; private set; }
        
        public Action<WidgetSpaceshipComponent> OnComponentClicked;

        public void Init(ComponentType componentType)
        {
            Type = componentType;
        }

        public void SetData(Sprite imageComponent, string id)
        {
            _imageComponent.sprite = imageComponent;
            _labelName.text = id;
            ID = id;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            OnComponentClicked?.Invoke(this);
        }
    }
}