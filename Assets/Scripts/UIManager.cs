using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Slider HealthSlider;
    public void SetMaxHealth(int health)
    {
        HealthSlider.maxValue = health;
    }
    public void SetHealth(int health)
    {
        HealthSlider.value = health;
    }
}
