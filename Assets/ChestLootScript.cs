using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class ChestLootScript : MonoBehaviour
{
    
    [Header("ChestDrops")]
    [SerializeField] private string drop;
    
    void Start()
    {
        List<ChestLootScript> woodenChest = new List<ChestLootScript>();
            woodenChest.Add(new ChestLootScript());
            woodenChest.Add(new ChestLootScript());
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
        Debug.Log("got "+drop);
    }
    
}
