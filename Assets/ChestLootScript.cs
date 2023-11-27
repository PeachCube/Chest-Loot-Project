using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Xml.Schema;
using UnityEditor;
using UnityEngine;

public class ChestLootScript : MonoBehaviour
{
    [Header("Chest Rarities")]
    [SerializeField] private int WoodenChest;
    [SerializeField] private int BronzeChest;
    [SerializeField] private int SilverChest;
    [SerializeField] private int GoldChest;
    [SerializeField] private int PlatinumChest;
    [SerializeField] private string chestPicked;
    [SerializeField] private string chestPrize;
    public List<string> chestLoot;
    
    [Header("Wooden Chest Loot")]
    [SerializeField] private int wCommon;
    [SerializeField] private int wUncommon;
    [SerializeField] private int wRare;
    [SerializeField] private int wEpic;
    [SerializeField] private int wLegendary;
    public List<string> woodenLoot;
    
    [Header("Bronze Chest Loot")]
    [SerializeField] private int bCommon;
    [SerializeField] private int bUncommon;
    [SerializeField] private int bRare;
    [SerializeField] private int bEpic;
    [SerializeField] private int bLegendary;
    public List<string> bronzeLoot;

    [Header("Silver Chest Loot")]
    [SerializeField] private int sCommon;
    [SerializeField] private int sUncommon;
    [SerializeField] private int sRare;
    [SerializeField] private int sEpic;
    [SerializeField] private int sLegendary;
    public List<string> silverLoot;

    [Header("Gold Chest Loot")]
    [SerializeField] private int gCommon;
    [SerializeField] private int gUncommon;
    [SerializeField] private int gRare;
    [SerializeField] private int gEpic;
    [SerializeField] private int gLegendary;
    public List<string> goldLoot;

    [Header("Platinum Chest Loot")]
    [SerializeField] private int pCommon;
    [SerializeField] private int pUncommon;
    [SerializeField] private int pRare;
    [SerializeField] private int pEpic;
    [SerializeField] private int pLegendary;
    public List<string> platinumLoot;
    void Start()
    {
        for (int i = 0; i <= WoodenChest; i ++){ chestLoot.Add(new string("WoodenChest")); }
        for (int i = 0; i <= BronzeChest; i++){ chestLoot.Add(new string("BronzeChest")); }
        for (int i = 0; i <= SilverChest; i++){ chestLoot.Add(new string("SilverChest")); }
        for (int i = 0; i <= GoldChest; i++){ chestLoot.Add(new string("GoldChest")); }
        for (int i = 0; i <= PlatinumChest; i++){ chestLoot.Add(new string("PlatinumChest")); }

        for (int i = 0; i <= wCommon; i++) { woodenLoot.Add(new string("Common")); }
        for (int i = 0; i <= wUncommon; i++) { woodenLoot.Add(new string("Uncommon")); }
        for (int i = 0; i <= wRare; i++) { woodenLoot.Add(new string("Rare")); }
        for (int i = 0; i <= wEpic; i++) { woodenLoot.Add(new string("Epic")); }
        for (int i = 0; i <= wLegendary; i++) { woodenLoot.Add(new string("Legendary")); }

        for (int i = 0; i <= bCommon; i++) { bronzeLoot.Add(new string("Common")); }
        for (int i = 0; i <= bUncommon; i++) { bronzeLoot.Add(new string("Uncommon")); }
        for (int i = 0; i <= bRare; i++) { bronzeLoot.Add(new string("Rare")); }
        for (int i = 0; i <= bEpic; i++) { bronzeLoot.Add(new string("Epic")); }
        for (int i = 0; i <= bLegendary; i++) { bronzeLoot.Add(new string("Legendary")); }

        for (int i = 0; i <= sCommon; i++) { silverLoot.Add(new string("Common")); }
        for (int i = 0; i <= sUncommon; i++) { silverLoot.Add(new string("Uncommon")); }
        for (int i = 0; i <= sRare; i++) { silverLoot.Add(new string("Rare")); }
        for (int i = 0; i <= sEpic; i++) { silverLoot.Add(new string("Epic")); }
        for (int i = 0; i <= sLegendary; i++) { silverLoot.Add(new string("Legendary")); }

        for (int i = 0; i <= gCommon; i++) { goldLoot.Add(new string("Common")); }
        for (int i = 0; i <= gUncommon; i++) { goldLoot.Add(new string("Uncommon")); }
        for (int i = 0; i <= gRare; i++) { goldLoot.Add(new string("Rare")); }
        for (int i = 0; i <= gEpic; i++) { goldLoot.Add(new string("Epic")); }
        for (int i = 0; i <= gLegendary; i++) { goldLoot.Add(new string("Legendary")); }

        for (int i = 0; i <= pCommon; i++) { platinumLoot.Add(new string("Common")); }
        for (int i = 0; i <= pUncommon; i++) { platinumLoot.Add(new string("Uncommon")); }
        for (int i = 0; i <= pRare; i++) { platinumLoot.Add(new string("Rare")); }
        for (int i = 0; i <= pEpic; i++) { platinumLoot.Add(new string("Epic")); }
        for (int i = 0; i <= pLegendary; i++) { platinumLoot.Add(new string("Legendary")); }

    }
        
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LootPicker();
        }
    }
    void LootPicker()
    {
        chestPicked = chestLoot[Random.Range(0, chestLoot.Count)];
        Debug.Log(chestPicked);
        
        if (chestPicked == "WoodenChest")
        {
            chestPrize = woodenLoot[Random.Range(0, woodenLoot.Count)];
        }
        else if (chestPicked == "BronzeChest")
        {
            chestPrize = bronzeLoot[Random.Range(0, bronzeLoot.Count)];
        }
        else if (chestPicked == "SilverChest")
        {
            chestPrize = silverLoot[Random.Range(0, silverLoot.Count)];
        }
        else if (chestPicked == "GoldChest")
        {
            chestPrize = goldLoot[Random.Range(0, goldLoot.Count)];
        }
        else if (chestPicked == "PlatinumChest")
        {
            chestPrize = platinumLoot[Random.Range(0, platinumLoot.Count)];
        }
        Debug.Log(chestPrize);
    }
}
