using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class ChestLootScript : MonoBehaviour
{
    [Header("Chest Rarities")]
    [SerializeField] static private int WoodenChest;
    [SerializeField] static private int BronzeChest;
    [SerializeField] static private int SilverChest;
    [SerializeField] static private int GoldChest;
    [SerializeField] static private int PlatinumChest;
    readonly private int total = WoodenChest + BronzeChest + SilverChest + GoldChest + PlatinumChest; 
    
    [Header("Wooden Chest Loot")]
    [SerializeField] static private int wCommon;
    [SerializeField] static private int wUncommon;
    [SerializeField] static private int wRare;
    [SerializeField] static private int wEpic;
    [SerializeField] static private int wLegendary;

    [Header("Bronze Chest Loot")]
    [SerializeField] static private int bCommon;
    [SerializeField] static private int bUncommon;
    [SerializeField] static private int bRare;
    [SerializeField] static private int bEpic;
    [SerializeField] static private int bLegendary;

    [Header("Silver Chest Loot")]
    [SerializeField] static private int sCommon;
    [SerializeField] static private int sUncommon;
    [SerializeField] static private int sRare;
    [SerializeField] static private int sEpic;
    [SerializeField] static private int sLegendary;

    [Header("Gold Chest Loot")]
    [SerializeField] static private int gCommon;
    [SerializeField] static private int gUncommon;
    [SerializeField] static private int gRare;
    [SerializeField] static private int gEpic;
    [SerializeField] static private int gLegendary;

    [Header("Platinum Chest Loot")]
    [SerializeField] static private int pCommon;
    [SerializeField] static private int pUncommon;
    [SerializeField] static private int pRare;
    [SerializeField] static private int pEpic;
    [SerializeField] static private int pLegendary;
    void Start()
    {
        
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
        int chest = Random.Range(0, total);
        if (chest > total-WoodenChest) 
        {
            Debug.Log("Got a wooden chest");
        
        }
    }
}
