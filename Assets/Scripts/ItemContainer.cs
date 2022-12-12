using System.Collections.Generic;
using UnityEngine;

public class ItemContainer : MonoBehaviour
{
    public List<Equipment> AlloftheItems = new List<Equipment>(); // Creating a place to store all of our equipable items
    private int randomItemGroup;

    public void Quality(int randomQualtiy) // Random Rarity selection
    {
        randomItemGroup = UnityEngine.Random.Range(1, 6) * 5; // 5 - 10...
        if (randomQualtiy > 97) // 3%
        {
            randomItemGroup -= 0;
        }
        else if (randomQualtiy > 90) // 7%
        {
            randomItemGroup -= 1;
        }
        else if (randomQualtiy > 75) // 15%
        {
            randomItemGroup -= 2;
        }
        else if (randomQualtiy > 50) // 25%
        {
            randomItemGroup -= 3;
        }
        else // 50%
        {
            randomItemGroup -= 4;
        }
        Inventory.instance.Add(AlloftheItems[randomItemGroup]); // Adding item to the inventory
    }
}
