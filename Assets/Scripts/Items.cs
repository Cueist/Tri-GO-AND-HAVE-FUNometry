using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Items : ScriptableObject
{
    public Sprite icon;
    public Sprite rarity;
    public string Itemname = "Default";
    public string Itemquality = "Default";
    public string Itemdesc = "NONE";
    public float Itemdamage = 0.0f;
    public float Itemhealth = 0.0f;
    public float Itemdefence = 0.0f;
    public float ItemcritChance = 0.0f;
    public float ItemcritDamage = 0.0f;

    public virtual void Use()
    {
        // Do something
    }

    public void RemoveFromInventory()
    {
        Inventory.instance.Remove(this);
    }
}
