using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MiddlePart : MonoBehaviour
{
    public TextMeshProUGUI AccuracyText;
    public TextMeshProUGUI IQPointtext;

    public void AccText(float acctext)
    {
        AccuracyText.text = "" + acctext + "%";
    }

    public void IQText(int iqtext)
    {
        IQPointtext.text = "" + iqtext;
    }
}
