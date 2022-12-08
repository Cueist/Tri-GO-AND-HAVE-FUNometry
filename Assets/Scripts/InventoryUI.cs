using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public Transform itemsParent;
    InventorySlot[] slots;
    Inventory inventory;

    void Start()
    {
        inventory = Inventory.instance;
        inventory.OnItemChangeCallback += UpdateUI;
        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }

    void UpdateUI()
    {
        UnityEngine.Debug.Log("Updating UI!");
        for (int i = 0; i < slots.Length; i++)
        {
            if(i< inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].DeleteItem();
            }
        }
    }
}
