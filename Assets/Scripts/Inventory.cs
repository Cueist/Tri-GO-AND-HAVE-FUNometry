using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;

    void Awake()
    {
        instance = this;
    }

    public delegate void OnItemChange();
    public OnItemChange OnItemChangeCallback;

    public List<Items> items = new List<Items>();
    public EquipmentManager equipmentmanager;
    public GameObject ItemDropPart;
    public Image ItemImage, ItemRarityImage;
    public TextMeshProUGUI ItemNameQuality;
    public int randomQuality, randomItem, space = 30;

    public void Add (Items item)
    {
        if (items.Count < space)
        {
            items.Add(item);
            ItemImage.sprite = item.icon;
            ItemRarityImage.sprite = item.rarity;
            ItemNameQuality.text = item.Itemname + " (" + item.Itemquality + ")";
            UnityEngine.Debug.Log("Item picked up = " + item.Itemname);
            ItemDropPart.SetActive(true);
            StartCoroutine(ItemFoundCountdown());
        }
        else
        {
            UnityEngine.Debug.Log("Not Enough Space!");
        }
        if (OnItemChangeCallback != null)
        {
            OnItemChangeCallback.Invoke();
        }
    }

    IEnumerator ItemFoundCountdown()
    {
        yield return new WaitForSeconds((float)0.5);
        ItemDropPart.SetActive(false);
    }

    public void Remove(Items item)
    {
        items.Remove(item);

        if (OnItemChangeCallback != null)
        {
            OnItemChangeCallback.Invoke();
        }
    }

    public void Equip(Items item)
    {
        UnityEngine.Debug.Log("Calling Equipment Manager");
        equipmentmanager.Equip((Equipment)item);
        Remove((Equipment)item);

        if (OnItemChangeCallback != null)
        {
            OnItemChangeCallback.Invoke();
        }
    }
}
