using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Text text;
    [SerializeField] private Color IdleColor;
    [SerializeField] private Color HoverColor;
    public void OnPointerEnter(PointerEventData eventData)
    {
        text.color = HoverColor;
    }
    public void OnPointerExit(PointerEventData eventData)
     {
        text.color = IdleColor;
     }
}

