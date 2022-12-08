using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PNamePart : MonoBehaviour
{
    public TextMeshProUGUI Username;
    public Player player;

    public void Naming()
    {
        Username.text = player.Pusername + " - Level " + player.level;
    }
}
