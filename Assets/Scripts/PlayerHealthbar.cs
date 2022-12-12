using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerHealthbar : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Gradient gradient;
    [SerializeField] private Image fill;

    public void SetHealth(float health) // Setting our Health value
    {
        slider.value = health;
        text.text = "" + health.ToString() + "/" + slider.maxValue.ToString();
        fill.color = gradient.Evaluate(slider.normalizedValue); // Making it colorful

    }
    public void SetMaxHealth(float health) // Setting our Maximum Health value
    {
        slider.maxValue = health;
        fill.color = gradient.Evaluate(1f); // Making it colorful (1f maximum value)
    }
}
