using UnityEngine;
using UnityEngine.UI;

public class StageBar : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Image fill;

    public void SetStage(float stage) // Displaying/Setting the Game Stage value
    {
        if(stage == 0)
        {
            slider.value = 0;
        }
        else
        {
            slider.value = stage/10.0f;
        }
    }
}
