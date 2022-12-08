using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    public Image rarity;
    public Button Deletebutton;
    public Button Itembutton;
    public StatDisplayer statdisplayer;
    Items item;

    public void AddItem(Items newItem)
    {
        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;
        rarity.sprite = item.rarity;
        rarity.enabled = true;
        Deletebutton.interactable = true;
    }

    public void DeleteItem()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
        rarity.sprite = null;
        rarity.enabled = false;
        Deletebutton.interactable = false;
    }

    public void OnRemoveButton()
    {
        UnityEngine.Debug.Log("Deleting the item");
        Inventory.instance.Remove(item);
        UnityEngine.Debug.Log("Removing Stats' Texts");
        statdisplayer.RemoveStatsText();
    }

    public void ItemClicked()
    {
        if (item != null)
        {
            statdisplayer.RemoveStatsText();
            UnityEngine.Debug.Log("Showing Stats");
            statdisplayer.ShowStats(item);
        }
    }
}
