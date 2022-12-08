using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterStatDisplay : MonoBehaviour
{
    public TextMeshProUGUI CharacterName, CharacterLevel, HealthStat, DamageStat, DefenceStat, CriticalChanceStat, CriticalDamageStat, StatPoints;
    public Image CharacterPicture;
    public Button Health, Damage, Defence, CriticalChance, CriticalDamage;
    public Player player;

    void Start()
    {
        CharacterName.text = player.Pusername;
        CharacterLevel.text = player.level.ToString();
        HealthStat.text = player.PmaxHealth.ToString();
        DamageStat.text = player.PDamage.ToString();
        DefenceStat.text = player.PDefence.ToString();
        CriticalChanceStat.text = player.PCriticalChance.ToString() + "%";
        CriticalDamageStat.text = player.PCriticalDamage.ToString() + "%";
        StatPoints.text = player.PStat.ToString();
        CharacterPicture.sprite = player.image.sprite;
    }

    void Update()
    {
        CharacterLevel.text = player.level.ToString();
        HealthStat.text = player.PmaxHealth.ToString();
        DamageStat.text = player.PDamage.ToString();
        DefenceStat.text = player.PDefence.ToString();
        CriticalChanceStat.text = player.PCriticalChance.ToString() + "%";
        CriticalDamageStat.text = player.PCriticalDamage.ToString() + "%";
        StatPoints.text = player.PStat.ToString();
    }

    void Awake()
    {
        Health.onClick.AddListener(() => { if (player.PStat > 0) { player.PmaxHealth += 10.0f; player.PcurrentHealth += 10.0f; player.PStat--; StatPoints.text = player.PStat.ToString(); } });
        Damage.onClick.AddListener(() => { if (player.PStat > 0) { player.PDamage += 5.0f; player.PStat--; StatPoints.text = player.PStat.ToString(); } });
        Defence.onClick.AddListener(() => { if (player.PStat > 0) { player.PDefence += 1.0f; player.PStat--; StatPoints.text = player.PStat.ToString(); } });
        CriticalChance.onClick.AddListener(() => { if (player.PStat > 0) { player.PCriticalChance += 2.0f; player.PStat--; StatPoints.text = player.PStat.ToString(); ; } });
        CriticalDamage.onClick.AddListener(() => { if (player.PStat > 0) { player.PCriticalDamage += 5.0f; player.PStat--; StatPoints.text = player.PStat.ToString(); } });
    }
}
