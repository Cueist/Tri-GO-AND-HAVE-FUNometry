using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ENamePart : MonoBehaviour
{
    public TextMeshProUGUI Enemyname;
    public Enemy enemy;

    public void Naming()
    {
        Enemyname.text = enemy.Ename + " - Level " + enemy.Elevel;
    }
}
