using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Slider HealthSlider;
    [SerializeField] private Image Fill;
    [SerializeField] private Text Score;
    [SerializeField] private Gradient Gradient;
    public void SetMaxHealth(int health)
    {
        HealthSlider.maxValue = health;
        Gradient.Evaluate(1f);
    }
    public void SetHealth(int health)
    {
        HealthSlider.value = health;
        Fill.color = Gradient.Evaluate(HealthSlider.normalizedValue);
    }
    public void SetScore(int score)
    {
        Score.text = score.ToString();
    }
}
