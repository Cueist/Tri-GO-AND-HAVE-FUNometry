using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemContainer : MonoBehaviour
{
    public List<Equipment> AlloftheItems = new List<Equipment>();
    private int randomItemGroup, randomQualtiy;

    public void Quality(int randomQualtiy)
    {
        randomItemGroup = UnityEngine.Random.Range(1, 6) * 5; // 5 - 10...
        if (randomQualtiy > 97) // 50 25 15 7 3
        {
            randomItemGroup -= 0;
        }
        else if (randomQualtiy > 90)
        {
            randomItemGroup -= 1;
        }
        else if (randomQualtiy > 75)
        {
            randomItemGroup -= 2;
        }
        else if (randomQualtiy > 50)
        {
            randomItemGroup -= 3;
        }
        else
        {
            randomItemGroup -= 4;
        }
        Inventory.instance.Add(AlloftheItems[randomItemGroup]);
    }
}
