using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerXPBar : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI text;
    public Manager manager;
    private float remainingxp;

    public void SetXP(float xp)
    {
        if (slider.value + xp >= slider.maxValue)
        {
            remainingxp = xp - slider.value;
            slider.value = remainingxp;
            manager.PlayerLevelling();
        }
        else
        {
            slider.value = xp;
        }
        text.text = "" + xp.ToString() + "/" + slider.maxValue.ToString();
    }
    public void SetMaxXP(float xp, int level)
    {
        slider.maxValue = (xp*level);
    }
}
