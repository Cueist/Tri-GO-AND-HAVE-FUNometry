using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerXPBar : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Manager manager;
    public void SetXP(float xp)
    {
        slider.value += xp; // Adding our gained experince to the our slider's value
        while (slider.value == slider.maxValue) // Level up checker
        {
            slider.value = 0;
            xp -= slider.maxValue;
            manager.PlayerLevelling(xp); // Sending the remaining experience
            slider.value += xp;
        }
        text.text = "" + slider.value.ToString() + "/" + slider.maxValue.ToString();
    }
    public void SetMaxXP(float xp, int level) // Setting the Maximum Experince value according to the our level
    {
        slider.maxValue = (xp*level);
    }
}
