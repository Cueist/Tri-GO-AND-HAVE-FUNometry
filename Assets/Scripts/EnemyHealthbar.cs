using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyHealthbar : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI text;
    public Gradient gradient;
    public Image fill;

    public void SetHealth(float health)
    {
        slider.value = health;
        text.text = "" + health.ToString() + "/" + slider.maxValue.ToString();
        fill.color = gradient.Evaluate(slider.normalizedValue);

    }
    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
        fill.color = gradient.Evaluate(1f);
    }
}
