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
    [SerializeField] private GameObject HoverSound;
    public void OnPointerEnter(PointerEventData eventData)
    {
        Instantiate(HoverSound, transform.position, Quaternion.identity);
        text.color = HoverColor;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        text.color = IdleColor;
    }
}

