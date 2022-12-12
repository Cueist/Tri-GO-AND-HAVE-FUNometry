using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")] // Creating a new menu for the items
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

    public virtual void Use() // If an active item possibility occurs
    {
        // Do something
    }

    public void RemoveFromInventory() // Removing item from the inventory
    {
        Inventory.instance.Remove(this);
    }
}
