using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestLootScript : MonoBehaviour
{
    
    [Header("ChestTypes")]
    [SerializeField] private string type;

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

    }
}
