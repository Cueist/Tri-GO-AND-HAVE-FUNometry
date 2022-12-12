using UnityEngine;
using TMPro;

public class MiddlePart : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI AccuracyText;
    [SerializeField] private TextMeshProUGUI IQPointtext;

    public void AccText(float acctext) // Displaying Accuracy Text
    {
        AccuracyText.text = "" + acctext + "%";
    }

    public void IQText(int iqtext) // Displaying IQ Text
    {
        IQPointtext.text = "" + iqtext;
    }
}
