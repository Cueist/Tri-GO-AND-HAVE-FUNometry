using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatDisplayer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Name;
    [SerializeField] private TextMeshProUGUI Stats;
    [SerializeField] private TextMeshProUGUI Description;
    public TextMeshProUGUI ButtonText;
    public Button equip;
    public Image ButtonImage;
    Items defaultitem;

    public void ShowStats(Items item) // Projecting the stats of the selected item to the panel.
    {
        defaultitem = item;
        ButtonText.enabled = true;
        ButtonImage.enabled = true;
        equip.enabled = true;
        Name.text = defaultitem.Itemname + "\n" + "Quality = " + defaultitem.Itemquality;
        if (Stats.text == "")
        {
            Stats.text += "\n";
            if (defaultitem.Itemdamage != 0)
            {
                Stats.text += "Damage = " + defaultitem.Itemdamage + "\n\n";
            }
            if (defaultitem.ItemcritChance != 0)
            {
                Stats.text += "Critical Chance = " + defaultitem.ItemcritChance + "%\n\n";
            }
            if (defaultitem.ItemcritDamage != 0)
            {
                Stats.text += "Critical Damage = " + defaultitem.ItemcritDamage + "%\n\n";
            }
            if (defaultitem.Itemhealth != 0)
            {
                Stats.text += "Health = " + defaultitem.Itemhealth + "\n\n";
            }
            if (defaultitem.Itemdefence != 0)
            {
                Stats.text += "Defence = " + defaultitem.Itemdefence + "\n\n";
            }
        }
        Description.text = "\" " + defaultitem.Itemdesc + " \"";
    }

    public void Equip() // Equiping the items
    {
        if (defaultitem != null)
        {
            UnityEngine.Debug.Log("Calling Equipment Manager");
            ButtonText.enabled = false;
            ButtonImage.enabled = false;
            equip.enabled = false;
            Inventory.instance.Equip(defaultitem);
            RemoveStatsText(); // Calling RemoveStatsText to remove the item's stats from the panel.
        }
    }

    public void RemoveStatsText() // Resetting values in order to show the others when they come.
    {
        Name.text = "";
        Stats.text = "";
        Description.text = "";
        ButtonText.enabled = false;
        ButtonImage.enabled = false;
        equip.enabled = false;
    }
}
