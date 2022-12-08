using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageBar : MonoBehaviour
{
    public Slider slider;
    public Image fill;

    public void SetStage(float stage)
    {
        if(stage == 0)
        {
            slider.value = 0;
        }
        else
        {
            UnityEngine.Debug.Log("Stage elsede");
            slider.value = stage/10.0f;
        }
    }
}
