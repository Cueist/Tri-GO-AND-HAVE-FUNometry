using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentManager : MonoBehaviour
{
    public static EquipmentManager instance;
    public EquipmentDisplayer equipmentDisplayer;
    public StatDisplayer statDisplayer;
    public Player player;
    private string Gender = "Male";

    void Awake()
    {
        instance = this;
    }
    Equipment[] currentEquipment;
    Inventory inventory;

    void Start()
    {
        inventory = Inventory.instance;

        Gender = player.Pgender;
        if(Gender == "Male")
        {
            equipmentDisplayer.Silhouette.sprite = Resources.Load<Sprite>("ItemPictures/mansilhouette");
        }
        else if(Gender == "Female")
        {
            equipmentDisplayer.Silhouette.sprite = Resources.Load<Sprite>("ItemPictures/womansilhouette");
        }
        int numSlots = System.Enum.GetNames(typeof(Equipment.EquipmentSlot)).Length; 
        currentEquipment = new Equipment[numSlots];
    }

    public void Equip (Equipment newItem)
    {
        int slotIndex = (int)newItem.equipslot;
        Equipment oldItem = null;
        if (currentEquipment[slotIndex] != null)
        {
            oldItem = currentEquipment[slotIndex];
            inventory.Add(oldItem);
            player.PmaxHealth -= oldItem.Itemhealth;
            player.PcurrentHealth -= oldItem.Itemhealth;
            player.PDefence -= oldItem.Itemdefence;
            player.PDamage -= oldItem.Itemdamage;
            player.PCriticalChance -= oldItem.ItemcritChance;
            player.PCriticalDamage -= oldItem.ItemcritDamage;
        }
        currentEquipment[slotIndex] = newItem;
        if(slotIndex == 0)
        {
            var transitem = equipmentDisplayer.Head.color;
            transitem.a = 1f;
            equipmentDisplayer.Head.color = transitem;
            equipmentDisplayer.Head.sprite = newItem.icon;
            equipmentDisplayer.HeadRarity.color = transitem;
            equipmentDisplayer.HeadRarity.sprite = newItem.rarity;
        }
        if (slotIndex == 1)
        {
            var transitem = equipmentDisplayer.Chest.color;
            transitem.a = 1f;
            equipmentDisplayer.Chest.color = transitem;
            equipmentDisplayer.Chest.sprite = newItem.icon;
            equipmentDisplayer.ChestRarity.color = transitem;
            equipmentDisplayer.ChestRarity.sprite = newItem.rarity;
        }
        if (slotIndex == 2)
        {
            var transitem = equipmentDisplayer.RightHand.color;
            transitem.a = 1f;
            equipmentDisplayer.RightHand.color = transitem;
            equipmentDisplayer.RightHand.sprite = newItem.icon;
            equipmentDisplayer.RightHandRarity.color = transitem;
            equipmentDisplayer.RightHandRarity.sprite = newItem.rarity;
        }
        if (slotIndex == 3)
        {
            var transitem = equipmentDisplayer.LeftHand.color;
            transitem.a = 1f;
            equipmentDisplayer.LeftHand.color = transitem;
            equipmentDisplayer.LeftHand.sprite = newItem.icon;
            equipmentDisplayer.LeftHandRarity.color = transitem;
            equipmentDisplayer.LeftHandRarity.sprite = newItem.rarity;
        }
        if (slotIndex == 4)
        {
            var transitem = equipmentDisplayer.Feets.color;
            transitem.a = 1f;
            equipmentDisplayer.Feets.color = transitem;
            equipmentDisplayer.Feets.sprite = newItem.icon;
            equipmentDisplayer.FeetsRarity.color = transitem;
            equipmentDisplayer.FeetsRarity.sprite = newItem.rarity;
        }
        player.PmaxHealth += newItem.Itemhealth;
        player.PcurrentHealth += newItem.Itemhealth;
        player.PDefence += newItem.Itemdefence;
        player.PDamage += newItem.Itemdamage;
        player.PCriticalChance += newItem.ItemcritChance;
        player.PCriticalDamage += newItem.ItemcritDamage;
        UnityEngine.Debug.Log("Equipped the item " + currentEquipment[slotIndex]);
    }

    public void DisplayEquippedItem(int slotIndex)
    {
        if (currentEquipment[slotIndex] != null)
        {
            statDisplayer.ShowStats(currentEquipment[slotIndex]);
            statDisplayer.equip.enabled = false;
            statDisplayer.ButtonText.enabled = false;
            statDisplayer.ButtonImage.enabled = false;
        }
    }
}
